using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        private class ServiceItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public ServiceItem(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} - {Price:N0} VNĐ";
            }
        }

        private Dictionary<string, List<ServiceItem>> serviceData = new Dictionary<string, List<ServiceItem>>();

        public Form1()
        {
            InitializeComponent();
            InitData();

            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
            btnSelect.Click += BtnSelect_Click;
            btnRemove.Click += BtnRemove_Click;
            btnClearAll.Click += BtnClearAll_Click;
            lstAvailableServices.DoubleClick += LstAvailableServices_DoubleClick;
            txtDiscountRate.TextChanged += TxtDiscountRate_TextChanged;

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        private void InitData()
        {
            serviceData["Khám bệnh"] = new List<ServiceItem>
            {
                new ServiceItem("Khám tổng quát", 150000),
                new ServiceItem("Khám chuyên khoa", 200000),
                new ServiceItem("Khám theo yêu cầu", 300000)
            };

            serviceData["Xét nghiệm"] = new List<ServiceItem>
            {
                new ServiceItem("Xét nghiệm máu", 100000),
                new ServiceItem("Xét nghiệm nước tiểu", 80000),
                new ServiceItem("Xét nghiệm sinh hóa", 250000)
            };

            serviceData["Chụp X-Quang"] = new List<ServiceItem>
            {
                new ServiceItem("Chụp X-Quang Phổi", 120000),
                new ServiceItem("Chụp X-Quang Cột sống", 180000),
                new ServiceItem("Chụp X-Quang Khớp", 150000)
            };

            serviceData["Vắc-xin"] = new List<ServiceItem>
            {
                new ServiceItem("Tiêm vắc-xin Cúm", 300000),
                new ServiceItem("Tiêm vắc-xin Viêm gan B", 250000),
                new ServiceItem("Tiêm vắc-xin Dại", 400000)
            };

            cboCategory.Items.Clear();
            foreach (var category in serviceData.Keys)
            {
                cboCategory.Items.Add(category);
            }
        }

        private void CboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem != null)
            {
                string category = cboCategory.SelectedItem.ToString() ?? "";
                if (serviceData.ContainsKey(category))
                {
                    foreach (var service in serviceData[category])
                    {
                        if (!lstSelectedServices.Items.Contains(service))
                        {
                            lstAvailableServices.Items.Add(service);
                        }
                    }
                }
            }
        }

        private void MoveSelectedAvailableToSelected()
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                var item = lstAvailableServices.SelectedItem;
                lstSelectedServices.Items.Add(item);
                lstAvailableServices.Items.Remove(item);
                CalculateTotal();
            }
        }

        private void BtnSelect_Click(object? sender, EventArgs e)
        {
            MoveSelectedAvailableToSelected();
        }

        private void LstAvailableServices_DoubleClick(object? sender, EventArgs e)
        {
            MoveSelectedAvailableToSelected();
        }

        private void BtnRemove_Click(object? sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                var item = lstSelectedServices.SelectedItem;
                lstSelectedServices.Items.Remove(item);

                if (cboCategory.SelectedItem != null && item is ServiceItem service)
                {
                    string category = cboCategory.SelectedItem.ToString() ?? "";
                    if (serviceData.ContainsKey(category) && serviceData[category].Contains(service))
                    {
                        lstAvailableServices.Items.Add(service);
                    }
                }

                CalculateTotal();
            }
        }

        private void BtnClearAll_Click(object? sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CboCategory_SelectedIndexChanged(null, EventArgs.Empty);
            CalculateTotal();
        }

        private void TxtDiscountRate_TextChanged(object? sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal totalAmount = 0;
            foreach (var item in lstSelectedServices.Items)
            {
                if (item is ServiceItem service)
                {
                    totalAmount += service.Price;
                }
            }

            decimal discountRate = 0;
            decimal.TryParse(txtDiscountRate.Text, out discountRate);
            if (discountRate < 0) discountRate = 0;
            if (discountRate > 100) discountRate = 100;

            decimal finalAmount = totalAmount * (1 - (discountRate / 100));

            txtTotalAmount.Text = $"{totalAmount:N0} VNĐ";
            txtFinalAmount.Text = $"{finalAmount:N0} VNĐ";
        }
    }
}