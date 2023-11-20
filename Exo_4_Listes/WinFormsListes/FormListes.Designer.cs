namespace WinFormsListes
{
    partial class FormLists
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
            LabelNewElement = new Label();
            textBoxAddNewElement = new TextBox();
            buttonAddNewElement = new Button();
            labelDisplayList = new Label();
            labelIndexElement = new Label();
            textBoxIndexElement = new TextBox();
            buttonSelectIndex = new Button();
            buttonEmptyList = new Button();
            labelProperties = new Label();
            labelItemsCount = new Label();
            textBoxItemsCount = new TextBox();
            labelSelectedIndex = new Label();
            textBoxSelectedIndex = new TextBox();
            labelText = new Label();
            textBoxText = new TextBox();
            listBoxDisplayList = new ListBox();
            SuspendLayout();
            // 
            // LabelNewElement
            // 
            LabelNewElement.AutoSize = true;
            LabelNewElement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNewElement.Location = new Point(43, 26);
            LabelNewElement.Name = "LabelNewElement";
            LabelNewElement.Size = new Size(133, 21);
            LabelNewElement.TabIndex = 0;
            LabelNewElement.Text = "Nouvel Elément";
            // 
            // textBoxAddNewElement
            // 
            textBoxAddNewElement.Location = new Point(43, 60);
            textBoxAddNewElement.Name = "textBoxAddNewElement";
            textBoxAddNewElement.Size = new Size(177, 23);
            textBoxAddNewElement.TabIndex = 1;
            // 
            // buttonAddNewElement
            // 
            buttonAddNewElement.Location = new Point(43, 104);
            buttonAddNewElement.Name = "buttonAddNewElement";
            buttonAddNewElement.Size = new Size(177, 32);
            buttonAddNewElement.TabIndex = 2;
            buttonAddNewElement.Text = "Ajout liste";
            buttonAddNewElement.UseVisualStyleBackColor = true;
            buttonAddNewElement.Click += buttonAddNewElement_Click;
            // 
            // labelDisplayList
            // 
            labelDisplayList.AutoSize = true;
            labelDisplayList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDisplayList.Location = new Point(43, 153);
            labelDisplayList.Name = "labelDisplayList";
            labelDisplayList.Size = new Size(66, 21);
            labelDisplayList.TabIndex = 3;
            labelDisplayList.Text = "LstListe";
            // 
            // labelIndexElement
            // 
            labelIndexElement.AutoSize = true;
            labelIndexElement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIndexElement.Location = new Point(441, 26);
            labelIndexElement.Name = "labelIndexElement";
            labelIndexElement.Size = new Size(120, 21);
            labelIndexElement.TabIndex = 5;
            labelIndexElement.Text = "Index Elément";
            // 
            // textBoxIndexElement
            // 
            textBoxIndexElement.Location = new Point(441, 61);
            textBoxIndexElement.Name = "textBoxIndexElement";
            textBoxIndexElement.Size = new Size(66, 23);
            textBoxIndexElement.TabIndex = 6;
            // 
            // buttonSelectIndex
            // 
            buttonSelectIndex.Location = new Point(557, 60);
            buttonSelectIndex.Name = "buttonSelectIndex";
            buttonSelectIndex.Size = new Size(202, 23);
            buttonSelectIndex.TabIndex = 7;
            buttonSelectIndex.Text = "Sélectionner";
            buttonSelectIndex.UseVisualStyleBackColor = true;
            // 
            // buttonEmptyList
            // 
            buttonEmptyList.Location = new Point(557, 104);
            buttonEmptyList.Name = "buttonEmptyList";
            buttonEmptyList.Size = new Size(202, 23);
            buttonEmptyList.TabIndex = 8;
            buttonEmptyList.Text = "Vider la liste";
            buttonEmptyList.UseVisualStyleBackColor = true;
            // 
            // labelProperties
            // 
            labelProperties.AutoSize = true;
            labelProperties.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProperties.Location = new Point(441, 153);
            labelProperties.Name = "labelProperties";
            labelProperties.Size = new Size(88, 21);
            labelProperties.TabIndex = 9;
            labelProperties.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            labelItemsCount.AutoSize = true;
            labelItemsCount.Location = new Point(441, 202);
            labelItemsCount.Name = "labelItemsCount";
            labelItemsCount.Size = new Size(69, 15);
            labelItemsCount.TabIndex = 10;
            labelItemsCount.Text = "ItemsCount";
            // 
            // textBoxItemsCount
            // 
            textBoxItemsCount.Location = new Point(582, 194);
            textBoxItemsCount.Name = "textBoxItemsCount";
            textBoxItemsCount.Size = new Size(42, 23);
            textBoxItemsCount.TabIndex = 11;
            // 
            // labelSelectedIndex
            // 
            labelSelectedIndex.AutoSize = true;
            labelSelectedIndex.Location = new Point(441, 244);
            labelSelectedIndex.Name = "labelSelectedIndex";
            labelSelectedIndex.Size = new Size(80, 15);
            labelSelectedIndex.TabIndex = 12;
            labelSelectedIndex.Text = "SelectedIndex";
            // 
            // textBoxSelectedIndex
            // 
            textBoxSelectedIndex.Location = new Point(582, 238);
            textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            textBoxSelectedIndex.Size = new Size(42, 23);
            textBoxSelectedIndex.TabIndex = 13;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(441, 285);
            labelText.Name = "labelText";
            labelText.Size = new Size(28, 15);
            labelText.TabIndex = 14;
            labelText.Text = "Text";
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(582, 277);
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(42, 23);
            textBoxText.TabIndex = 15;
            // 
            // listBoxDisplayList
            // 
            listBoxDisplayList.FormattingEnabled = true;
            listBoxDisplayList.ItemHeight = 15;
            listBoxDisplayList.Location = new Point(43, 187);
            listBoxDisplayList.Name = "listBoxDisplayList";
            listBoxDisplayList.Size = new Size(195, 214);
            listBoxDisplayList.TabIndex = 16;
            listBoxDisplayList.SelectedIndexChanged += listBoxDisplayList_SelectedIndexChanged;
            // 
            // FormLists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxDisplayList);
            Controls.Add(textBoxText);
            Controls.Add(labelText);
            Controls.Add(textBoxSelectedIndex);
            Controls.Add(labelSelectedIndex);
            Controls.Add(textBoxItemsCount);
            Controls.Add(labelItemsCount);
            Controls.Add(labelProperties);
            Controls.Add(buttonEmptyList);
            Controls.Add(buttonSelectIndex);
            Controls.Add(textBoxIndexElement);
            Controls.Add(labelIndexElement);
            Controls.Add(labelDisplayList);
            Controls.Add(buttonAddNewElement);
            Controls.Add(textBoxAddNewElement);
            Controls.Add(LabelNewElement);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les listes et leurs propriétés";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNewElement;
        private TextBox textBoxAddNewElement;
        private Button buttonAddNewElement;
        private Label labelDisplayList;
        private Label labelIndexElement;
        private TextBox textBoxIndexElement;
        private Button buttonSelectIndex;
        private Button buttonEmptyList;
        private Label labelProperties;
        private Label labelItemsCount;
        private TextBox textBoxItemsCount;
        private Label labelSelectedIndex;
        private TextBox textBoxSelectedIndex;
        private Label labelText;
        private TextBox textBoxText;
        private ListBox listBoxDisplayList;
    }
}