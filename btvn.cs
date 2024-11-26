using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn
{
    public partial class btvn : Form
    {
        public btvn()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ListViewItem liv = new ListViewItem(txt_lastname.Text);
            listView1.Items.Add(liv);
            liv.SubItems.Add(txt_firstname.Text);
            liv.SubItems.Add(txt_phone.Text);

        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {



            
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Ban co muon xoa du lieu", "Canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else MessageBox.Show("Loi xoa du lieu");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = txt_lastname.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txt_firstname.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txt_phone.Text;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >0)
            {
                txt_lastname.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txt_firstname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txt_phone.Text = listView1.SelectedItems[0].SubItems[2].Text; 
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
