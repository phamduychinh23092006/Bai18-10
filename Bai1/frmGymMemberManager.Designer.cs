namespace GymManagementSystem.Forms
{
    partial class frmGymMemberManager
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(180, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 37);
            this.lblTitle.Text = "QUẢN LÝ HỘI VIÊN PHÒNG GYM";

            // gbInfo
            this.gbInfo.Controls.Add(this.lblMemberId);
            this.gbInfo.Controls.Add(this.txtMemberId);
            this.gbInfo.Controls.Add(this.lblFullName);
            this.gbInfo.Controls.Add(this.txtFullName);
            this.gbInfo.Controls.Add(this.lblPhone);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.lblPackage);
            this.gbInfo.Controls.Add(this.cboPackage);
            this.gbInfo.Controls.Add(this.lblStartDate);
            this.gbInfo.Controls.Add(this.dtpStartDate);
            this.gbInfo.Controls.Add(this.lblFee);
            this.gbInfo.Controls.Add(this.txtFee);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbInfo.Location = new System.Drawing.Point(20, 60);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(740, 160);
            this.gbInfo.Text = "Thông tin hội viên";

            // lblMemberId & txtMemberId
            this.lblMemberId.Location = new System.Drawing.Point(20, 35);
            this.lblMemberId.Size = new System.Drawing.Size(90, 25);
            this.lblMemberId.Text = "Mã HV:";
            this.txtMemberId.Location = new System.Drawing.Point(110, 32);
            this.txtMemberId.Size = new System.Drawing.Size(230, 30);

            // lblFullName & txtFullName
            this.lblFullName.Location = new System.Drawing.Point(20, 75);
            this.lblFullName.Size = new System.Drawing.Size(90, 25);
            this.lblFullName.Text = "Họ và tên:";
            this.txtFullName.Location = new System.Drawing.Point(110, 72);
            this.txtFullName.Size = new System.Drawing.Size(230, 30);

            // lblPhone & txtPhone
            this.lblPhone.Location = new System.Drawing.Point(20, 115);
            this.lblPhone.Size = new System.Drawing.Size(90, 25);
            this.lblPhone.Text = "Số ĐT:";
            this.txtPhone.Location = new System.Drawing.Point(110, 112);
            this.txtPhone.Size = new System.Drawing.Size(230, 30);

            // lblPackage & cboPackage
            this.lblPackage.Location = new System.Drawing.Point(380, 35);
            this.lblPackage.Size = new System.Drawing.Size(100, 25);
            this.lblPackage.Text = "Gói tập:";
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.Location = new System.Drawing.Point(480, 32);
            this.cboPackage.Size = new System.Drawing.Size(230, 30);

            // lblStartDate & dtpStartDate
            this.lblStartDate.Location = new System.Drawing.Point(380, 75);
            this.lblStartDate.Size = new System.Drawing.Size(100, 25);
            this.lblStartDate.Text = "Ngày ĐK:";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(480, 72);
            this.dtpStartDate.Size = new System.Drawing.Size(230, 30);

            // lblFee & txtFee
            this.lblFee.Location = new System.Drawing.Point(380, 115);
            this.lblFee.Size = new System.Drawing.Size(100, 25);
            this.lblFee.Text = "Phí dịch vụ:";
            this.txtFee.Location = new System.Drawing.Point(480, 112);
            this.txtFee.Size = new System.Drawing.Size(230, 30);

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(130, 235);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Thêm mới";

            this.btnUpdate.Location = new System.Drawing.Point(270, 235);
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.Text = "Sửa thông tin";

            this.btnDelete.Location = new System.Drawing.Point(410, 235);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Xóa hội viên";

            this.btnClear.Location = new System.Drawing.Point(550, 235);
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Làm mới";

            // DataGridView
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(20, 285);
            this.dgvMembers.Size = new System.Drawing.Size(740, 220);

            // Form main
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGymMemberManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ phòng Gym";

            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvMembers;
    }
}