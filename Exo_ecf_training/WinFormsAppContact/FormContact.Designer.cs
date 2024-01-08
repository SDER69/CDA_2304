namespace WinFormsAppContact
{
    partial class FormContact
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
            labelNom = new Label();
            textBoxNom = new TextBox();
            labelprenom = new Label();
            textBoxPrenom = new TextBox();
            labelDateDeNaissance = new Label();
            textBoxDateDeNaissance = new TextBox();
            labelAdresse = new Label();
            textBoxAdressePostal = new TextBox();
            labelCodePostal = new Label();
            textBoxCodePostal = new TextBox();
            labelTel = new Label();
            textBoxTel = new TextBox();
            buttonValider = new Button();
            buttonEffacer = new Button();
            labelFormatDate = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(47, 67);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(182, 59);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 1;
            // 
            // labelprenom
            // 
            labelprenom.AutoSize = true;
            labelprenom.Location = new Point(47, 120);
            labelprenom.Name = "labelprenom";
            labelprenom.Size = new Size(49, 15);
            labelprenom.TabIndex = 2;
            labelprenom.Text = "Prénom";
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(182, 112);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(100, 23);
            textBoxPrenom.TabIndex = 3;
            // 
            // labelDateDeNaissance
            // 
            labelDateDeNaissance.AutoSize = true;
            labelDateDeNaissance.Location = new Point(47, 174);
            labelDateDeNaissance.Name = "labelDateDeNaissance";
            labelDateDeNaissance.Size = new Size(101, 15);
            labelDateDeNaissance.TabIndex = 4;
            labelDateDeNaissance.Text = "Date de naissance";
            // 
            // textBoxDateDeNaissance
            // 
            textBoxDateDeNaissance.Location = new Point(182, 166);
            textBoxDateDeNaissance.Name = "textBoxDateDeNaissance";
            textBoxDateDeNaissance.Size = new Size(100, 23);
            textBoxDateDeNaissance.TabIndex = 5;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(47, 225);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(83, 15);
            labelAdresse.TabIndex = 6;
            labelAdresse.Text = "Adresse postal";
            // 
            // textBoxAdressePostal
            // 
            textBoxAdressePostal.Location = new Point(182, 217);
            textBoxAdressePostal.Name = "textBoxAdressePostal";
            textBoxAdressePostal.Size = new Size(100, 23);
            textBoxAdressePostal.TabIndex = 7;
            // 
            // labelCodePostal
            // 
            labelCodePostal.AutoSize = true;
            labelCodePostal.Location = new Point(47, 318);
            labelCodePostal.Name = "labelCodePostal";
            labelCodePostal.Size = new Size(70, 15);
            labelCodePostal.TabIndex = 8;
            labelCodePostal.Text = "Code postal";
            // 
            // textBoxCodePostal
            // 
            textBoxCodePostal.Location = new Point(182, 310);
            textBoxCodePostal.Name = "textBoxCodePostal";
            textBoxCodePostal.Size = new Size(100, 23);
            textBoxCodePostal.TabIndex = 9;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(47, 365);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(61, 15);
            labelTel.TabIndex = 10;
            labelTel.Text = "Téléphone";
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(182, 357);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(100, 23);
            textBoxTel.TabIndex = 11;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(597, 318);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 12;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(597, 365);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 13;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // labelFormatDate
            // 
            labelFormatDate.AutoSize = true;
            labelFormatDate.Location = new Point(309, 166);
            labelFormatDate.Name = "labelFormatDate";
            labelFormatDate.Size = new Size(87, 15);
            labelFormatDate.TabIndex = 14;
            labelFormatDate.Text = "(JJ/MM/AAAA)";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(47, 273);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(182, 265);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 16;
            // 
            // FormContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 416);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelFormatDate);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonValider);
            Controls.Add(textBoxTel);
            Controls.Add(labelTel);
            Controls.Add(textBoxCodePostal);
            Controls.Add(labelCodePostal);
            Controls.Add(textBoxAdressePostal);
            Controls.Add(labelAdresse);
            Controls.Add(textBoxDateDeNaissance);
            Controls.Add(labelDateDeNaissance);
            Controls.Add(textBoxPrenom);
            Controls.Add(labelprenom);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox textBoxNom;
        private Label labelprenom;
        private TextBox textBoxPrenom;
        private Label labelDateDeNaissance;
        private TextBox textBoxDateDeNaissance;
        private Label labelAdresse;
        private TextBox textBoxAdressePostal;
        private Label labelCodePostal;
        private TextBox textBoxCodePostal;
        private Label labelTel;
        private TextBox textBoxTel;
        private Button buttonValider;
        private Button buttonEffacer;
        private Label labelFormatDate;
        private Label labelEmail;
        private TextBox textBoxEmail;
    }
}