using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_TraderPlus_Editor.Models
{
    public partial class CategoryProducts : Form
    {
        public string CategoryName { get; set; }
        public List<string> Products { get; set; }


        public CategoryProducts()
        {
            InitializeComponent();
        }

        private void CategoryProducts_Load(object sender, EventArgs e)
        {
            // Add columns to ProductsTable
            ProductsTable.Columns.Add("Classname", "Classname");
            ProductsTable.Columns.Add("Coefficient", "Coefficient");
            ProductsTable.Columns.Add("MaximumStock", "Maximum Stock");
            ProductsTable.Columns.Add("TradeQuantity", "Trade Quantity");
            ProductsTable.Columns.Add("BuyPrice", "Buy Price");
            ProductsTable.Columns.Add("SellPrice", "Sell Price");
            ProductsTable.Columns.Add("DestockCoefficient", "Destock Coefficient");

            if (Products == null || Products.Count <= 0)
            {
                Products = new List<string>();
                ProductsTable.Rows.Clear();
                AddEmptyRow();
                
            }

            foreach (string product in Products)
            {
                string[] line = product.Split(',');
                
               
                ProductsTable.Rows.Add(line[0], line[1], line[2], line[3], line[4], line[5]);
               
            }
  


        }

        void AddEmptyRow()
        {
            ProductsTable.Rows.Add("", -1, -1, 1, 100, 10);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Convert datagridview to TraderCategory
            List<string> products = new List<string>();
            
            // Stop editing the cell
            ProductsTable.EndEdit();

            foreach (DataGridViewRow row in ProductsTable.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    // Add product to list and when value of a cell is null, add a -1 as value


                    string product = row.Cells[0].Value.ToString() + "," + float.Parse(row.Cells[1].Value.ToString()) + "," + float.Parse(row.Cells[2].Value.ToString()) + "," + float.Parse(row.Cells[3].Value.ToString()) + "," + float.Parse(row.Cells[4].Value.ToString()) + "," + float.Parse(row.Cells[5].Value.ToString());
                    products.Add(product);
                }
            }

            Global.TraderConfig.TraderCategories.Find(x => x.CategoryName == CategoryName).Products = products;
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            AddEmptyRow();
        }
    }
}
