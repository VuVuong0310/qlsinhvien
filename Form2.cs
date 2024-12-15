using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_4
{
    public partial class Form2 : Form
    {
        public Nhanvien NhanVienMoi { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Nhanvien nhanVien)
        {
            InitializeComponent();

            txtMa.Text = nhanVien.MSNV;
            txtTen.Text = nhanVien.TenNV;
            txtLuong.Text = nhanVien.LuongCB.ToString();

            NhanVienMoi = nhanVien;
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
                   string.IsNullOrWhiteSpace(txtTen.Text) ||
                   string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtLuong.Text, out double luongCB))
            {
                MessageBox.Show("Lương cơ bản phải là số.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVienMoi = new Nhanvien
            {
                MSNV = txtMa.Text.Trim(),
                TenNV = txtTen.Text.Trim(),
                LuongCB = luongCB
            };

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
