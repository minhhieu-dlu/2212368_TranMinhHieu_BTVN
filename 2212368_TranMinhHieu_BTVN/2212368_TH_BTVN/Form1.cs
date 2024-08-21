using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212368_TranMinhHieu _BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lấy thông tin để hiển thị

            string hoTen=txtHoten.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem.ToString();
            double diemWeb=double.Parse(txtWeb.Text.Trim());
            double diemApp=double.Parse(txtApp.Text.Trim());
            string soThich = "";

            //Hiển thị thông tin
            string s = "Họ tên:" + hoTen +"\n";
            s += "Giới tinh:" + gioiTinh + "\n";
            s += "Điểm Web:" + diemWeb + "\n";
            s += "Điểm App:" + diemApp + "\n";
            s += "Sở Thích:" + soThich + "\n";



            MessageBox.Show(s);
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Button btn =new Button();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn =new Button();
            btn.Text = "Tran Minh Hieu";
            btn.AutoSize = true;

            Random rand=    new Random();
            btn.Location = new Point(rand.Next(0, pnlButton.Size.Width), rand.Next(0,pnlButton.Size.Height));
            
            pnlButton.Controls.Add(btn);
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
           /* label5.ImageIndex = 0;
            label5.ImageAlign = ContentAlignment.MiddleCenter;*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

  

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "Hieu" && textBox2.Text.ToString() == "123")
            {

                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }    
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save Success");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
