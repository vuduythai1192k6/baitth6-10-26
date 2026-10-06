using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace bai5._4
{
    public class Employee
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string GroupCode { get; set; } = string.Empty;
    }

    public partial class Form1 : Form
    {
        private List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            InitImageLists();
            InitTreeViewData();
            InitEmployeeData();
            InitViewModes();

            tvDepartments.AfterSelect += TvDepartments_AfterSelect;
            cboViewMode.SelectedIndexChanged += CboViewMode_SelectedIndexChanged;

            if (tvDepartments.Nodes.Count > 0)
            {
                tvDepartments.SelectedNode = tvDepartments.Nodes[0];
            }
        }

        private void InitImageLists()
        {
            Bitmap bmpCompany = CreateColoredIcon(Color.Navy, 16);
            Bitmap bmpDept = CreateColoredIcon(Color.DarkOrange, 16);
            Bitmap bmpGroup = CreateColoredIcon(Color.SeaGreen, 16);

            imgListTree.Images.Add("company", bmpCompany);
            imgListTree.Images.Add("dept", bmpDept);
            imgListTree.Images.Add("group", bmpGroup);

            tvDepartments.ImageList = imgListTree;

            Bitmap bmpEmpSmall = CreateColoredIcon(Color.SteelBlue, 16);
            Bitmap bmpEmpLarge = CreateColoredIcon(Color.SteelBlue, 32);

            imgListSmall.Images.Add("emp", bmpEmpSmall);
            imgListLarge.Images.Add("emp", bmpEmpLarge);

            lsvEmployees.SmallImageList = imgListSmall;
            lsvEmployees.LargeImageList = imgListLarge;
        }

        private Bitmap CreateColoredIcon(Color color, int size)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, 1, 1, size - 2, size - 2);
                }
            }
            return bmp;
        }

        private void InitTreeViewData()
        {
            TreeNode rootNode = new TreeNode("Công ty ABC", 0, 0)
            {
                Tag = "ROOT"
            };

            TreeNode nodeIT = new TreeNode("Phòng IT", 1, 1) { Tag = "DEPT_IT" };
            TreeNode nodeITDev = new TreeNode("Nhóm Phát triển", 2, 2) { Tag = "IT_DEV" };
            TreeNode nodeITSys = new TreeNode("Nhóm Hệ thống", 2, 2) { Tag = "IT_SYS" };
            nodeIT.Nodes.Add(nodeITDev);
            nodeIT.Nodes.Add(nodeITSys);

            TreeNode nodeKT = new TreeNode("Phòng Kế toán", 1, 1) { Tag = "DEPT_KT" };
            TreeNode nodeKTThuChi = new TreeNode("Nhóm Thu chi", 2, 2) { Tag = "KT_TC" };
            TreeNode nodeKTLuong = new TreeNode("Nhóm Lương", 2, 2) { Tag = "KT_LUONG" };
            nodeKT.Nodes.Add(nodeKTThuChi);
            nodeKT.Nodes.Add(nodeKTLuong);

            TreeNode nodeNS = new TreeNode("Phòng Nhân sự", 1, 1) { Tag = "DEPT_NS" };
            TreeNode nodeNSTuyendung = new TreeNode("Nhóm Tuyển dụng", 2, 2) { Tag = "NS_TD" };
            nodeNS.Nodes.Add(nodeNSTuyendung);

            rootNode.Nodes.Add(nodeIT);
            rootNode.Nodes.Add(nodeKT);
            rootNode.Nodes.Add(nodeNS);

            tvDepartments.Nodes.Add(rootNode);
            tvDepartments.ExpandAll();
        }

        private void InitEmployeeData()
        {
            employeeList = new List<Employee>
            {
                new Employee { EmployeeId = "NV001", FullName = "Nguyễn Văn A", Position = "Lập trình viên", StartDate = new DateTime(2021, 3, 15), GroupCode = "IT_DEV" },
                new Employee { EmployeeId = "NV002", FullName = "Trần Thị B", Position = "Trưởng nhóm Dev", StartDate = new DateTime(2019, 6, 10), GroupCode = "IT_DEV" },
                new Employee { EmployeeId = "NV003", FullName = "Lê Văn C", Position = "Quản trị hệ thống", StartDate = new DateTime(2022, 1, 20), GroupCode = "IT_SYS" },
                new Employee { EmployeeId = "NV004", FullName = "Phạm Minh D", Position = "Kế toán viên", StartDate = new DateTime(2020, 8, 5), GroupCode = "KT_TC" },
                new Employee { EmployeeId = "NV005", FullName = "Hoàng Thu E", Position = "Chuyên viên lương", StartDate = new DateTime(2021, 11, 12), GroupCode = "KT_LUONG" },
                new Employee { EmployeeId = "NV006", FullName = "Vũ Hoàng F", Position = "Chuyên viên tuyển dụng", StartDate = new DateTime(2023, 2, 1), GroupCode = "NS_TD" }
            };
        }

        private void InitViewModes()
        {
            cboViewMode.Items.AddRange(new string[] { "Details", "LargeIcon", "SmallIcon", "List", "Tile" });
            cboViewMode.SelectedIndex = 0;
        }

        private void TvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                LoadEmployeesByNode(e.Node);
            }
        }

        private void LoadEmployeesByNode(TreeNode selectedNode)
        {
            lsvEmployees.Items.Clear();

            List<string> groupCodes = GetGroupCodesFromNode(selectedNode);

            var filteredEmployees = employeeList.Where(emp => groupCodes.Contains(emp.GroupCode)).ToList();

            foreach (var emp in filteredEmployees)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId)
                {
                    ImageKey = "emp"
                };
                item.SubItems.Add(emp.FullName);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy"));

                lsvEmployees.Items.Add(item);
            }
        }

        private List<string> GetGroupCodesFromNode(TreeNode node)
        {
            List<string> codes = new List<string>();

            if (node.Tag != null)
            {
                string tag = node.Tag.ToString() ?? "";
                if (!tag.StartsWith("ROOT") && !tag.StartsWith("DEPT_"))
                {
                    codes.Add(tag);
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                codes.AddRange(GetGroupCodesFromNode(child));
            }

            return codes;
        }

        private void CboViewMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboViewMode.SelectedItem != null)
            {
                string selectedMode = cboViewMode.SelectedItem.ToString() ?? "Details";
                switch (selectedMode)
                {
                    case "LargeIcon":
                        lsvEmployees.View = View.LargeIcon;
                        break;
                    case "SmallIcon":
                        lsvEmployees.View = View.SmallIcon;
                        break;
                    case "List":
                        lsvEmployees.View = View.List;
                        break;
                    case "Tile":
                        lsvEmployees.View = View.Tile;
                        break;
                    default:
                        lsvEmployees.View = View.Details;
                        break;
                }
            }
        }
    }
}