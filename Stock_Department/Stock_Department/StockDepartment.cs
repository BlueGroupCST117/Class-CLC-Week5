using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Department
{
    public partial class StockDepartment : Form
    {
        public StockDepartment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockBox.Visible = false;
            StockInventoryBox.Visible = true;
        

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockBox.Visible = true;
            StockInventoryBox.Visible = false;
      
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockBox.Visible = false;
            StockInventoryBox.Visible = false;
         
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void StockBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockDepartmentExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void StockDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shipping_Project1DataSet.Item_Sales' table. You can move, or remove it, as needed.
        //    this.item_SalesTableAdapter1.Fill(this.shipping_Project1DataSet.Item_Sales);
            // TODO: This line of code loads data into the 'shippingProjectDataSet.Item_Sales' table. You can move, or remove it, as needed.
            this.item_SalesTableAdapter.Fill(this.shippingProjectDataSet.Item_Sales);
            DataTable Item = new DataTable();
            Item.Columns.Add("ID");
            Item.Columns.Add("Description");
            Item.Columns.Add("Quantity");
            Item.Columns.Add("Price");






            Item.Rows.Add("01", "Red Ball", "12", "2.99");
            Item.Rows.Add("01", "Green Ball", "10", "4.99");
            Item.Rows.Add("01", "Black Ball", "2", "12.99");
            Item.Rows.Add("01", "Gold Ball", "112", "1.99");
            Item.Rows.Add("01", "Hat Small", "12", "24.99");
            Item.Rows.Add("01", "Hat Large", "12", "22.99");
         



     //       private void item_SalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      //      {
       //         this.Validate();
      //          this.item_SalesBindingSource.EndEdit();
      //          this.tableAdapterManager.UpdateAll(this.shippingProjectDataSet);

      //      }
        }
    }
}