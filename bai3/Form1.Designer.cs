using System.Windows.Forms;

namespace bai5._3
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();

            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.grpThongTin.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            this.grpThongTin.Controls.Add(this.lblProductId);
            this.grpThongTin.Controls.Add(this.txtProductId);
            this.grpThongTin.Controls.Add(this.lblProductName);
            this.grpThongTin.Controls.Add(this.txtProductName);
            this.grpThongTin.Controls.Add(this.lblCategory);
            this.grpThongTin.Controls.Add(this.cboCategory);
            this.grpThongTin.Controls.Add(this.lblUnitPrice);
            this.grpThongTin.Controls.Add(this.txtUnitPrice);
            this.grpThongTin.Controls.Add(this.lblQuantity);
            this.grpThongTin.Controls.Add(this.txtQuantity);
            this.grpThongTin.Location = new System.Drawing.Point(20, 15);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(600, 130);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sản phẩm";

            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(20, 30);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(43, 15);
            this.lblProductId.Text = "Mã SP:";

            this.txtProductId.Location = new System.Drawing.Point(80, 27);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 23);

            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(310, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 15);
            this.lblProductName.Text = "Tên SP:";

            this.txtProductName.Location = new System.Drawing.Point(370, 27);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 23);

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 65);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 15);
            this.lblCategory.Text = "Danh mục:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(80, 62);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 23);

            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(310, 65);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(51, 15);
            this.lblUnitPrice.Text = "Đơn giá:";

            this.txtUnitPrice.Location = new System.Drawing.Point(370, 62);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 23);

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 98);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 15);
            this.lblQuantity.Text = "Số lượng:";

            this.txtQuantity.Location = new System.Drawing.Point(80, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 23);

            this.grpChucNang.Controls.Add(this.btnAdd);
            this.grpChucNang.Controls.Add(this.btnEdit);
            this.grpChucNang.Controls.Add(this.btnDelete);
            this.grpChucNang.Controls.Add(this.txtSearch);
            this.grpChucNang.Controls.Add(this.btnSearch);
            this.grpChucNang.Location = new System.Drawing.Point(20, 155);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(600, 70);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";

            this.btnAdd.Location = new System.Drawing.Point(20, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.Text = "Thêm";

            this.btnEdit.Location = new System.Drawing.Point(105, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.Text = "Sửa";

            this.btnDelete.Location = new System.Drawing.Point(190, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.Text = "Xóa";

            this.txtSearch.Location = new System.Drawing.Point(300, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 23);

            this.btnSearch.Location = new System.Drawing.Point(490, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Text = "Tìm kiếm";

            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 235);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(600, 200);

            this.ClientSize = new System.Drawing.Size(640, 455);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Sách Sản Phẩm";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvProducts;
    }
}