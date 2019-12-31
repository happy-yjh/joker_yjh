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
    public partial class MemberForm : Form
    {
        MemberManager memberManager = new MemberManager();
        string operateState = "";
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            dgvMember.DataSource = memberManager.GetAllMember();
            Clear();
        }

        private void dgvMember_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvMember.SelectedRows.Count == 0)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvMember.Rows[e.RowIndex].Selected == false)
                    {
                        dgvMember.ClearSelection();
                        dgvMember.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }
        private void Clear()
        {
            txtMemberName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            gbMemberOpen.Enabled = false;
            operateState = "";
            txtMemberName.Text = "";
            txtPhone.Text = "";
            txtFindName.Text = "";
            gbMemberOpen.Text = "";
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            operateState = "Add";
            gbMemberOpen.Text = "会员开卡";
            txtMemberName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            gbMemberOpen.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (operateState == "")
            {
                MessageBox.Show("请选择右侧操作状态");
                return;
            }
            Member member = new Member();
            member.MemberName = txtMemberName.Text.Trim();
            member.MemberPhone = txtPhone.Text.Trim();
            if (operateState == "Add")
            {
                int count = memberManager.Add(member);
                if (count == 1)
                {
                    MessageBox.Show("开卡成功");
                    Clear();
                }
                else if (count == -1)
                {
                    MessageBox.Show("开卡失败");
                }
            }
            else if (operateState == "Modify")
            {
                member.MemberID = Convert.ToInt32(dgvMember.CurrentRow.Cells["MemberID"].Value);
                int count = memberManager.Update(member);
                if (count == 1)
                {
                    MessageBox.Show("信息修改成功");
                    Clear();
                }               
            }
            Clear();
            dgvMember.DataSource = memberManager.GetAllMember();
        }
        private void tsbModify_Click(object sender, EventArgs e)
        {
            operateState = "Modify";
            gbMemberOpen.Text = "修改信息";
            txtMemberName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            gbMemberOpen.Enabled = true;
            txtMemberName.Text = dgvMember.CurrentRow.Cells["MemberName"].Value.ToString();
            txtPhone.Text = dgvMember.CurrentRow.Cells["MemberPhone"].Value.ToString();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除会员：" + dgvMember.CurrentRow.Cells["MemberName"].Value.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            int memberID = Convert.ToInt32(dgvMember.CurrentRow.Cells["MemberID"].Value);
            memberManager.Delete(memberID);
            Clear();
            dgvMember.DataSource = memberManager.GetAllMember();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvMember.DataSource = memberManager.GetMembersByMemberName(txtFindName.Text);
        }

        private void btnQuitFind_Click(object sender, EventArgs e)
        {
            Clear();
            dgvMember.DataSource = memberManager.GetAllMember();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
