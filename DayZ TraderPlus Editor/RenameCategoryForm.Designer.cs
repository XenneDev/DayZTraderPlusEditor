namespace DayZ_TraderPlus_Editor
{
    partial class RenameCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameCategoryForm));
            this.closeRenameCategoryForm = new System.Windows.Forms.Button();
            this.confirmCategoryRename = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.oldCategoryMessage = new System.Windows.Forms.Label();
            this.CategoryNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeRenameCategoryForm
            // 
            resources.ApplyResources(this.closeRenameCategoryForm, "closeRenameCategoryForm");
            this.closeRenameCategoryForm.Name = "closeRenameCategoryForm";
            this.closeRenameCategoryForm.UseVisualStyleBackColor = true;
            this.closeRenameCategoryForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // confirmCategoryRename
            // 
            resources.ApplyResources(this.confirmCategoryRename, "confirmCategoryRename");
            this.confirmCategoryRename.Name = "confirmCategoryRename";
            this.confirmCategoryRename.UseVisualStyleBackColor = true;
            this.confirmCategoryRename.Click += new System.EventHandler(this.confirmCategoryRename_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // oldCategoryMessage
            // 
            resources.ApplyResources(this.oldCategoryMessage, "oldCategoryMessage");
            this.oldCategoryMessage.Name = "oldCategoryMessage";
            // 
            // CategoryNameInput
            // 
            resources.ApplyResources(this.CategoryNameInput, "CategoryNameInput");
            this.CategoryNameInput.Name = "CategoryNameInput";
            // 
            // RenameCategoryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeRenameCategoryForm);
            this.Controls.Add(this.confirmCategoryRename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldCategoryMessage);
            this.Controls.Add(this.CategoryNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RenameCategoryForm";
            this.Load += new System.EventHandler(this.RenameCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeRenameCategoryForm;
        private System.Windows.Forms.Button confirmCategoryRename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label oldCategoryMessage;
        private System.Windows.Forms.TextBox CategoryNameInput;
    }
}