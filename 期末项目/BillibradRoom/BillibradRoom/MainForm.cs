using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillibradRoom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DiskForm diskForm = new DiskForm();
            diskForm.ShowDialog();
            this.pictureBox1.Image = Image.FromFile(@"D:\github\期末项目\BillibradRoom\BillibradRoom\Resources\台球桌.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DiskForm diskForm = new DiskForm();
            diskForm.ShowDialog();
            this.pictureBox2.Image= Image.FromFile(@"D:\github\期末项目\BillibradRoom\BillibradRoom\Resources\台球桌.jpg");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DiskForm diskForm = new DiskForm();
            diskForm.ShowDialog();
            this.pictureBox3.Image= Image.FromFile(@"D:\github\期末项目\BillibradRoom\BillibradRoom\Resources\台球桌.jpg");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DiskForm diskForm = new DiskForm();
            diskForm.ShowDialog();
            this.pictureBox4.Image= Image.FromFile(@"D:\github\期末项目\BillibradRoom\BillibradRoom\Resources\台球桌.jpg");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DiskForm diskForm = new DiskForm();
            diskForm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DiskForm diskForm = new DiskForm();
            diskForm.ShowDialog();
        }
    }
}
