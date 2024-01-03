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
            components = new System.ComponentModel.Container();
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
            errorProviderCheckCountry = new ErrorProvider(components);
            errorProviderDuplicateCountry = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderCheckCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDuplicateCountry).BeginInit();
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
            comboBoxCountriesList.AllowDrop = true;
            comboBoxCountriesList.FormattingEnabled = true;
            comboBoxCountriesList.Location = new Point(50, 58);
            comboBoxCountriesList.Name = "comboBoxCountriesList";
            comboBoxCountriesList.Size = new Size(121, 23);
            comboBoxCountriesList.TabIndex = 10;
            comboBoxCountriesList.DropDown += comboBoxCountriesList_DropDown;
            comboBoxCountriesList.SelectedIndexChanged += comboBoxCountriesList_SelectedIndexChanged;
            comboBoxCountriesList.TextChanged += comboBoxCountriesList_TextChanged;
            // 
            // buttonAddAnItem
            // 
            buttonAddAnItem.Location = new Point(224, 58);
            buttonAddAnItem.Name = "buttonAddAnItem";
            buttonAddAnItem.Size = new Size(83, 23);
            buttonAddAnItem.TabIndex = 2;
            buttonAddAnItem.Text = ">";
            buttonAddAnItem.UseVisualStyleBackColor = true;
            buttonAddAnItem.Click += buttonAddAnItem_Click;
            // 
            // buttonAddAllItems
            // 
            buttonAddAllItems.Location = new Point(224, 101);
            buttonAddAllItems.Name = "buttonAddAllItems";
            buttonAddAllItems.Size = new Size(83, 23);
            buttonAddAllItems.TabIndex = 3;
            buttonAddAllItems.Text = ">>";
            buttonAddAllItems.UseVisualStyleBackColor = true;
            buttonAddAllItems.Click += buttonAddAllItems_Click;
            // 
            // listBoxTarget
            // 
            listBoxTarget.FormattingEnabled = true;
            listBoxTarget.ItemHeight = 15;
            listBoxTarget.Location = new Point(377, 58);
            listBoxTarget.Name = "listBoxTarget";
            listBoxTarget.Size = new Size(160, 169);
            listBoxTarget.TabIndex = 4;
            listBoxTarget.SelectedIndexChanged += listBoxTarget_SelectedIndexChanged;
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
            buttonRemoveAnItem.Text = "<";
            buttonRemoveAnItem.UseVisualStyleBackColor = true;
            buttonRemoveAnItem.Click += buttonRemoveAnItem_Click;
            // 
            // buttonRemoveAllItems
            // 
            buttonRemoveAllItems.Location = new Point(224, 204);
            buttonRemoveAllItems.Name = "buttonRemoveAllItems";
            buttonRemoveAllItems.Size = new Size(83, 23);
            buttonRemoveAllItems.TabIndex = 7;
            buttonRemoveAllItems.Text = "<<";
            buttonRemoveAllItems.UseVisualStyleBackColor = true;
            buttonRemoveAllItems.Click += buttonRemoveAllItems_Click;
            // 
            // buttonUpArrow
            // 
            buttonUpArrow.Location = new Point(407, 247);
            buttonUpArrow.Name = "buttonUpArrow";
            buttonUpArrow.Size = new Size(34, 50);
            buttonUpArrow.TabIndex = 8;
            buttonUpArrow.Text = "↑";
            buttonUpArrow.UseVisualStyleBackColor = true;
            buttonUpArrow.Click += buttonUpArrow_Click;
            // 
            // buttonDownArrow
            // 
            buttonDownArrow.Location = new Point(458, 247);
            buttonDownArrow.Name = "buttonDownArrow";
            buttonDownArrow.Size = new Size(34, 50);
            buttonDownArrow.TabIndex = 9;
            buttonDownArrow.Text = "↓";
            buttonDownArrow.UseVisualStyleBackColor = true;
            buttonDownArrow.Click += buttonDownArrow_Click;
            // 
            // errorProviderCheckCountry
            // 
            errorProviderCheckCountry.ContainerControl = this;
            // 
            // errorProviderDuplicateCountry
            // 
            errorProviderDuplicateCountry.ContainerControl = this;
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
            FormClosing += FormCountriesList_FormClosing;
            Load += FormCountriesList_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderCheckCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDuplicateCountry).EndInit();
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
        private ErrorProvider errorProviderCheckCountry;
        private ErrorProvider errorProviderDuplicateCountry;
    }
}