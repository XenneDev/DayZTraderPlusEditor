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
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void newTraderConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.TraderConfig = new TraderConfigRoot();
            Global.TraderConfig.Version = "2.5";
            Global.TraderConfig.EnableDefaultTraderStock = 1;
            Global.TraderConfig.EnableAutoCalculation = 1;
            Global.TraderConfig.EnableAutoDestockAtRestart = 1;
            Global.TraderConfig.TraderCategories = new List<TraderCategory>();

            CategoryView categoryView = new CategoryView();
            categoryView.Name = "New Trader Config";
            categoryView.Text = "New Trader Config";
            categoryView.MdiParent = this;

            categoryView.CategoryListView.Clear();
            categoryView.Show();

        }

        private void openTraderConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "Trader Config Files (*.json)|*.json";
            openFileDialog.Title = "Open Trader Config File";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = System.IO.File.ReadAllText(openFileDialog.FileName);
                Global.TraderConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<TraderConfigRoot>(json);

                CategoryView categoryView = new CategoryView();
                categoryView.Name = openFileDialog.FileName;
                categoryView.Text = openFileDialog.FileName;

                categoryView.CategoryListView.Clear();

      

                
                // Sort categories alphabetically
                categoryView.CategoryListView.Sorting = SortOrder.Ascending;
                categoryView.CategoryListView.Sort();


                categoryView.MdiParent = this;
                categoryView.WindowState = FormWindowState.Maximized;

                categoryView.Show();

                
            }

           


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Convert TraderConfigRoot to json and use save dialog to save the file

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Trader Config Files (*.json)|*.json";
            saveFileDialog.Title = "Save Trader Config File";
            saveFileDialog.CheckPathExists = true;

    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Global.TraderConfig, formatting: Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog.FileName, json);
            }


        }
    }
}
