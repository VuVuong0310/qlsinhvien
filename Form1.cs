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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Thêm dữ liệu mới vào DataGridView
                var nv = form.NhanVienMoi;
                dgvNhanvien.Rows.Add(nv.MSNV, nv.TenNV, nv.LuongCB);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.CurrentRow != null)
            {
                // Lấy dữ liệu dòng được chọn
                int index = dgvNhanvien.CurrentRow.Index;
                var nv = new Nhanvien
                {
                    MSNV = dgvNhanvien.Rows[index].Cells[0].Value.ToString(),
                    TenNV = dgvNhanvien.Rows[index].Cells[1].Value.ToString(),
                    LuongCB = Convert.ToDouble(dgvNhanvien.Rows[index].Cells[2].Value)
                };

                // Mở form Nhân viên để sửa
                var form = new Form2(nv);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật dữ liệu đã chỉnh sửa vào DataGridView
                    var nvMoi = form.NhanVienMoi;
                    dgvNhanvien.Rows[index].Cells[0].Value = nvMoi.MSNV;
                    dgvNhanvien.Rows[index].Cells[1].Value = nvMoi.TenNV;
                    dgvNhanvien.Rows[index].Cells[2].Value = nvMoi.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.CurrentRow != null)
            {
                // Xóa dòng được chọn
                dgvNhanvien.Rows.RemoveAt(dgvNhanvien.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
