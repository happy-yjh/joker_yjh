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
    public partial class DiskPayForm : Form
    {
        public DiskPayForm()
        {
            InitializeComponent();
        }

        private void DiskForm_Load(object sender, EventArgs e)
        {
            //判断是开台还是结账，根据球桌状态禁用按钮
            if (cbOn.Checked)
            {
                btnOpen.Enabled = false;
            }
            if (cbOff.Checked)
            {
                btnPay.Enabled = false;
            }
        }
    }
}
