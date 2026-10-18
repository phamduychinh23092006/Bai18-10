using GymManagementSystem.Models;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymManagementSystem.Forms
{
    public partial class frmGymMemberManager : Form
    {
        private BindingList<MemberModel> memberList;
        private BindingSource bindingSource;
        private ErrorProvider errorProvider;
        private int currentIdCounter = 1;

        public frmGymMemberManager()
        {
            InitializeComponent();
            SetupCustomLogic();
        }

        private void SetupCustomLogic()
        {
            // 1. Cấu hình Binding Data
            memberList = new BindingList<MemberModel>();
            bindingSource = new BindingSource { DataSource = memberList };

            // 2. Khởi tạo ErrorProvider
            errorProvider = new ErrorProvider();

            // 3. Khởi tạo ComboBox
            cboPackage.Items.AddRange(new object[] { "Theo tháng", "6 tháng", "1 năm" });
            if (cboPackage.Items.Count > 0) cboPackage.SelectedIndex = 0;

            // 4. Cấu hình DataGridView hoàn toàn bằng Code
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MemberId",
                HeaderText = "Mã HV",
                Width = 80
            };

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Tên hội viên",
                Width = 160
            };

            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "SĐT",
                Width = 110
            };

            DataGridViewTextBoxColumn colPackage = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Package",
                HeaderText = "Gói tập",
                Width = 100
            };

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Ngày ĐK",
                Width = 110
            };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewTextBoxColumn colFee = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fee",
                HeaderText = "Phí dịch vụ",
                Width = 120
            };
            colFee.DefaultCellStyle.Format = "N0";

            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colPackage, colDate, colFee });
            dgvMembers.DataSource = bindingSource;

            // Đặt trạng thái ô Mã hội viên
            txtMemberId.ReadOnly = true;
            txtMemberId.Text = GenerateMemberId();

            // Đăng ký sự kiện
            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
        }

        private string GenerateMemberId()
        {
            return $"HV{currentIdCounter:D3}";
        }

        // Bắt lỗi dữ liệu nhập vào
        private bool ValidateData()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Bắt lỗi Họ tên: Không rỗng, không chứa số/ký tự đặc biệt
            string fullName = txtFullName.Text.Trim();
            if (string.IsNullOrEmpty(fullName))
            {
                errorProvider.SetError(txtFullName, "Họ tên không được để trống!");
                isValid = false;
            }
            else if (!Regex.IsMatch(fullName, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                errorProvider.SetError(txtFullName, "Họ tên không được chứa ký tự đặc biệt hoặc số!");
                isValid = false;
            }

            // Bắt lỗi SĐT: Đúng 10 chữ số
            string phone = txtPhone.Text.Trim();
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại phải đúng 10 chữ số!");
                isValid = false;
            }

            // Bắt lỗi Phí dịch vụ: Số nguyên dương
            if (!decimal.TryParse(txtFee.Text.Trim(), out decimal fee) || fee <= 0)
            {
                errorProvider.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương!");
                isValid = false;
            }

            return isValid;
        }

        // Sự kiện Thêm hội viên
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            var member = new MemberModel
            {
                MemberId = txtMemberId.Text,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem?.ToString() ?? "Theo tháng",
                StartDate = dtpStartDate.Value,
                Fee = decimal.Parse(txtFee.Text.Trim())
            };

            memberList.Add(member);
            currentIdCounter++;
            ClearForm();
            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện Sửa thông tin
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateData()) return;

            if (bindingSource.Current is MemberModel selectedMember)
            {
                selectedMember.FullName = txtFullName.Text.Trim();
                selectedMember.Phone = txtPhone.Text.Trim();
                selectedMember.Package = cboPackage.SelectedItem?.ToString() ?? "Theo tháng";
                selectedMember.StartDate = dtpStartDate.Value;
                selectedMember.Fee = decimal.Parse(txtFee.Text.Trim());

                bindingSource.ResetBindings(false); // Cập nhật ngay lập tức lên DataGridView
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện Xóa hội viên
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (bindingSource.Current is MemberModel selectedMember)
                {
                    memberList.Remove(selectedMember);
                    ClearForm();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Sự kiện Làm mới Form
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMemberId.Text = GenerateMemberId();
            txtFullName.Clear();
            txtPhone.Clear();
            if (cboPackage.Items.Count > 0) cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Clear();
            errorProvider.Clear();
            dgvMembers.ClearSelection();
        }

        // Đổ dữ liệu ngược lại Controls khi click chọn dòng trên DataGridView
        private void DgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null && bindingSource.Current is MemberModel selectedMember)
            {
                txtMemberId.Text = selectedMember.MemberId;
                txtFullName.Text = selectedMember.FullName;
                txtPhone.Text = selectedMember.Phone;
                cboPackage.SelectedItem = selectedMember.Package;
                dtpStartDate.Value = selectedMember.StartDate;
                txtFee.Text = selectedMember.Fee.ToString("0");
                errorProvider.Clear();
            }
        }
    }
}