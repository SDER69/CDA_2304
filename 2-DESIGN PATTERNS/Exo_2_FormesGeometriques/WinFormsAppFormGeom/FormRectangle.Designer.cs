namespace WinFormsAppFormGeom
{
    partial class FormRectangle
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
            buttonValider = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxLargeur = new TextBox();
            textBoxLongueur = new TextBox();
            SuspendLayout();
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(226, 217);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 0;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 1;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 2;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Largeur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Longeur";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(95, 40);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 5;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(95, 72);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 6;
            // 
            // textBoxLargeur
            // 
            textBoxLargeur.Location = new Point(95, 116);
            textBoxLargeur.Name = "textBoxLargeur";
            textBoxLargeur.Size = new Size(100, 23);
            textBoxLargeur.TabIndex = 7;
            // 
            // textBoxLongueur
            // 
            textBoxLongueur.Location = new Point(95, 157);
            textBoxLongueur.Name = "textBoxLongueur";
            textBoxLongueur.Size = new Size(100, 23);
            textBoxLongueur.TabIndex = 8;
            // 
            // FormRectangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 265);
            Controls.Add(textBoxLongueur);
            Controls.Add(textBoxLargeur);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonValider);
            Name = "FormRectangle";
            Text = "FormRectangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonValider;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxLargeur;
        private TextBox textBoxLongueur;
    }
}