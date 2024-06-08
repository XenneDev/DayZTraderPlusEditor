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
            LoadCategoriesFromCache();
        }

        private void LoadCategoriesFromCache()
        {

            foreach (TraderCategory category in Global.TraderConfig.TraderCategories)
            {
                CategoryListView.Items.Add(category.CategoryName.ToString(), 0);
            }
        }

        public void OnNewCategoryAdded(string categoryName)
        {
            ListViewItem item = new ListViewItem(categoryName);
            item.ImageIndex = 0;
            CategoryListView.Items.Add(item);
            Global.TraderConfig.TraderCategories.Add(new TraderCategory { CategoryName = categoryName, Products = new List<string>() });

            CategoryListView.Clear();
            LoadCategoriesFromCache();
           
            // Sort categories alphabetically
            CategoryListView.Sorting = SortOrder.Ascending;
            CategoryListView.Sort();

        }

        public void OnCategoryRenamed(string oldCategoryName, string newCategoryName, object sender)
        {
            ((Form)sender).Close();
            Global.TraderConfig.TraderCategories.Find(x => x.CategoryName == oldCategoryName).CategoryName = newCategoryName;
            CategoryListView.Clear();
            LoadCategoriesFromCache();
            CategoryListView.Sorting = SortOrder.Ascending;
            CategoryListView.Sort();

            MessageBox.Show("Category renamed successfully.");
        }




        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addNewCategoryForm = new AddNewCategoryForm(this);
            addNewCategoryForm.ShowDialog();
        }

        private void OnOneClick(object sender, MouseEventArgs e)
        {
          
            // If right click, show context menu with delete and rename. On Delete, remove category from list and remove all products from category
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hit = this.CategoryListView.HitTest(e.Location);
                if (hit.Item != null)
                {
                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                    contextMenuStrip.Items.Add("Delete Category");
                    contextMenuStrip.Items.Add("Rename Category");
                    contextMenuStrip.Show(Cursor.Position);
                    contextMenuStrip.ItemClicked += (s, ev) =>
                    {
                        if (ev.ClickedItem.Text == "Delete Category")
                        {
                            Global.TraderConfig.TraderCategories.Remove(Global.TraderConfig.TraderCategories.Find(x => x.CategoryName == hit.Item.Text));
                            CategoryListView.Items.Remove(hit.Item);
                        }
                        else if (ev.ClickedItem.Text == "Rename Category")
                        {
                            RenameCategoryForm renameCategoryForm = new RenameCategoryForm(this, hit.Item.Text);
                            renameCategoryForm.ShowDialog();
                        }
                    };
                }
            }
             
        }
    }
}
