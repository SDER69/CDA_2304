namespace WinFormsTransaction
{
    partial class FormTransaction
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
            labelNom = new Label();
            labelDate = new Label();
            labelMontant = new Label();
            labelCodePostal = new Label();
            textBoxNom = new TextBox();
            textBoxDate = new TextBox();
            textBoxMontant = new TextBox();
            textBoxCodePostal = new TextBox();
            labelFormatDate = new Label();
            btnValider = new Button();
            btnEffacer = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(38, 105);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(38, 140);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(38, 175);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(78, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant en €";
            // 
            // labelCodePostal
            // 
            labelCodePostal.AutoSize = true;
            labelCodePostal.Location = new Point(38, 209);
            labelCodePostal.Name = "labelCodePostal";
            labelCodePostal.Size = new Size(70, 15);
            labelCodePostal.TabIndex = 3;
            labelCodePostal.Text = "Code Postal";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(147, 102);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(189, 23);
            textBoxNom.TabIndex = 4;
            textBoxNom.Leave += textBoxNom_Leave;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(147, 137);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(122, 23);
            textBoxDate.TabIndex = 5;
            textBoxDate.Leave += textBoxDate_Leave;
            // 
            // textBoxMontant
            // 
            textBoxMontant.Location = new Point(147, 172);
            textBoxMontant.Name = "textBoxMontant";
            textBoxMontant.Size = new Size(122, 23);
            textBoxMontant.TabIndex = 6;
            textBoxMontant.Leave += textBoxMontant_Leave;
            // 
            // textBoxCodePostal
            // 
            textBoxCodePostal.Location = new Point(147, 201);
            textBoxCodePostal.Name = "textBoxCodePostal";
            textBoxCodePostal.Size = new Size(122, 23);
            textBoxCodePostal.TabIndex = 7;
            textBoxCodePostal.Leave += textBoxCodePostal_Leave;
            // 
            // labelFormatDate
            // 
            labelFormatDate.AutoSize = true;
            labelFormatDate.Location = new Point(287, 145);
            labelFormatDate.Name = "labelFormatDate";
            labelFormatDate.Size = new Size(87, 15);
            labelFormatDate.TabIndex = 8;
            labelFormatDate.Text = "(JJ/MM/AAAA)";
            // 
            // btnValider
            // 
            btnValider.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnValider.Location = new Point(316, 216);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 9;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEffacer.Location = new Point(316, 245);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(75, 23);
            btnEffacer.TabIndex = 10;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 331);
            Controls.Add(btnEffacer);
            Controls.Add(btnValider);
            Controls.Add(labelFormatDate);
            Controls.Add(textBoxCodePostal);
            Controls.Add(textBoxMontant);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxNom);
            Controls.Add(labelCodePostal);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction";
            FormClosing += transaction_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCodePostal;
        private TextBox textBoxNom;
        private TextBox textBoxDate;
        private TextBox textBoxMontant;
        private TextBox textBoxCodePostal;
        private Label labelFormatDate;
        private Button btnValider;
        private Button btnEffacer;
        private ErrorProvider errorProvider1;
    }
}