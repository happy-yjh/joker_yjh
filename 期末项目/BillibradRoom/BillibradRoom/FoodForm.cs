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
using System.Data.SqlClient;

namespace BillibradRoom
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }
        private void FoodForm_Load(object sender, EventArgs e)
        {
            dgvFood.DataSource = FoodManager.GetFoods();
            Clear();
        }

        private void dgvFood_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                if (dgvFood.SelectedRows.Count == 0)
                {
                    return;
                }
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0)
                    {
                        //若行已是选中状态就不再进行设置
                        if (dgvFood.Rows[e.RowIndex].Selected == false)
                        {
                            dgvFood.ClearSelection();
                            dgvFood.Rows[e.RowIndex].Selected = true;
                        }
                        contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                    }
                }          
        }

        private void Clear()
        {
            txtFoodName.ReadOnly = true;
            txtFoodNum.ReadOnly = true;
            txtFoodPrice.ReadOnly = true;
            txtSellNum.ReadOnly = true;
            txtSellPrice.ReadOnly = true;
            btnOk.Enabled = false;
        }
    }
}
