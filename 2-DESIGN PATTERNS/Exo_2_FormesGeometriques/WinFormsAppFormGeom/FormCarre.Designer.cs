namespace WinFormsAppFormGeom
{
    partial class FormCarre
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
            labelY = new Label();
            labelCote = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxCote = new TextBox();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(22, 41);
            labelX.Name = "labelX";
            labelX.Size = new Size(13, 15);
            labelX.TabIndex = 0;
            labelX.Text = "x";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(22, 91);
            labelY.Name = "labelY";
            labelY.Size = new Size(13, 15);
            labelY.TabIndex = 1;
            labelY.Text = "y";
            // 
            // labelCote
            // 
            labelCote.AutoSize = true;
            labelCote.Location = new Point(22, 151);
            labelCote.Name = "labelCote";
            labelCote.Size = new Size(32, 15);
            labelCote.TabIndex = 2;
            labelCote.Tag = "";
            labelCote.Text = "Côté";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(142, 33);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 3;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(142, 83);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 4;
            // 
            // textBoxCote
            // 
            textBoxCote.Location = new Point(142, 143);
            textBoxCote.Name = "textBoxCote";
            textBoxCote.Size = new Size(100, 23);
            textBoxCote.TabIndex = 5;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(264, 239);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click_1;
            // 
            // FormCarre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 311);
            Controls.Add(buttonValider);
            Controls.Add(textBoxCote);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(labelCote);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Name = "FormCarre";
            Text = "FormCarre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelX;
        private Label labelY;
        private Label labelCote;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxCote;
        private Button buttonValider;
    }
}