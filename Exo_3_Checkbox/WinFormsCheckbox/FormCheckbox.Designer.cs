namespace WinFormsCheckbox
{
    partial class FormCheckBox
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
            textBoxsaisie = new TextBox();
            labelTexte = new Label();
            groupBoxChoix = new GroupBox();
            checkBoxCasse = new CheckBox();
            checkBoxCar = new CheckBox();
            checkBoxFond = new CheckBox();
            groupBoxFond = new GroupBox();
            radioButtonBlue = new RadioButton();
            radioButtonGreen = new RadioButton();
            radioButtonRed1 = new RadioButton();
            groupBoxCaracteres = new GroupBox();
            radioButtonBlack = new RadioButton();
            radioButtonWhite = new RadioButton();
            radioButtonRed2 = new RadioButton();
            groupBoxCasse = new GroupBox();
            radioButtonMajsucules = new RadioButton();
            radioButtonMinuscules = new RadioButton();
            labelCopieTexte = new Label();
            groupBoxChoix.SuspendLayout();
            groupBoxFond.SuspendLayout();
            groupBoxCaracteres.SuspendLayout();
            groupBoxCasse.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxsaisie
            // 
            textBoxsaisie.Location = new Point(29, 55);
            textBoxsaisie.Name = "textBoxsaisie";
            textBoxsaisie.Size = new Size(394, 23);
            textBoxsaisie.TabIndex = 0;
            textBoxsaisie.TextChanged += textBox1_TextChanged;
            // 
            // labelTexte
            // 
            labelTexte.AutoSize = true;
            labelTexte.Location = new Point(29, 25);
            labelTexte.Name = "labelTexte";
            labelTexte.Size = new Size(95, 15);
            labelTexte.TabIndex = 1;
            labelTexte.Text = "Tapez votre texte";
            // 
            // groupBoxChoix
            // 
            groupBoxChoix.Controls.Add(checkBoxCasse);
            groupBoxChoix.Controls.Add(checkBoxCar);
            groupBoxChoix.Controls.Add(checkBoxFond);
            groupBoxChoix.Enabled = false;
            groupBoxChoix.Location = new Point(551, 25);
            groupBoxChoix.Name = "groupBoxChoix";
            groupBoxChoix.Size = new Size(200, 118);
            groupBoxChoix.TabIndex = 2;
            groupBoxChoix.TabStop = false;
            groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            checkBoxCasse.AutoSize = true;
            checkBoxCasse.Location = new Point(7, 74);
            checkBoxCasse.Name = "checkBoxCasse";
            checkBoxCasse.Size = new Size(56, 19);
            checkBoxCasse.TabIndex = 2;
            checkBoxCasse.Text = "Casse";
            checkBoxCasse.UseVisualStyleBackColor = true;
            checkBoxCasse.CheckedChanged += checkBoxCasse_CheckedChanged;
            // 
            // checkBoxCar
            // 
            checkBoxCar.AutoSize = true;
            checkBoxCar.Location = new Point(7, 49);
            checkBoxCar.Name = "checkBoxCar";
            checkBoxCar.Size = new Size(145, 19);
            checkBoxCar.TabIndex = 1;
            checkBoxCar.Text = "Couleur des caractères";
            checkBoxCar.UseVisualStyleBackColor = true;
            checkBoxCar.CheckedChanged += checkBoxCar_CheckedChanged;
            // 
            // checkBoxFond
            // 
            checkBoxFond.AutoSize = true;
            checkBoxFond.Location = new Point(7, 24);
            checkBoxFond.Name = "checkBoxFond";
            checkBoxFond.Size = new Size(112, 19);
            checkBoxFond.TabIndex = 0;
            checkBoxFond.Text = "Couleur de fond";
            checkBoxFond.UseVisualStyleBackColor = true;
            checkBoxFond.CheckedChanged += checkBoxFond_CheckedChanged;
            // 
            // groupBoxFond
            // 
            groupBoxFond.Controls.Add(radioButtonBlue);
            groupBoxFond.Controls.Add(radioButtonGreen);
            groupBoxFond.Controls.Add(radioButtonRed1);
            groupBoxFond.Location = new Point(62, 230);
            groupBoxFond.Name = "groupBoxFond";
            groupBoxFond.Size = new Size(122, 137);
            groupBoxFond.TabIndex = 4;
            groupBoxFond.TabStop = false;
            groupBoxFond.Text = "Fond";
            // 
            // radioButtonBlue
            // 
            radioButtonBlue.AutoSize = true;
            radioButtonBlue.Location = new Point(9, 95);
            radioButtonBlue.Name = "radioButtonBlue";
            radioButtonBlue.Size = new Size(48, 19);
            radioButtonBlue.TabIndex = 2;
            radioButtonBlue.TabStop = true;
            radioButtonBlue.Text = "Bleu";
            radioButtonBlue.UseVisualStyleBackColor = true;
            radioButtonBlue.CheckedChanged += radioButtonBlue_CheckedChanged;
            // 
            // radioButtonGreen
            // 
            radioButtonGreen.AutoSize = true;
            radioButtonGreen.Location = new Point(9, 61);
            radioButtonGreen.Name = "radioButtonGreen";
            radioButtonGreen.Size = new Size(45, 19);
            radioButtonGreen.TabIndex = 1;
            radioButtonGreen.TabStop = true;
            radioButtonGreen.Text = "Vert";
            radioButtonGreen.UseVisualStyleBackColor = true;
            radioButtonGreen.CheckedChanged += radioButtonGreen_CheckedChanged;
            // 
            // radioButtonRed1
            // 
            radioButtonRed1.AutoSize = true;
            radioButtonRed1.Location = new Point(10, 27);
            radioButtonRed1.Name = "radioButtonRed1";
            radioButtonRed1.Size = new Size(59, 19);
            radioButtonRed1.TabIndex = 0;
            radioButtonRed1.TabStop = true;
            radioButtonRed1.Text = "Rouge";
            radioButtonRed1.UseVisualStyleBackColor = true;
            radioButtonRed1.CheckedChanged += radioButtonRed1_CheckedChanged;
            // 
            // groupBoxCaracteres
            // 
            groupBoxCaracteres.Controls.Add(radioButtonBlack);
            groupBoxCaracteres.Controls.Add(radioButtonWhite);
            groupBoxCaracteres.Controls.Add(radioButtonRed2);
            groupBoxCaracteres.Location = new Point(214, 230);
            groupBoxCaracteres.Name = "groupBoxCaracteres";
            groupBoxCaracteres.Size = new Size(122, 137);
            groupBoxCaracteres.TabIndex = 5;
            groupBoxCaracteres.TabStop = false;
            groupBoxCaracteres.Text = "Caractères";
            // 
            // radioButtonBlack
            // 
            radioButtonBlack.AutoSize = true;
            radioButtonBlack.Location = new Point(9, 95);
            radioButtonBlack.Name = "radioButtonBlack";
            radioButtonBlack.Size = new Size(48, 19);
            radioButtonBlack.TabIndex = 2;
            radioButtonBlack.TabStop = true;
            radioButtonBlack.Text = "Noir";
            radioButtonBlack.UseVisualStyleBackColor = true;
            radioButtonBlack.CheckedChanged += radioButtonBlack_CheckedChanged;
            // 
            // radioButtonWhite
            // 
            radioButtonWhite.AutoSize = true;
            radioButtonWhite.Location = new Point(9, 61);
            radioButtonWhite.Name = "radioButtonWhite";
            radioButtonWhite.Size = new Size(54, 19);
            radioButtonWhite.TabIndex = 1;
            radioButtonWhite.TabStop = true;
            radioButtonWhite.Text = "Blanc";
            radioButtonWhite.UseVisualStyleBackColor = true;
            radioButtonWhite.CheckedChanged += radioButtonWhite_CheckedChanged;
            // 
            // radioButtonRed2
            // 
            radioButtonRed2.AutoSize = true;
            radioButtonRed2.Location = new Point(10, 27);
            radioButtonRed2.Name = "radioButtonRed2";
            radioButtonRed2.Size = new Size(59, 19);
            radioButtonRed2.TabIndex = 0;
            radioButtonRed2.TabStop = true;
            radioButtonRed2.Text = "Rouge";
            radioButtonRed2.UseVisualStyleBackColor = true;
            radioButtonRed2.CheckedChanged += radioButtonRed2_CheckedChanged;
            // 
            // groupBoxCasse
            // 
            groupBoxCasse.Controls.Add(radioButtonMajsucules);
            groupBoxCasse.Controls.Add(radioButtonMinuscules);
            groupBoxCasse.Location = new Point(364, 267);
            groupBoxCasse.Name = "groupBoxCasse";
            groupBoxCasse.Size = new Size(186, 100);
            groupBoxCasse.TabIndex = 6;
            groupBoxCasse.TabStop = false;
            groupBoxCasse.Text = "Casse";
            // 
            // radioButtonMajsucules
            // 
            radioButtonMajsucules.AutoSize = true;
            radioButtonMajsucules.Location = new Point(10, 58);
            radioButtonMajsucules.Name = "radioButtonMajsucules";
            radioButtonMajsucules.Size = new Size(84, 19);
            radioButtonMajsucules.TabIndex = 1;
            radioButtonMajsucules.TabStop = true;
            radioButtonMajsucules.Text = "Majuscules";
            radioButtonMajsucules.UseVisualStyleBackColor = true;
            radioButtonMajsucules.CheckedChanged += radioButtonMajsucules_CheckedChanged;
            // 
            // radioButtonMinuscules
            // 
            radioButtonMinuscules.AutoSize = true;
            radioButtonMinuscules.Location = new Point(10, 24);
            radioButtonMinuscules.Name = "radioButtonMinuscules";
            radioButtonMinuscules.Size = new Size(85, 19);
            radioButtonMinuscules.TabIndex = 0;
            radioButtonMinuscules.TabStop = true;
            radioButtonMinuscules.Text = "Minuscules";
            radioButtonMinuscules.UseVisualStyleBackColor = true;
            radioButtonMinuscules.CheckedChanged += radioButtonMinuscules_CheckedChanged;
            // 
            // labelCopieTexte
            // 
            labelCopieTexte.AutoSize = true;
            labelCopieTexte.BackColor = SystemColors.Control;
            labelCopieTexte.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopieTexte.Location = new Point(29, 128);
            labelCopieTexte.Name = "labelCopieTexte";
            labelCopieTexte.Size = new Size(16, 24);
            labelCopieTexte.TabIndex = 7;
            labelCopieTexte.Text = "f";
            // 
            // FormCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCopieTexte);
            Controls.Add(groupBoxCasse);
            Controls.Add(groupBoxCaracteres);
            Controls.Add(groupBoxFond);
            Controls.Add(groupBoxChoix);
            Controls.Add(labelTexte);
            Controls.Add(textBoxsaisie);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormCheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox et RadioButton";
            groupBoxChoix.ResumeLayout(false);
            groupBoxChoix.PerformLayout();
            groupBoxFond.ResumeLayout(false);
            groupBoxFond.PerformLayout();
            groupBoxCaracteres.ResumeLayout(false);
            groupBoxCaracteres.PerformLayout();
            groupBoxCasse.ResumeLayout(false);
            groupBoxCasse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxsaisie;
        private Label labelTexte;
        private GroupBox groupBoxChoix;
        private CheckBox checkBoxFond;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCar;
        private GroupBox groupBoxFond;
        private RadioButton radioButtonBlue;
        private RadioButton radioButtonGreen;
        private RadioButton radioButtonRed1;
        private GroupBox groupBoxCaracteres;
        private RadioButton radioButtonBlack;
        private RadioButton radioButtonWhite;
        private RadioButton radioButtonRed2;
        private GroupBox groupBoxCasse;
        private RadioButton radioButtonMajsucules;
        private RadioButton radioButtonMinuscules;
        private Label labelCopieTexte;
    }
}