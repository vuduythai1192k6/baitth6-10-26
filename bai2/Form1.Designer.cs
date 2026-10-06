using System.Windows.Forms;

namespace bai5._2
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
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailableServices = new Label();
            lstAvailableServices = new ListBox();
            lblSelectedServices = new Label();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            grpTinhTien = new GroupBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            lblDiscountRate = new Label();
            txtDiscountRate = new TextBox();
            lblFinalAmount = new Label();
            txtFinalAmount = new TextBox();
            grpTinhTien.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 20);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Loại dịch vụ:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(100, 17);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 28);
            cboCategory.TabIndex = 1;
            // 
            // lblAvailableServices
            // 
            lblAvailableServices.AutoSize = true;
            lblAvailableServices.Location = new Point(20, 55);
            lblAvailableServices.Name = "lblAvailableServices";
            lblAvailableServices.Size = new Size(131, 20);
            lblAvailableServices.TabIndex = 2;
            lblAvailableServices.Text = "Danh sách dịch vụ:";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(20, 75);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(220, 184);
            lstAvailableServices.TabIndex = 3;
            // 
            // lblSelectedServices
            // 
            lblSelectedServices.AutoSize = true;
            lblSelectedServices.Location = new Point(310, 55);
            lblSelectedServices.Name = "lblSelectedServices";
            lblSelectedServices.Size = new Size(118, 20);
            lblSelectedServices.TabIndex = 7;
            lblSelectedServices.Text = "Dịch vụ đã chọn:";
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(310, 75);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(220, 184);
            lstSelectedServices.TabIndex = 8;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(250, 95);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(50, 30);
            btnSelect.TabIndex = 4;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(250, 140);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(50, 30);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(250, 185);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(50, 30);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // grpTinhTien
            // 
            grpTinhTien.Controls.Add(lblTotalAmount);
            grpTinhTien.Controls.Add(txtTotalAmount);
            grpTinhTien.Controls.Add(lblDiscountRate);
            grpTinhTien.Controls.Add(txtDiscountRate);
            grpTinhTien.Controls.Add(lblFinalAmount);
            grpTinhTien.Controls.Add(txtFinalAmount);
            grpTinhTien.Location = new Point(20, 275);
            grpTinhTien.Name = "grpTinhTien";
            grpTinhTien.Size = new Size(510, 130);
            grpTinhTien.TabIndex = 9;
            grpTinhTien.TabStop = false;
            grpTinhTien.Text = "Thông tin thanh toán";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(20, 30);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(149, 20);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "Tổng tiền chưa giảm:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(198, 27);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(282, 27);
            txtTotalAmount.TabIndex = 1;
            txtTotalAmount.Text = "0 VNĐ";
            // 
            // lblDiscountRate
            // 
            lblDiscountRate.AutoSize = true;
            lblDiscountRate.Location = new Point(20, 62);
            lblDiscountRate.Name = "lblDiscountRate";
            lblDiscountRate.Size = new Size(140, 20);
            lblDiscountRate.TabIndex = 2;
            lblDiscountRate.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // txtDiscountRate
            // 
            txtDiscountRate.Location = new Point(198, 59);
            txtDiscountRate.Name = "txtDiscountRate";
            txtDiscountRate.Size = new Size(282, 27);
            txtDiscountRate.TabIndex = 3;
            txtDiscountRate.Text = "0";
            // 
            // lblFinalAmount
            // 
            lblFinalAmount.AutoSize = true;
            lblFinalAmount.Location = new Point(20, 94);
            lblFinalAmount.Name = "lblFinalAmount";
            lblFinalAmount.Size = new Size(156, 20);
            lblFinalAmount.TabIndex = 4;
            lblFinalAmount.Text = "Thành tiền thanh toán:";
            // 
            // txtFinalAmount
            // 
            txtFinalAmount.Location = new Point(198, 91);
            txtFinalAmount.Name = "txtFinalAmount";
            txtFinalAmount.ReadOnly = true;
            txtFinalAmount.Size = new Size(282, 27);
            txtFinalAmount.TabIndex = 5;
            txtFinalAmount.Text = "0 VNĐ";
            // 
            // Form1
            // 
            ClientSize = new Size(550, 425);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvailableServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(lblSelectedServices);
            Controls.Add(lstSelectedServices);
            Controls.Add(grpTinhTien);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng Tính Tiền Dịch Vụ Và Chiết Khấu";
            grpTinhTien.ResumeLayout(false);
            grpTinhTien.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailableServices;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblSelectedServices;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.GroupBox grpTinhTien;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblDiscountRate;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.TextBox txtFinalAmount;
    }
}