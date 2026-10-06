using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai5._3
{
    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

    public partial class Form1 : Form
    {
        private List<Product> productList = new List<Product>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            InitData();

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSearch.Click += BtnSearch_Click;
            dgvProducts.CellClick += DgvProducts_CellClick;
        }

        private void InitData()
        {
            cboCategory.Items.AddRange(new string[] { "Điện thoại", "Laptop", "Phụ kiện", "Thiết bị văn phòng" });
            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }

            bindingSource.DataSource = productList;
            dgvProducts.DataSource = bindingSource;
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtProductId.Focus();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text) || string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SP và Tên SP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productList.Any(p => p.ProductId.Equals(txtProductId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product prod = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.SelectedItem?.ToString() ?? "",
                UnitPrice = unitPrice,
                Quantity = quantity
            };

            productList.Add(prod);
            bindingSource.ResetBindings(false);
            ClearInputs();
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();
            Product? prod = productList.FirstOrDefault(p => p.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (prod == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            prod.ProductName = txtProductName.Text.Trim();
            prod.Category = cboCategory.SelectedItem?.ToString() ?? "";
            prod.UnitPrice = unitPrice;
            prod.Quantity = quantity;

            bindingSource.ResetBindings(false);
            ClearInputs();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product prod)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm '{prod.ProductName}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    productList.Remove(prod);
                    bindingSource.ResetBindings(false);
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                bindingSource.DataSource = productList;
            }
            else
            {
                var filteredList = productList.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                bindingSource.DataSource = filteredList;
            }
            bindingSource.ResetBindings(false);
        }

        private void DgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].DataBoundItem is Product prod)
            {
                txtProductId.Text = prod.ProductId;
                txtProductName.Text = prod.ProductName;
                cboCategory.SelectedItem = prod.Category;
                txtUnitPrice.Text = prod.UnitPrice.ToString();
                txtQuantity.Text = prod.Quantity.ToString();
            }
        }
    }
}