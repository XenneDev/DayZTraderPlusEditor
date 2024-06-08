using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_TraderPlus_Editor
{
    public partial class RenameCategoryForm : Form
    {
        string oldCategoryName;
        object originSender;

        public RenameCategoryForm(object sender, string oldCategoryName)
        {
            InitializeComponent();
            this.oldCategoryName = oldCategoryName;
            this.CategoryNameInput.Text = oldCategoryName;
            this.originSender = sender;
            oldCategoryMessage.Text = $"Old Category Name: {oldCategoryName}";
        }

        public RenameCategoryForm()
        {
            InitializeComponent();
        }

        private void RenameCategoryForm_Load(object sender, EventArgs e)
        {
            if (oldCategoryName != null)
            {
                this.CategoryNameInput.Text = oldCategoryName;
             
            }
            else
            {
                MessageBox.Show(Text = "Error: No category name was provided to rename.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmCategoryRename_Click(object sender, EventArgs e)
        {
            
            CategoryView.Instance.OnCategoryRenamed(oldCategoryName, CategoryNameInput.Text, this);
            
        }
    }
}
