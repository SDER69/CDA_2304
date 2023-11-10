namespace WinFormsCalculatrice
{
    partial class FormCalculatrice
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            Vider = new Button();
            calculer = new Button();
            affichage = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 48);
            button1.TabIndex = 0;
            button1.Tag = "0";
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 285);
            button2.Name = "button2";
            button2.Size = new Size(75, 48);
            button2.TabIndex = 1;
            button2.Tag = "1";
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(228, 285);
            button3.Name = "button3";
            button3.Size = new Size(75, 48);
            button3.TabIndex = 2;
            button3.Tag = "2";
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(329, 285);
            button4.Name = "button4";
            button4.Size = new Size(75, 48);
            button4.TabIndex = 3;
            button4.Tag = "3";
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(425, 285);
            button5.Name = "button5";
            button5.Size = new Size(75, 48);
            button5.TabIndex = 4;
            button5.Tag = "4";
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(32, 357);
            button6.Name = "button6";
            button6.Size = new Size(75, 48);
            button6.TabIndex = 5;
            button6.Tag = "5";
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(129, 357);
            button7.Name = "button7";
            button7.Size = new Size(75, 48);
            button7.TabIndex = 6;
            button7.Tag = "6";
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(228, 357);
            button8.Name = "button8";
            button8.Size = new Size(75, 48);
            button8.TabIndex = 7;
            button8.Tag = "7";
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(329, 357);
            button9.Name = "button9";
            button9.Size = new Size(75, 48);
            button9.TabIndex = 8;
            button9.Tag = "8";
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button10
            // 
            button10.Location = new Point(425, 357);
            button10.Name = "button10";
            button10.Size = new Size(75, 48);
            button10.TabIndex = 9;
            button10.Tag = "9";
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // Vider
            // 
            Vider.Location = new Point(32, 461);
            Vider.Name = "Vider";
            Vider.Size = new Size(172, 50);
            Vider.TabIndex = 10;
            Vider.Text = "Vider";
            Vider.UseVisualStyleBackColor = true;
            Vider.Click += button_Click_vider;
            // 
            // calculer
            // 
            calculer.Location = new Point(329, 461);
            calculer.Name = "calculer";
            calculer.Size = new Size(171, 50);
            calculer.TabIndex = 11;
            calculer.Text = "Calculer";
            calculer.UseVisualStyleBackColor = true;
            calculer.Click += button_Click_calculer;
            // 
            // affichage
            // 
            affichage.Location = new Point(32, 23);
            affichage.Multiline = true;
            affichage.Name = "affichage";
            affichage.ScrollBars = ScrollBars.Vertical;
            affichage.Size = new Size(468, 213);
            affichage.TabIndex = 12;
            // 
            // FormCalculatrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 533);
            Controls.Add(affichage);
            Controls.Add(calculer);
            Controls.Add(Vider);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormCalculatrice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalculatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button Vider;
        private Button calculer;
        private TextBox affichage;
    }
}