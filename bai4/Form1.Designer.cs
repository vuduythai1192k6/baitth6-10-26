using System.Windows.Forms;

namespace bai5._4
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblViewMode = new System.Windows.Forms.Label();
            this.cboViewMode = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDepartments = new System.Windows.Forms.TreeView();
            this.lsvEmployees = new System.Windows.Forms.ListView();
            this.colMaNV = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colChucVu = new System.Windows.Forms.ColumnHeader();
            this.colNgayVaoLam = new System.Windows.Forms.ColumnHeader();
            this.imgListTree = new System.Windows.Forms.ImageList(this.components);
            this.imgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imgListLarge = new System.Windows.Forms.ImageList(this.components);

            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            this.pnlTop.Controls.Add(this.lblViewMode);
            this.pnlTop.Controls.Add(this.cboViewMode);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(720, 40);
            this.pnlTop.TabIndex = 0;

            this.lblViewMode.AutoSize = true;
            this.lblViewMode.Location = new System.Drawing.Point(15, 12);
            this.lblViewMode.Name = "lblViewMode";
            this.lblViewMode.Size = new System.Drawing.Size(75, 15);
            this.lblViewMode.TabIndex = 0;
            this.lblViewMode.Text = "Chế độ xem:";

            this.cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewMode.FormattingEnabled = true;
            this.cboViewMode.Location = new System.Drawing.Point(95, 8);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Size = new System.Drawing.Size(160, 23);
            this.cboViewMode.TabIndex = 1;

            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.tvDepartments);
            this.splitContainer1.Panel2.Controls.Add(this.lsvEmployees);
            this.splitContainer1.Size = new System.Drawing.Size(720, 410);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 1;

            this.tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartments.Location = new System.Drawing.Point(0, 0);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.Size = new System.Drawing.Size(230, 410);
            this.tvDepartments.TabIndex = 0;

            this.lsvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colHoTen,
            this.colChucVu,
            this.colNgayVaoLam});
            this.lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployees.FullRowSelect = true;
            this.lsvEmployees.GridLines = true;
            this.lsvEmployees.Location = new System.Drawing.Point(0, 0);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.Size = new System.Drawing.Size(486, 410);
            this.lsvEmployees.TabIndex = 0;
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            this.lsvEmployees.View = System.Windows.Forms.View.Details;

            this.colMaNV.Text = "Mã NV";
            this.colMaNV.Width = 80;

            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 140;

            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 110;

            this.colNgayVaoLam.Text = "Ngày vào làm";
            this.colNgayVaoLam.Width = 110;

            this.imgListTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListTree.ImageSize = new System.Drawing.Size(16, 16);

            this.imgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListSmall.ImageSize = new System.Drawing.Size(16, 16);

            this.imgListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListLarge.ImageSize = new System.Drawing.Size(32, 32);

            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Quản Lý Tập Tin / Nhân Viên Dạng Chuyên Nghiệp";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblViewMode;
        private System.Windows.Forms.ComboBox cboViewMode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colNgayVaoLam;
        private System.Windows.Forms.ImageList imgListTree;
        private System.Windows.Forms.ImageList imgListSmall;
        private System.Windows.Forms.ImageList imgListLarge;
    }
}