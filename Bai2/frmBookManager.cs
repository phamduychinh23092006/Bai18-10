using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManagementSystem.Models;

namespace BookManagementSystem.Forms
{
    public partial class frmBookManager : Form
    {
        private BindingList<BookModel> bookList;
        private BindingSource bindingSource;
        private ErrorProvider errorProvider;
        private string currentImagePath = string.Empty;

        public frmBookManager()
        {
            InitializeComponent();
            SetupCustomLogic();
        }

        private void SetupCustomLogic()
        {
            // 1. Cấu hình Binding Data
            bookList = new BindingList<BookModel>();
            bindingSource = new BindingSource { DataSource = bookList };

            // 2. ErrorProvider
            errorProvider = new ErrorProvider();

            // 3. Cấu hình DataGridView bằng Code
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookId",
                HeaderText = "Mã sách",
                Width = 90
            };

            DataGridViewTextBoxColumn colTitle = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Tên sách",
                Width = 200
            };

            DataGridViewTextBoxColumn colAuthor = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Author",
                HeaderText = "Tác giả",
                Width = 140
            };

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn giá",
                Width = 110
            };
            colPrice.DefaultCellStyle.Format = "N0";

            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Số lượng",
                Width = 90
            };

            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalValue",
                HeaderText = "Thành tiền",
                Width = 130
            };
            colTotal.DefaultCellStyle.Format = "N0";

            DataGridViewTextBoxColumn colImage = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ImagePath",
                HeaderText = "Đường dẫn ảnh",
                Width = 150
            };

            dgvBooks.Columns.AddRange(new DataGridViewColumn[] {
                colId, colTitle, colAuthor, colPrice, colQty, colTotal, colImage
            });
            dgvBooks.DataSource = bindingSource;

            // Đăng ký sự kiện
            dgvBooks.SelectionChanged += DgvBooks_SelectionChanged;
            btnUploadImage.Click += BtnUploadImage_Click;

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            menuOpenCsv.Click += MenuOpenCsv_Click;
            tsbOpen.Click += MenuOpenCsv_Click;

            menuSaveCsv.Click += MenuSaveCsv_Click;
            tsbSave.Click += MenuSaveCsv_Click;

            menuAdd.Click += BtnAdd_Click;
            tsbAdd.Click += BtnAdd_Click;
            menuDelete.Click += BtnDelete_Click;
            menuExit.Click += (s, e) => Application.Exit();

            timerClock.Tick += TimerClock_Tick;

            // Cập nhật StatusStrip ban đầu
            UpdateStatusStrip();
        }

        // 1. Nghiệp vụ Chọn ảnh bìa (OpenFileDialog)
        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh bìa sách";
                ofd.Filter = "Tập tin hình ảnh (*.jpg; *.png)|*.jpg;*.png|Tất cả tập tin (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;
                    try
                    {
                        using (var stream = new FileStream(currentImagePath, FileMode.Open, FileAccess.Read))
                        {
                            picBookCover.Image = Image.FromStream(stream);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không thể tải hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 2. Nghiệp vụ Xuất file CSV (SaveFileDialog)
        private void MenuSaveCsv_Click(object sender, EventArgs e)
        {
            if (bookList.Count == 0)
            {
                MessageBox.Show("Danh sách sách hiện tại đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách sách ra file CSV";
                sfd.Filter = "Tập tin CSV (*.csv)|*.csv";
                sfd.FileName = "BaoCaoNhaSach.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        // Ghi header
                        sb.AppendLine("BookId,Title,Author,Price,Quantity,ImagePath");

                        foreach (var book in bookList)
                        {
                            sb.AppendLine($"{book.BookId},{EscapeCsv(book.Title)},{EscapeCsv(book.Author)},{book.Price},{book.Quantity},{EscapeCsv(book.ImagePath)}");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất báo cáo CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 3. Nghiệp vụ Mở file CSV (OpenFileDialog)
        private void MenuOpenCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file CSV chứa danh sách sách";
                ofd.Filter = "Tập tin CSV (*.csv)|*.csv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                        if (lines.Length <= 1)
                        {
                            MessageBox.Show("File CSV không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bookList.Clear();
                        // Bỏ qua dòng header (index 0)
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string line = lines[i].Trim();
                            if (string.IsNullOrEmpty(line)) continue;

                            string[] parts = line.Split(',');
                            if (parts.Length >= 6)
                            {
                                var book = new BookModel
                                {
                                    BookId = parts[0].Trim(),
                                    Title = parts[1].Trim(),
                                    Author = parts[2].Trim(),
                                    Price = decimal.TryParse(parts[3], out decimal price) ? price : 0,
                                    Quantity = int.TryParse(parts[4], out int qty) ? qty : 0,
                                    ImagePath = parts[5].Trim()
                                };
                                bookList.Add(book);
                            }
                        }

                        UpdateStatusStrip();
                        ClearForm();
                        MessageBox.Show("Đọc dữ liệu CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Cập nhật StatusStrip tự động
        private void UpdateStatusStrip()
        {
            int totalBooks = bookList.Count;
            decimal totalValue = bookList.Sum(b => b.TotalValue);

            tslblTotalBooks.Text = $"Tổng đầu sách: {totalBooks}";
            tslblTotalValue.Text = $"Tổng giá trị kho: {totalValue:N0} VNĐ";
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            tslblClock.Text = $"Thời gian: {DateTime.Now:HH:mm:ss}";
        }

        private bool ValidateData()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtBookId.Text.Trim()))
            {
                errorProvider.SetError(txtBookId, "Mã sách không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                errorProvider.SetError(txtTitle, "Tên sách không được để trống!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                errorProvider.SetError(txtPrice, "Đơn giá phải là số nguyên dương!");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty < 0)
            {
                errorProvider.SetError(txtQuantity, "Số lượng phải là số nguyên không âm!");
                isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            string id = txtBookId.Text.Trim();
            if (bookList.Any(b => b.BookId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtBookId, "Mã sách này đã tồn tại!");
                return;
            }

            var book = new BookModel
            {
                BookId = id,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                ImagePath = currentImagePath
            };

            bookList.Add(book);
            UpdateStatusStrip();
            ClearForm();
            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateData()) return;

            if (bindingSource.Current is BookModel selectedBook)
            {
                selectedBook.Title = txtTitle.Text.Trim();
                selectedBook.Author = txtAuthor.Text.Trim();
                selectedBook.Price = decimal.Parse(txtPrice.Text.Trim());
                selectedBook.Quantity = int.Parse(txtQuantity.Text.Trim());
                selectedBook.ImagePath = currentImagePath;

                bindingSource.ResetBindings(false);
                UpdateStatusStrip();
                MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài liệu sách này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (bindingSource.Current is BookModel selectedBook)
                {
                    bookList.Remove(selectedBook);
                    UpdateStatusStrip();
                    ClearForm();
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            currentImagePath = string.Empty;
            picBookCover.Image = null;
            errorProvider.Clear();
            dgvBooks.ClearSelection();
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null && bindingSource.Current is BookModel selectedBook)
            {
                txtBookId.Text = selectedBook.BookId;
                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
                txtPrice.Text = selectedBook.Price.ToString("0");
                txtQuantity.Text = selectedBook.Quantity.ToString();
                currentImagePath = selectedBook.ImagePath;

                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    try
                    {
                        using (var stream = new FileStream(currentImagePath, FileMode.Open, FileAccess.Read))
                        {
                            picBookCover.Image = Image.FromStream(stream);
                        }
                    }
                    catch
                    {
                        picBookCover.Image = null;
                    }
                }
                else
                {
                    picBookCover.Image = null;
                }

                errorProvider.Clear();
            }
        }

        private string EscapeCsv(string str)
        {
            if (string.IsNullOrEmpty(str)) return "";
            if (str.Contains(",") || str.Contains("\"") || str.Contains("\n"))
            {
                return $"\"{str.Replace("\"", "\"\"")}\"";
            }
            return str;
        }
    }
}