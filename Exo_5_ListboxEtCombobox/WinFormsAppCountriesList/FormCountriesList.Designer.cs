namespace WinFormsAppCountriesList
{
    partial class FormCountriesList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountriesList));
            labelSource = new Label();
            comboBoxCountriesList = new ComboBox();
            buttonAddAnItem = new Button();
            buttonAddAllItems = new Button();
            listBoxTarget = new ListBox();
            labelTarget = new Label();
            buttonRemoveAnItem = new Button();
            buttonRemoveAllItems = new Button();
            buttonUpArrow = new Button();
            buttonDownArrow = new Button();
            SuspendLayout();
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(80, 31);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(43, 15);
            labelSource.TabIndex = 0;
            labelSource.Text = "Source";
            // 
            // comboBoxCountriesList
            // 
            comboBoxCountriesList.FormattingEnabled = true;
            comboBoxCountriesList.Location = new Point(50, 58);
            comboBoxCountriesList.Name = "comboBoxCountriesList";
            comboBoxCountriesList.Size = new Size(121, 23);
            comboBoxCountriesList.TabIndex = 1;
            // 
            // buttonAddAnItem
            // 
            buttonAddAnItem.Location = new Point(224, 58);
            buttonAddAnItem.Name = "buttonAddAnItem";
            buttonAddAnItem.Size = new Size(83, 23);
            buttonAddAnItem.TabIndex = 2;
            buttonAddAnItem.Text = ">";
            buttonAddAnItem.UseVisualStyleBackColor = true;
            // 
            // buttonAddAllItems
            // 
            buttonAddAllItems.Image = (Image)resources.GetObject("buttonAddAllItems.Image");
            buttonAddAllItems.Location = new Point(224, 101);
            buttonAddAllItems.Name = "buttonAddAllItems";
            buttonAddAllItems.Size = new Size(83, 34);
            buttonAddAllItems.TabIndex = 3;
            buttonAddAllItems.UseVisualStyleBackColor = true;
            // 
            // listBoxTarget
            // 
            listBoxTarget.FormattingEnabled = true;
            listBoxTarget.ItemHeight = 15;
            listBoxTarget.Location = new Point(377, 58);
            listBoxTarget.Name = "listBoxTarget";
            listBoxTarget.Size = new Size(160, 169);
            listBoxTarget.TabIndex = 4;
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.Location = new Point(416, 31);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(34, 15);
            labelTarget.TabIndex = 5;
            labelTarget.Text = "Cible";
            // 
            // buttonRemoveAnItem
            // 
            buttonRemoveAnItem.Location = new Point(224, 163);
            buttonRemoveAnItem.Name = "buttonRemoveAnItem";
            buttonRemoveAnItem.Size = new Size(83, 23);
            buttonRemoveAnItem.TabIndex = 6;
            buttonRemoveAnItem.Text = ">";
            buttonRemoveAnItem.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveAllItems
            // 
            buttonRemoveAllItems.Location = new Point(224, 204);
            buttonRemoveAllItems.Name = "buttonRemoveAllItems";
            buttonRemoveAllItems.Size = new Size(83, 23);
            buttonRemoveAllItems.TabIndex = 7;
            buttonRemoveAllItems.Text = ">";
            buttonRemoveAllItems.UseVisualStyleBackColor = true;
            // 
            // buttonUpArrow
            // 
            buttonUpArrow.Image = (Image)resources.GetObject("buttonUpArrow.Image");
            buttonUpArrow.Location = new Point(407, 247);
            buttonUpArrow.Name = "buttonUpArrow";
            buttonUpArrow.Size = new Size(34, 77);
            buttonUpArrow.TabIndex = 8;
            buttonUpArrow.UseVisualStyleBackColor = true;
            // 
            // buttonDownArrow
            // 
            buttonDownArrow.Image = (Image)resources.GetObject("buttonDownArrow.Image");
            buttonDownArrow.Location = new Point(472, 247);
            buttonDownArrow.Name = "buttonDownArrow";
            buttonDownArrow.Size = new Size(34, 77);
            buttonDownArrow.TabIndex = 9;
            buttonDownArrow.UseVisualStyleBackColor = true;
            // 
            // FormCountriesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDownArrow);
            Controls.Add(buttonUpArrow);
            Controls.Add(buttonRemoveAllItems);
            Controls.Add(buttonRemoveAnItem);
            Controls.Add(labelTarget);
            Controls.Add(listBoxTarget);
            Controls.Add(buttonAddAllItems);
            Controls.Add(buttonAddAnItem);
            Controls.Add(comboBoxCountriesList);
            Controls.Add(labelSource);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormCountriesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les listes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSource;
        private ComboBox comboBoxCountriesList;
        private Button buttonAddAnItem;
        private Button buttonAddAllItems;
        private ListBox listBoxTarget;
        private Label labelTarget;
        private Button buttonRemoveAnItem;
        private Button buttonRemoveAllItems;
        private Button buttonUpArrow;
        private Button buttonDownArrow;
    }
}