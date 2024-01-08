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
            components = new System.ComponentModel.Container();
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
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(67, 112);
            labelNom.Margin = new Padding(4, 0, 4, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(52, 25);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(260, 98);
            textBoxNom.Margin = new Padding(4, 5, 4, 5);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(141, 31);
            textBoxNom.TabIndex = 1;
            textBoxNom.Leave += textBoxNom_Leave;
            // 
            // labelprenom
            // 
            labelprenom.AutoSize = true;
            labelprenom.Location = new Point(67, 200);
            labelprenom.Margin = new Padding(4, 0, 4, 0);
            labelprenom.Name = "labelprenom";
            labelprenom.Size = new Size(74, 25);
            labelprenom.TabIndex = 2;
            labelprenom.Text = "Prénom";
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(260, 187);
            textBoxPrenom.Margin = new Padding(4, 5, 4, 5);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(141, 31);
            textBoxPrenom.TabIndex = 3;
            textBoxPrenom.Leave += textBoxPrenom_Leave;
            // 
            // labelDateDeNaissance
            // 
            labelDateDeNaissance.AutoSize = true;
            labelDateDeNaissance.Location = new Point(67, 290);
            labelDateDeNaissance.Margin = new Padding(4, 0, 4, 0);
            labelDateDeNaissance.Name = "labelDateDeNaissance";
            labelDateDeNaissance.Size = new Size(154, 25);
            labelDateDeNaissance.TabIndex = 4;
            labelDateDeNaissance.Text = "Date de naissance";
            // 
            // textBoxDateDeNaissance
            // 
            textBoxDateDeNaissance.Location = new Point(260, 277);
            textBoxDateDeNaissance.Margin = new Padding(4, 5, 4, 5);
            textBoxDateDeNaissance.Name = "textBoxDateDeNaissance";
            textBoxDateDeNaissance.Size = new Size(141, 31);
            textBoxDateDeNaissance.TabIndex = 5;
            textBoxDateDeNaissance.Leave += textBoxDateDeNaissance_Leave;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(67, 375);
            labelAdresse.Margin = new Padding(4, 0, 4, 0);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(129, 25);
            labelAdresse.TabIndex = 6;
            labelAdresse.Text = "Adresse postal";
            // 
            // textBoxAdressePostal
            // 
            textBoxAdressePostal.Location = new Point(260, 362);
            textBoxAdressePostal.Margin = new Padding(4, 5, 4, 5);
            textBoxAdressePostal.Name = "textBoxAdressePostal";
            textBoxAdressePostal.Size = new Size(141, 31);
            textBoxAdressePostal.TabIndex = 7;
            // 
            // labelCodePostal
            // 
            labelCodePostal.AutoSize = true;
            labelCodePostal.Location = new Point(67, 530);
            labelCodePostal.Margin = new Padding(4, 0, 4, 0);
            labelCodePostal.Name = "labelCodePostal";
            labelCodePostal.Size = new Size(108, 25);
            labelCodePostal.TabIndex = 8;
            labelCodePostal.Text = "Code postal";
            // 
            // textBoxCodePostal
            // 
            textBoxCodePostal.Location = new Point(260, 517);
            textBoxCodePostal.Margin = new Padding(4, 5, 4, 5);
            textBoxCodePostal.Name = "textBoxCodePostal";
            textBoxCodePostal.Size = new Size(141, 31);
            textBoxCodePostal.TabIndex = 9;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(67, 608);
            labelTel.Margin = new Padding(4, 0, 4, 0);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(92, 25);
            labelTel.TabIndex = 10;
            labelTel.Text = "Téléphone";
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(260, 595);
            textBoxTel.Margin = new Padding(4, 5, 4, 5);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(141, 31);
            textBoxTel.TabIndex = 11;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(853, 530);
            buttonValider.Margin = new Padding(4, 5, 4, 5);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(107, 38);
            buttonValider.TabIndex = 12;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(853, 608);
            buttonEffacer.Margin = new Padding(4, 5, 4, 5);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(107, 38);
            buttonEffacer.TabIndex = 13;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // labelFormatDate
            // 
            labelFormatDate.AutoSize = true;
            labelFormatDate.Location = new Point(441, 277);
            labelFormatDate.Margin = new Padding(4, 0, 4, 0);
            labelFormatDate.Name = "labelFormatDate";
            labelFormatDate.Size = new Size(127, 25);
            labelFormatDate.TabIndex = 14;
            labelFormatDate.Text = "(JJ/MM/AAAA)";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(67, 455);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(260, 442);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(141, 31);
            textBoxEmail.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 693);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
    }
}