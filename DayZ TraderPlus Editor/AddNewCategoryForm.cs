using DayZ_TraderPlus_Editor.Models;
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
    public partial class AddNewCategoryForm : Form
    {

        public CategoryView CategoryView { get; set; }

        public AddNewCategoryForm(CategoryView categoryViewInstance)
        {
            InitializeComponent();
            CategoryView = categoryViewInstance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryView.OnNewCategoryAdded(CategoryNameInput.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
