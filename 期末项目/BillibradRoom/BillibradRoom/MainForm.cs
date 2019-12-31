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
    public partial class MainForm : Form
    {
        DiskManager diskManager = new DiskManager();
        DiskPayForm diskForm = new DiskPayForm();
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

            diskForm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            diskForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Disks> diskList = diskManager.GetDiskListByDisk();
            lvDisks.Items.Clear();//清空所有项
            foreach(Disks disk in diskList)
            {
                ListViewItem item = new ListViewItem();
                if (disk.DiskStateID == 1)
                {
                    item.ImageIndex = 0;
                }else if (disk.DiskStateID == 2)
                {
                    item.ImageIndex = 1;
                }
                item.Tag = disk;
                lvDisks.Items.Add(item);
            }
        }

        private void lvDisks_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            Disks disk = (Disks)e.Item.Tag;//获取鼠标悬停时的list view项(台球桌）
            string State = "";
            if (disk.DiskStateID == 1)
            {
                State = "营业";
            }else if (disk.DiskStateID == 2)
            {
                State = "空闲";
            }
            ToolTip toolTip = new ToolTip();//构建文本提示对象
            string tip = string.Format("球桌状态：{0}\r\n球桌描述：{1}", State, disk.Description);
            toolTip.SetToolTip((e.Item).ListView, tip);
        }

        private void lvDisks_DoubleClick(object sender, EventArgs e)
        {
            if (lvDisks.SelectedItems.Count == 0)//没有点到台上
            {
                return;
            }
            ListViewItem item = lvDisks.SelectedItems[0];
            Disks disk = (Disks)item.Tag;
            if (disk.DiskStateID != 2)
            {
                MessageBox.Show("该球桌已开台");
                return;
            }
            else
            {
                diskForm.ShowDialog();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm();
            memberForm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DiskFrm diskFrm = new DiskFrm();
            diskFrm.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (lvDisks.SelectedItems.Count == 0)//没有点到球桌
            {
                MessageBox.Show("请选择要删除的球桌");
                return;
            }else if (lvDisks.SelectedItems.Count != 0)
            {
                //删除球桌

                    DialogResult dialogResult = MessageBox.Show("是否删除球桌？" , "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                         Disks disks= (Disks) lvDisks.SelectedItems[0].Tag;
                        int diskID = disks.DiskID;
                        diskManager.Delete(diskID);
                        List<Disks> diskList = diskManager.GetDiskListByDisk();
                        lvDisks.Items.Clear();//清空所有项
                        foreach (Disks disk in diskList)
                        {
                            ListViewItem item = new ListViewItem();
                            if (disk.DiskStateID == 1)
                            {
                                item.ImageIndex = 0;
                            }
                            else if (disk.DiskStateID == 2)
                            {
                                item.ImageIndex = 1;
                            }
                            item.Tag = disk;
                            lvDisks.Items.Add(item);
                        }
                    }
                
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            List<Disks> diskList = diskManager.GetDiskListByDisk();
            lvDisks.Items.Clear();//清空所有项
            foreach (Disks disk in diskList)
            {
                ListViewItem item = new ListViewItem();
                if (disk.DiskStateID == 1)
                {
                    item.ImageIndex = 0;
                }
                else if (disk.DiskStateID == 2)
                {
                    item.ImageIndex = 1;
                }
                item.Tag = disk;
                lvDisks.Items.Add(item);
            }
        }
    }
}
