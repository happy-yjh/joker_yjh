using BillibradDLL;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Trim()=="")
            {
                MessageBox.Show("账号输入不能为空");
                txtLoginName.Focus();
            }else if (txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不可为空");
                txtLoginPwd.Focus();
            }else if (!LoginManager.CheckLogin(this.txtLoginName.Text.Trim(), this.txtLoginPwd.Text.Trim()))
            {
                MessageBox.Show("用户名或密码不存在！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
