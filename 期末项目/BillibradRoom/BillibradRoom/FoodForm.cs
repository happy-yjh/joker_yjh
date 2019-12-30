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
        FoodManager foodManager = new FoodManager();
        string operateState = "";//操作状态
        public FoodForm()
        {
            InitializeComponent();
        }
        private void FoodForm_Load(object sender, EventArgs e)
        {
            dgvFood.DataSource = foodManager.GetAllFoods();
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
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            operateState = "Add";
            lbloperateSteate.Text = "添加商品状态";
            txtFoodName.ReadOnly = false;
            txtFoodNum.ReadOnly = false;
            txtFoodPrice.ReadOnly = false;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (operateState == "")
            {
                MessageBox.Show("请选择左侧操作状态");
                return;
            }
            Foods foods = new Foods();
            foods.FoodName = txtFoodName.Text.Trim();
            foods.FoodNum = Convert.ToInt32( txtFoodNum.Text.Trim());
            foods.FoodPrice = Convert.ToDecimal(txtFoodPrice.Text.Trim());
            if (operateState == "Add")
            {
                int count = foodManager.Add(foods);
                if (count == 1)
                {
                    MessageBox.Show("新增商品成功");
                    Clear();
                }else if (count == -1)
                {
                    MessageBox.Show("已存在该商品");
                }
            }
        }
    }
}
