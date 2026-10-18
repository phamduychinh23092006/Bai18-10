namespace BookManagementSystem.Forms
{
    partial class frmBookManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblTotalBooks = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;

            // menuFile
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenCsv,
            this.menuSaveCsv,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(69, 24);
            this.menuFile.Text = "Tập tin";

            // menuOpenCsv
            this.menuOpenCsv.Name = "menuOpenCsv";
            this.menuOpenCsv.Size = new System.Drawing.Size(182, 26);
            this.menuOpenCsv.Text = "Mở file CSV";

            // menuSaveCsv
            this.menuSaveCsv.Name = "menuSaveCsv";
            this.menuSaveCsv.Size = new System.Drawing.Size(182, 26);
            this.menuSaveCsv.Text = "Lưu file CSV";

            // menuExit
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(182, 26);
            this.menuExit.Text = "Thoát";

            // menuEdit
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuDelete,
            this.menuSearch});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(72, 24);
            this.menuEdit.Text = "Thao tác";

            // menuAdd
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(153, 26);
            this.menuAdd.Text = "Thêm sách";

            // menuDelete
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(153, 26);
            this.menuDelete.Text = "Xóa sách";

            // menuSearch
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(153, 26);
            this.menuSearch.Text = "Tìm kiếm";

            // toolStrip1
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tsbAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 27);
            this.toolStrip1.TabIndex = 1;

            // tsbOpen
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(91, 24);
            this.tsbOpen.Text = "📂 Mở CSV";

            // tsbSave
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(88, 24);
            this.tsbSave.Text = "💾 Lưu CSV";

            // tsbAdd
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(98, 24);
            this.tsbAdd.Text = "➕ Thêm mới";

            // statusStrip1
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTotalBooks,
            this.tslblTotalValue,
            this.tslblClock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 26);
            this.statusStrip1.TabIndex = 2;

            // tslblTotalBooks
            this.tslblTotalBooks.Name = "tslblTotalBooks";
            this.tslblTotalBooks.Size = new System.Drawing.Size(131, 20);
            this.tslblTotalBooks.Text = "Tổng đầu sách: 0";

            // tslblTotalValue
            this.tslblTotalValue.Name = "tslblTotalValue";
            this.tslblTotalValue.Size = new System.Drawing.Size(684, 20);
            this.tslblTotalValue.Spring = true;
            this.tslblTotalValue.Text = "Tổng giá trị kho: 0 VNĐ";

            // tslblClock
            this.tslblClock.Name = "tslblClock";
            this.tslblClock.Size = new System.Drawing.Size(152, 20);
            this.tslblClock.Text = "Thời gian: --:--:--";

            // gbInfo
            this.gbInfo.Controls.Add(this.lblBookId);
            this.gbInfo.Controls.Add(this.txtBookId);
            this.gbInfo.Controls.Add(this.lblTitle);
            this.gbInfo.Controls.Add(this.txtTitle);
            this.gbInfo.Controls.Add(this.lblAuthor);
            this.gbInfo.Controls.Add(this.txtAuthor);
            this.gbInfo.Controls.Add(this.lblPrice);
            this.gbInfo.Controls.Add(this.txtPrice);
            this.gbInfo.Controls.Add(this.lblQuantity);
            this.gbInfo.Controls.Add(this.txtQuantity);
            this.gbInfo.Controls.Add(this.btnUploadImage);
            this.gbInfo.Controls.Add(this.picBookCover);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbInfo.Location = new System.Drawing.Point(12, 65);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(958, 200);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin tài liệu sách";

            // Controls inside gbInfo
            this.lblBookId.Location = new System.Drawing.Point(20, 35);
            this.lblBookId.Size = new System.Drawing.Size(80, 25);
            this.lblBookId.Text = "Mã sách:";
            this.txtBookId.Location = new System.Drawing.Point(100, 32);
            this.txtBookId.Size = new System.Drawing.Size(250, 30);

            this.lblTitle.Location = new System.Drawing.Point(20, 75);
            this.lblTitle.Size = new System.Drawing.Size(80, 25);
            this.lblTitle.Text = "Tên sách:";
            this.txtTitle.Location = new System.Drawing.Point(100, 72);
            this.txtTitle.Size = new System.Drawing.Size(250, 30);

            this.lblAuthor.Location = new System.Drawing.Point(20, 115);
            this.lblAuthor.Size = new System.Drawing.Size(80, 25);
            this.lblAuthor.Text = "Tác giả:";
            this.txtAuthor.Location = new System.Drawing.Point(100, 112);
            this.txtAuthor.Size = new System.Drawing.Size(250, 30);

            this.lblPrice.Location = new System.Drawing.Point(380, 35);
            this.lblPrice.Size = new System.Drawing.Size(80, 25);
            this.lblPrice.Text = "Đơn giá:";
            this.txtPrice.Location = new System.Drawing.Point(460, 32);
            this.txtPrice.Size = new System.Drawing.Size(230, 30);

            this.lblQuantity.Location = new System.Drawing.Point(380, 75);
            this.lblQuantity.Size = new System.Drawing.Size(80, 25);
            this.lblQuantity.Text = "Số lượng:";
            this.txtQuantity.Location = new System.Drawing.Point(460, 72);
            this.txtQuantity.Size = new System.Drawing.Size(230, 30);

            this.btnUploadImage.Location = new System.Drawing.Point(380, 112);
            this.btnUploadImage.Size = new System.Drawing.Size(310, 35);
            this.btnUploadImage.Text = "🖼️ Tải ảnh bìa";

            // picBookCover
            this.picBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBookCover.Location = new System.Drawing.Point(720, 25);
            this.picBookCover.Name = "picBookCover";
            this.picBookCover.Size = new System.Drawing.Size(120, 160);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBookCover.TabStop = false;

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(200, 275);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Thêm sách";

            this.btnEdit.Location = new System.Drawing.Point(340, 275);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Text = "Sửa thông tin";

            this.btnDelete.Location = new System.Drawing.Point(480, 275);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Xóa sách";

            this.btnClear.Location = new System.Drawing.Point(620, 275);
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Làm mới";

            // dgvBooks
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 320);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.Size = new System.Drawing.Size(958, 240);

            // timerClock
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;

            // Form Main
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmBookManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tài liệu Sách & Báo cáo Nhà sách";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenCsv;
        private System.Windows.Forms.ToolStripMenuItem menuSaveCsv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbAdd;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalBooks;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalValue;
        private System.Windows.Forms.ToolStripStatusLabel tslblClock;

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox picBookCover;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Timer timerClock;
    }
}