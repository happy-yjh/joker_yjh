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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            /*
             * imageListDisk
             */
            this.imageListDisk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDisk.ImageStream")));
            this.imageListDisk.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDisk.Images.SetKeyName(0, "1.jpg");
            this.imageListDisk.Images.SetKeyName(1, "2.jpg");

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
