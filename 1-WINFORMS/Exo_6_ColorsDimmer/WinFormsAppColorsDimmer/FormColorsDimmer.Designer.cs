namespace WinFormsAppColorsDimmer
{
    partial class FormColorsDimmer
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
            hScrollBarRed = new HScrollBar();
            labelRed = new Label();
            hScrollBarGreen = new HScrollBar();
            labelGreen = new Label();
            hScrollBarBlue = new HScrollBar();
            labelBlue = new Label();
            numericUpDownRed = new NumericUpDown();
            numericUpDownGreen = new NumericUpDown();
            numericUpDownBlue = new NumericUpDown();
            panelRed = new Panel();
            panelGreen = new Panel();
            panelBlue = new Panel();
            panelDisplayColors = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            SuspendLayout();
            // 
            // hScrollBarRed
            // 
            hScrollBarRed.Location = new Point(137, 56);
            hScrollBarRed.Name = "hScrollBarRed";
            hScrollBarRed.Size = new Size(204, 28);
            hScrollBarRed.TabIndex = 0;
            hScrollBarRed.Scroll += hScrollBarRed_Scroll;
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(44, 69);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(41, 15);
            labelRed.TabIndex = 2;
            labelRed.Text = "Rouge";
            // 
            // hScrollBarGreen
            // 
            hScrollBarGreen.Location = new Point(137, 113);
            hScrollBarGreen.Name = "hScrollBarGreen";
            hScrollBarGreen.Size = new Size(204, 30);
            hScrollBarGreen.TabIndex = 3;
            hScrollBarGreen.Scroll += hScrollBarGreen_Scroll;
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(44, 128);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(27, 15);
            labelGreen.TabIndex = 4;
            labelGreen.Text = "Vert";
            // 
            // hScrollBarBlue
            // 
            hScrollBarBlue.Location = new Point(137, 171);
            hScrollBarBlue.Name = "hScrollBarBlue";
            hScrollBarBlue.Size = new Size(204, 30);
            hScrollBarBlue.TabIndex = 5;
            hScrollBarBlue.Scroll += hScrollBarBlue_Scroll;
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(44, 186);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(30, 15);
            labelBlue.TabIndex = 6;
            labelBlue.Text = "Bleu";
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(385, 61);
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(120, 23);
            numericUpDownRed.TabIndex = 8;
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Location = new Point(385, 120);
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(120, 23);
            numericUpDownGreen.TabIndex = 9;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Location = new Point(385, 171);
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(120, 23);
            numericUpDownBlue.TabIndex = 10;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // panelRed
            // 
            panelRed.Location = new Point(537, 61);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(132, 23);
            panelRed.TabIndex = 11;
            // 
            // panelGreen
            // 
            panelGreen.Location = new Point(537, 120);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(132, 23);
            panelGreen.TabIndex = 12;
            // 
            // panelBlue
            // 
            panelBlue.Location = new Point(537, 171);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(132, 23);
            panelBlue.TabIndex = 13;
            // 
            // panelDisplayColors
            // 
            panelDisplayColors.Location = new Point(137, 239);
            panelDisplayColors.Name = "panelDisplayColors";
            panelDisplayColors.Size = new Size(532, 127);
            panelDisplayColors.TabIndex = 14;
            // 
            // FormColorsDimmer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 412);
            Controls.Add(panelDisplayColors);
            Controls.Add(panelBlue);
            Controls.Add(panelGreen);
            Controls.Add(panelRed);
            Controls.Add(numericUpDownBlue);
            Controls.Add(numericUpDownGreen);
            Controls.Add(numericUpDownRed);
            Controls.Add(labelBlue);
            Controls.Add(hScrollBarBlue);
            Controls.Add(labelGreen);
            Controls.Add(hScrollBarGreen);
            Controls.Add(labelRed);
            Controls.Add(hScrollBarRed);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormColorsDimmer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBarRed;
        private Label labelRed;
        private HScrollBar hScrollBarGreen;
        private Label labelGreen;
        private HScrollBar hScrollBarBlue;
        private Label labelBlue;
        private NumericUpDown numericUpDownRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
        private Panel panelRed;
        private Panel panelGreen;
        private Panel panelBlue;
        private Panel panelDisplayColors;
    }
}