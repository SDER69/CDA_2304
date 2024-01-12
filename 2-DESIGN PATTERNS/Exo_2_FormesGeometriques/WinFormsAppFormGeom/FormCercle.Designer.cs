namespace WinFormsAppFormGeom
{
    partial class FormCercle
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
            labelX = new Label();
            textBoxX = new TextBox();
            labelY = new Label();
            textBoxY = new TextBox();
            labelRayon = new Label();
            textBoxRayon = new TextBox();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(27, 49);
            labelX.Name = "labelX";
            labelX.Size = new Size(13, 15);
            labelX.TabIndex = 0;
            labelX.Text = "x";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(142, 41);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 1;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(27, 103);
            labelY.Name = "labelY";
            labelY.Size = new Size(13, 15);
            labelY.TabIndex = 2;
            labelY.Text = "y";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(142, 95);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // labelRayon
            // 
            labelRayon.AutoSize = true;
            labelRayon.Location = new Point(27, 160);
            labelRayon.Name = "labelRayon";
            labelRayon.Size = new Size(40, 15);
            labelRayon.TabIndex = 4;
            labelRayon.Text = "Rayon";
            // 
            // textBoxRayon
            // 
            textBoxRayon.Location = new Point(142, 152);
            textBoxRayon.Name = "textBoxRayon";
            textBoxRayon.Size = new Size(100, 23);
            textBoxRayon.TabIndex = 5;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(290, 269);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // FormCercle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 357);
            Controls.Add(buttonValider);
            Controls.Add(textBoxRayon);
            Controls.Add(labelRayon);
            Controls.Add(textBoxY);
            Controls.Add(labelY);
            Controls.Add(textBoxX);
            Controls.Add(labelX);
            Name = "FormCercle";
            Text = "FormCercle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelX;
        private TextBox textBoxX;
        private Label labelY;
        private TextBox textBoxY;
        private Label labelRayon;
        private TextBox textBoxRayon;
        private Button buttonValider;
    }
}