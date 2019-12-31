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
        //保证选定一整行
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
                    }
                }          
        }
        //清除状态方法
        private void Clear()
        {
            operateState = "";
            lbloperateSteate.Text = "";
            txtFoodName.Text = "";
            txtFoodNum.Text = "";
            txtFoodPrice.Text = "";
            txtSellNum.Text = "";
            txtSellPrice.Text = "";
            txtFoodName.ReadOnly = true;
            txtFoodNum.ReadOnly = true;
            txtFoodPrice.ReadOnly = true;
            txtSellNum.ReadOnly = true;
            txtSellPrice.ReadOnly = true;
        }
        //添加商品
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            operateState = "Add";
            lbloperateSteate.Text = "添加商品状态";
            txtFoodName.ReadOnly = false;
            txtFoodNum.ReadOnly = false;
            txtFoodPrice.ReadOnly = false;
            
        }
        //修改库存
        private void tsbModify_Click(object sender, EventArgs e)
        {
            operateState = "Modify";
            lbloperateSteate.Text = "库存管理状态";
            txtFoodNum.ReadOnly = false;
            txtFoodName.Text = dgvFood.CurrentRow.Cells["FoodName"].Value.ToString();
            txtFoodNum.Text = dgvFood.CurrentRow.Cells["FoodNum"].Value.ToString();
            txtFoodPrice.Text = dgvFood.CurrentRow.Cells["FoodPrice"].Value.ToString();
        }
        //售卖商品
        private void tsbSell_Click(object sender, EventArgs e)
        {
            operateState = "Sell";
            lbloperateSteate.Text = "售卖状态";
            txtSellNum.ReadOnly = false;
            txtFoodName.Text = dgvFood.CurrentRow.Cells["FoodName"].Value.ToString();
            txtFoodNum.Text = dgvFood.CurrentRow.Cells["FoodNum"].Value.ToString();
            txtFoodPrice.Text = dgvFood.CurrentRow.Cells["FoodPrice"].Value.ToString();
        }
        //删除商品
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除商品：" + dgvFood.CurrentRow.Cells["FoodName"].Value.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            string foodName = Convert.ToString(dgvFood.CurrentRow.Cells["FoodName"].Value);
            foodManager.DeleteFood(foodName);
            Clear();
            dgvFood.DataSource = foodManager.GetAllFoods();
        }
        //判断状态并执行
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
                }
                else if (count == -1)
                {
                    MessageBox.Show("已存在该商品");
                }
            }
            else if (operateState == "Modify")
            {
                foods.FoodName = Convert.ToString(dgvFood.CurrentRow.Cells["FoodName"].Value);
                int count = foodManager.UpdateFood(foods);
                if (count == 1)
                {
                    MessageBox.Show("库存管理成功");
                    Clear();
                }
            }else if(operateState == "Sell")
            {
                foods.FoodNum = int.Parse(txtFoodNum.Text.Trim()) - int.Parse(txtSellNum.Text.Trim());
                foods.FoodName = Convert.ToString(dgvFood.CurrentRow.Cells["FoodName"].Value);
                int count = foodManager.UpdateFood(foods);
                if (count == 1)
                {
                    MessageBox.Show("商品售卖完成");
                    Clear();
                }
            }
            dgvFood.DataSource = foodManager.GetAllFoods();
        }
        //清除状态
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //计算商品总价格
        private void txtSellNum_TextChanged(object sender, EventArgs e)
        {
            if (txtSellNum.Text == "")
            {
                txtSellPrice.Text = "";
            }
            else 
            {
                txtSellPrice.Text = Convert.ToString(decimal.Parse(txtFoodPrice.Text.Trim()) * decimal.Parse(txtSellNum.Text.Trim()));
            }
        }
            
    }
}
