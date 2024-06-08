using DayZ_TraderPlus_Editor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_TraderPlus_Editor
{
    public partial class CategoryView : Form
    {
        public static CategoryView Instance { get; private set; }

        public CategoryView()
        {
            InitializeComponent();
            Instance = this;
        }

        private void OnCategoryFolderClicked(object sender, MouseEventArgs e)
        {
            // Check which item was clicked
            ListViewHitTestInfo hit = this.CategoryListView.HitTest(e.Location);

            CategoryProducts categoryProducts = new CategoryProducts();
            categoryProducts.CategoryName = hit.Item.Text;
            categoryProducts.Products = Global.TraderConfig.TraderCategories.Find(x => x.CategoryName == hit.Item.Text).Products;
            
            categoryProducts.MdiParent = MainForm.Instance;
            categoryProducts.WindowState = FormWindowState.Maximized;
            categoryProducts.Show();
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {

        }

        public void NewCategoryAdded(string categoryName)
        {
            ListViewItem item = new ListViewItem(categoryName);
            item.ImageIndex = 0;
            CategoryListView.Items.Add(item);
            Global.TraderConfig.TraderCategories.Add(new TraderCategory { CategoryName = categoryName, Products = new List<string>() });
          
           
            // Sort categories alphabetically
            CategoryListView.Sorting = SortOrder.Ascending;
            CategoryListView.Sort();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addNewCategoryForm = new AddNewCategoryForm(this);
            addNewCategoryForm.ShowDialog();
        }
    }
}
