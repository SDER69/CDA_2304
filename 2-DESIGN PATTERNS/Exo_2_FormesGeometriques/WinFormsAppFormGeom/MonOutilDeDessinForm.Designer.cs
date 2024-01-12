namespace WinFormsAppFormGeom
{
    partial class MonOutilDeDessinForm
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
            buttonAddRectangle = new Button();
            buttonAddSquare = new Button();
            buttonAddACircle = new Button();
            buttonRemoveARectangle = new Button();
            buttonRemoveASquare = new Button();
            buttonRemoveACircle = new Button();
            SuspendLayout();
            // 
            // buttonAddRectangle
            // 
            buttonAddRectangle.Location = new Point(650, 41);
            buttonAddRectangle.Name = "buttonAddRectangle";
            buttonAddRectangle.Size = new Size(123, 24);
            buttonAddRectangle.TabIndex = 0;
            buttonAddRectangle.Text = "Add a rectangle";
            buttonAddRectangle.UseVisualStyleBackColor = true;
            buttonAddRectangle.Click += buttonAddRectangle_Click;
            // 
            // buttonAddSquare
            // 
            buttonAddSquare.Location = new Point(650, 106);
            buttonAddSquare.Name = "buttonAddSquare";
            buttonAddSquare.Size = new Size(123, 24);
            buttonAddSquare.TabIndex = 1;
            buttonAddSquare.Text = "Add a square";
            buttonAddSquare.UseVisualStyleBackColor = true;
            buttonAddSquare.Click += buttonAddSquare_Click;
            // 
            // buttonAddACircle
            // 
            buttonAddACircle.Location = new Point(650, 176);
            buttonAddACircle.Name = "buttonAddACircle";
            buttonAddACircle.Size = new Size(123, 23);
            buttonAddACircle.TabIndex = 2;
            buttonAddACircle.Text = "Add a circle";
            buttonAddACircle.UseVisualStyleBackColor = true;
            buttonAddACircle.Click += buttonAddACircle_Click;
            // 
            // buttonRemoveARectangle
            // 
            buttonRemoveARectangle.Location = new Point(650, 266);
            buttonRemoveARectangle.Name = "buttonRemoveARectangle";
            buttonRemoveARectangle.Size = new Size(123, 23);
            buttonRemoveARectangle.TabIndex = 3;
            buttonRemoveARectangle.Text = "Remove a rectangle";
            buttonRemoveARectangle.UseVisualStyleBackColor = true;
            buttonRemoveARectangle.Click += buttonRemoveARectangle_Click;
            // 
            // buttonRemoveASquare
            // 
            buttonRemoveASquare.Location = new Point(650, 338);
            buttonRemoveASquare.Name = "buttonRemoveASquare";
            buttonRemoveASquare.Size = new Size(123, 23);
            buttonRemoveASquare.TabIndex = 4;
            buttonRemoveASquare.Text = "Remove a square";
            buttonRemoveASquare.UseVisualStyleBackColor = true;
            buttonRemoveASquare.Click += buttonRemoveASquare_Click;
            // 
            // buttonRemoveACircle
            // 
            buttonRemoveACircle.Location = new Point(650, 402);
            buttonRemoveACircle.Name = "buttonRemoveACircle";
            buttonRemoveACircle.Size = new Size(123, 23);
            buttonRemoveACircle.TabIndex = 5;
            buttonRemoveACircle.Text = "Remove a circle";
            buttonRemoveACircle.UseVisualStyleBackColor = true;
            buttonRemoveACircle.Click += buttonRemoveACircle_Click;
            // 
            // MonOutilDeDessinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 474);
            Controls.Add(buttonRemoveACircle);
            Controls.Add(buttonRemoveASquare);
            Controls.Add(buttonRemoveARectangle);
            Controls.Add(buttonAddACircle);
            Controls.Add(buttonAddSquare);
            Controls.Add(buttonAddRectangle);
            Name = "MonOutilDeDessinForm";
            Text = "Mon outil de dessin Form";
            Paint += MonOutilDeDessinForm_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddRectangle;
        private Button buttonAddSquare;
        private Button buttonAddACircle;
        private Button buttonRemoveARectangle;
        private Button buttonRemoveASquare;
        private Button buttonRemoveACircle;
    }
}