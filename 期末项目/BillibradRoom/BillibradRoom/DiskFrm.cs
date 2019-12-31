using BillibradDLL;
using BillibradModel;
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
    public partial class DiskFrm : Form
    {
        DiskManager diskManager = new DiskManager();
        public DiskFrm()
        {
            InitializeComponent();
            cboDiskType.SelectedItem=cboDiskType.Items[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                Disks disk = new Disks();
                if (cboDiskType.Text == "中式八球")
                {
                    disk.DiskTypeID = 1;
                    
                    disk.Description = "中式八球";
                }
                else if(cboDiskType.Text=="三球"){
                    disk.DiskTypeID = 2;
                    disk.Description = "三球";
                }
                else if (cboDiskType.Text == "九球")
                {
                    disk.DiskTypeID = 3;
                    disk.Description = "九球";
                }
                else if (cboDiskType.Text == "16彩球")
                {
                    disk.DiskTypeID = 4;
                    disk.Description = "16彩球";
                }
                disk.DiskStateID = 2;


                int count = diskManager.Add(disk);
                if (count == 1)
                {
                    MessageBox.Show("球桌添加成功");
                    ;
                }
                else if (count == -1)
                {
                    MessageBox.Show("添加失败");
                }
                this.Close();
            
        }
    }
}
