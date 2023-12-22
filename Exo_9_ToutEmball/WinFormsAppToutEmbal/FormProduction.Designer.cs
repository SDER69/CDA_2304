namespace WinFormsAppToutEmbal
{
    partial class FormProduction
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
            tabControlInfos = new TabControl();
            tabPageTypeA = new TabPage();
            textBoxDefectRateFromStartTypeA = new TextBox();
            labelDefectRateFromStartTypeA = new Label();
            textBoxDefectRatePerHourTypeA = new TextBox();
            labelDefectRatePerHourTypeA = new Label();
            textBoxNbCratesFromStartTypeA = new TextBox();
            labelNbCratesFromStartTypeA = new Label();
            tabPageTypeB = new TabPage();
            textBoxDefectRateFromStartTypeB = new TextBox();
            labelDefectRateFromStartTypeB = new Label();
            textBoxDefectRatePerHourTypeB = new TextBox();
            labelDefectRatePerHourTypeB = new Label();
            textBoxNbCratesFromStartTypeB = new TextBox();
            labelNbCratesFromStartTypeB = new Label();
            tabPageTypeC = new TabPage();
            textBoxDefectRateFromStartTypeC = new TextBox();
            labelDefectRateFromStartTypeC = new Label();
            textBoxDefectRatePerHourTypeC = new TextBox();
            labelDefectRatePerHourTypeC = new Label();
            textBoxNbCratesFromStartTypeC = new TextBox();
            labelNbCratesFromStartTypeC = new Label();
            labelProductionA = new Label();
            labelProductionB = new Label();
            labelProductionC = new Label();
            progressBarProductionA = new ProgressBar();
            progressBarProductionB = new ProgressBar();
            progressBarProductionC = new ProgressBar();
            menuStrip = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            démarrerToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItemStart = new ToolStripMenuItem();
            bToolStripMenuItemStart = new ToolStripMenuItem();
            cToolStripMenuItemStart = new ToolStripMenuItem();
            arrêterToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItemStop = new ToolStripMenuItem();
            bToolStripMenuItemStop = new ToolStripMenuItem();
            cToolStripMenuItemStop = new ToolStripMenuItem();
            continuerToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItemContinue = new ToolStripMenuItem();
            bToolStripMenuItemContinue = new ToolStripMenuItem();
            cToolStripMenuItemContinue = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControlInfos.SuspendLayout();
            tabPageTypeA.SuspendLayout();
            tabPageTypeB.SuspendLayout();
            tabPageTypeC.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlInfos
            // 
            tabControlInfos.Controls.Add(tabPageTypeA);
            tabControlInfos.Controls.Add(tabPageTypeB);
            tabControlInfos.Controls.Add(tabPageTypeC);
            tabControlInfos.Location = new Point(314, 56);
            tabControlInfos.Name = "tabControlInfos";
            tabControlInfos.SelectedIndex = 0;
            tabControlInfos.Size = new Size(462, 250);
            tabControlInfos.TabIndex = 1;
            tabControlInfos.Tag = "";
            // 
            // tabPageTypeA
            // 
            tabPageTypeA.Controls.Add(textBoxDefectRateFromStartTypeA);
            tabPageTypeA.Controls.Add(labelDefectRateFromStartTypeA);
            tabPageTypeA.Controls.Add(textBoxDefectRatePerHourTypeA);
            tabPageTypeA.Controls.Add(labelDefectRatePerHourTypeA);
            tabPageTypeA.Controls.Add(textBoxNbCratesFromStartTypeA);
            tabPageTypeA.Controls.Add(labelNbCratesFromStartTypeA);
            tabPageTypeA.Location = new Point(4, 24);
            tabPageTypeA.Name = "tabPageTypeA";
            tabPageTypeA.Padding = new Padding(3);
            tabPageTypeA.Size = new Size(454, 222);
            tabPageTypeA.TabIndex = 0;
            tabPageTypeA.Text = "Type A";
            tabPageTypeA.UseVisualStyleBackColor = true;
            // 
            // textBoxDefectRateFromStartTypeA
            // 
            textBoxDefectRateFromStartTypeA.Location = new Point(351, 129);
            textBoxDefectRateFromStartTypeA.Name = "textBoxDefectRateFromStartTypeA";
            textBoxDefectRateFromStartTypeA.Size = new Size(100, 23);
            textBoxDefectRateFromStartTypeA.TabIndex = 5;
            // 
            // labelDefectRateFromStartTypeA
            // 
            labelDefectRateFromStartTypeA.AutoSize = true;
            labelDefectRateFromStartTypeA.Location = new Point(16, 137);
            labelDefectRateFromStartTypeA.Name = "labelDefectRateFromStartTypeA";
            labelDefectRateFromStartTypeA.Size = new Size(166, 15);
            labelDefectRateFromStartTypeA.TabIndex = 4;
            labelDefectRateFromStartTypeA.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxDefectRatePerHourTypeA
            // 
            textBoxDefectRatePerHourTypeA.Location = new Point(351, 82);
            textBoxDefectRatePerHourTypeA.Name = "textBoxDefectRatePerHourTypeA";
            textBoxDefectRatePerHourTypeA.Size = new Size(100, 23);
            textBoxDefectRatePerHourTypeA.TabIndex = 3;
            // 
            // labelDefectRatePerHourTypeA
            // 
            labelDefectRatePerHourTypeA.AutoSize = true;
            labelDefectRatePerHourTypeA.Location = new Point(16, 90);
            labelDefectRatePerHourTypeA.Name = "labelDefectRatePerHourTypeA";
            labelDefectRatePerHourTypeA.Size = new Size(101, 15);
            labelDefectRatePerHourTypeA.TabIndex = 2;
            labelDefectRatePerHourTypeA.Text = "Taux défaut heure";
            // 
            // textBoxNbCratesFromStartTypeA
            // 
            textBoxNbCratesFromStartTypeA.Location = new Point(351, 33);
            textBoxNbCratesFromStartTypeA.Name = "textBoxNbCratesFromStartTypeA";
            textBoxNbCratesFromStartTypeA.Size = new Size(100, 23);
            textBoxNbCratesFromStartTypeA.TabIndex = 1;
            // 
            // labelNbCratesFromStartTypeA
            // 
            labelNbCratesFromStartTypeA.AutoSize = true;
            labelNbCratesFromStartTypeA.Location = new Point(16, 41);
            labelNbCratesFromStartTypeA.Name = "labelNbCratesFromStartTypeA";
            labelNbCratesFromStartTypeA.Size = new Size(216, 15);
            labelNbCratesFromStartTypeA.TabIndex = 0;
            labelNbCratesFromStartTypeA.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageTypeB
            // 
            tabPageTypeB.Controls.Add(textBoxDefectRateFromStartTypeB);
            tabPageTypeB.Controls.Add(labelDefectRateFromStartTypeB);
            tabPageTypeB.Controls.Add(textBoxDefectRatePerHourTypeB);
            tabPageTypeB.Controls.Add(labelDefectRatePerHourTypeB);
            tabPageTypeB.Controls.Add(textBoxNbCratesFromStartTypeB);
            tabPageTypeB.Controls.Add(labelNbCratesFromStartTypeB);
            tabPageTypeB.Location = new Point(4, 24);
            tabPageTypeB.Name = "tabPageTypeB";
            tabPageTypeB.Padding = new Padding(3);
            tabPageTypeB.Size = new Size(454, 222);
            tabPageTypeB.TabIndex = 1;
            tabPageTypeB.Text = "Type B";
            tabPageTypeB.UseVisualStyleBackColor = true;
            // 
            // textBoxDefectRateFromStartTypeB
            // 
            textBoxDefectRateFromStartTypeB.Location = new Point(351, 129);
            textBoxDefectRateFromStartTypeB.Name = "textBoxDefectRateFromStartTypeB";
            textBoxDefectRateFromStartTypeB.Size = new Size(100, 23);
            textBoxDefectRateFromStartTypeB.TabIndex = 6;
            // 
            // labelDefectRateFromStartTypeB
            // 
            labelDefectRateFromStartTypeB.AutoSize = true;
            labelDefectRateFromStartTypeB.Location = new Point(16, 137);
            labelDefectRateFromStartTypeB.Name = "labelDefectRateFromStartTypeB";
            labelDefectRateFromStartTypeB.Size = new Size(166, 15);
            labelDefectRateFromStartTypeB.TabIndex = 5;
            labelDefectRateFromStartTypeB.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxDefectRatePerHourTypeB
            // 
            textBoxDefectRatePerHourTypeB.Location = new Point(351, 82);
            textBoxDefectRatePerHourTypeB.Name = "textBoxDefectRatePerHourTypeB";
            textBoxDefectRatePerHourTypeB.Size = new Size(100, 23);
            textBoxDefectRatePerHourTypeB.TabIndex = 4;
            // 
            // labelDefectRatePerHourTypeB
            // 
            labelDefectRatePerHourTypeB.AutoSize = true;
            labelDefectRatePerHourTypeB.Location = new Point(16, 90);
            labelDefectRatePerHourTypeB.Name = "labelDefectRatePerHourTypeB";
            labelDefectRatePerHourTypeB.Size = new Size(101, 15);
            labelDefectRatePerHourTypeB.TabIndex = 3;
            labelDefectRatePerHourTypeB.Text = "Taux défaut heure";
            // 
            // textBoxNbCratesFromStartTypeB
            // 
            textBoxNbCratesFromStartTypeB.Location = new Point(351, 33);
            textBoxNbCratesFromStartTypeB.Name = "textBoxNbCratesFromStartTypeB";
            textBoxNbCratesFromStartTypeB.Size = new Size(100, 23);
            textBoxNbCratesFromStartTypeB.TabIndex = 2;
            // 
            // labelNbCratesFromStartTypeB
            // 
            labelNbCratesFromStartTypeB.AutoSize = true;
            labelNbCratesFromStartTypeB.Location = new Point(16, 41);
            labelNbCratesFromStartTypeB.Name = "labelNbCratesFromStartTypeB";
            labelNbCratesFromStartTypeB.Size = new Size(216, 15);
            labelNbCratesFromStartTypeB.TabIndex = 1;
            labelNbCratesFromStartTypeB.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageTypeC
            // 
            tabPageTypeC.Controls.Add(textBoxDefectRateFromStartTypeC);
            tabPageTypeC.Controls.Add(labelDefectRateFromStartTypeC);
            tabPageTypeC.Controls.Add(textBoxDefectRatePerHourTypeC);
            tabPageTypeC.Controls.Add(labelDefectRatePerHourTypeC);
            tabPageTypeC.Controls.Add(textBoxNbCratesFromStartTypeC);
            tabPageTypeC.Controls.Add(labelNbCratesFromStartTypeC);
            tabPageTypeC.Location = new Point(4, 24);
            tabPageTypeC.Name = "tabPageTypeC";
            tabPageTypeC.Size = new Size(454, 222);
            tabPageTypeC.TabIndex = 2;
            tabPageTypeC.Text = "Type C";
            tabPageTypeC.UseVisualStyleBackColor = true;
            // 
            // textBoxDefectRateFromStartTypeC
            // 
            textBoxDefectRateFromStartTypeC.Location = new Point(351, 129);
            textBoxDefectRateFromStartTypeC.Name = "textBoxDefectRateFromStartTypeC";
            textBoxDefectRateFromStartTypeC.Size = new Size(100, 23);
            textBoxDefectRateFromStartTypeC.TabIndex = 7;
            // 
            // labelDefectRateFromStartTypeC
            // 
            labelDefectRateFromStartTypeC.AutoSize = true;
            labelDefectRateFromStartTypeC.Location = new Point(16, 137);
            labelDefectRateFromStartTypeC.Name = "labelDefectRateFromStartTypeC";
            labelDefectRateFromStartTypeC.Size = new Size(166, 15);
            labelDefectRateFromStartTypeC.TabIndex = 6;
            labelDefectRateFromStartTypeC.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxDefectRatePerHourTypeC
            // 
            textBoxDefectRatePerHourTypeC.Location = new Point(351, 82);
            textBoxDefectRatePerHourTypeC.Name = "textBoxDefectRatePerHourTypeC";
            textBoxDefectRatePerHourTypeC.Size = new Size(100, 23);
            textBoxDefectRatePerHourTypeC.TabIndex = 5;
            // 
            // labelDefectRatePerHourTypeC
            // 
            labelDefectRatePerHourTypeC.AutoSize = true;
            labelDefectRatePerHourTypeC.Location = new Point(16, 90);
            labelDefectRatePerHourTypeC.Name = "labelDefectRatePerHourTypeC";
            labelDefectRatePerHourTypeC.Size = new Size(101, 15);
            labelDefectRatePerHourTypeC.TabIndex = 4;
            labelDefectRatePerHourTypeC.Text = "Taux défaut heure";
            // 
            // textBoxNbCratesFromStartTypeC
            // 
            textBoxNbCratesFromStartTypeC.Location = new Point(351, 33);
            textBoxNbCratesFromStartTypeC.Name = "textBoxNbCratesFromStartTypeC";
            textBoxNbCratesFromStartTypeC.Size = new Size(100, 23);
            textBoxNbCratesFromStartTypeC.TabIndex = 3;
            // 
            // labelNbCratesFromStartTypeC
            // 
            labelNbCratesFromStartTypeC.AutoSize = true;
            labelNbCratesFromStartTypeC.Location = new Point(16, 41);
            labelNbCratesFromStartTypeC.Name = "labelNbCratesFromStartTypeC";
            labelNbCratesFromStartTypeC.Size = new Size(216, 15);
            labelNbCratesFromStartTypeC.TabIndex = 2;
            labelNbCratesFromStartTypeC.Text = "Nombre de caisses depuis le démarrage";
            // 
            // labelProductionA
            // 
            labelProductionA.AutoSize = true;
            labelProductionA.Location = new Point(59, 335);
            labelProductionA.Name = "labelProductionA";
            labelProductionA.Size = new Size(77, 15);
            labelProductionA.TabIndex = 5;
            labelProductionA.Text = "Production A";
            // 
            // labelProductionB
            // 
            labelProductionB.AutoSize = true;
            labelProductionB.Location = new Point(59, 370);
            labelProductionB.Name = "labelProductionB";
            labelProductionB.Size = new Size(76, 15);
            labelProductionB.TabIndex = 6;
            labelProductionB.Text = "Production B";
            // 
            // labelProductionC
            // 
            labelProductionC.AutoSize = true;
            labelProductionC.Location = new Point(59, 405);
            labelProductionC.Name = "labelProductionC";
            labelProductionC.Size = new Size(77, 15);
            labelProductionC.TabIndex = 7;
            labelProductionC.Text = "Production C";
            // 
            // progressBarProductionA
            // 
            progressBarProductionA.Location = new Point(318, 327);
            progressBarProductionA.Name = "progressBarProductionA";
            progressBarProductionA.Size = new Size(454, 23);
            progressBarProductionA.TabIndex = 8;
            // 
            // progressBarProductionB
            // 
            progressBarProductionB.Location = new Point(318, 362);
            progressBarProductionB.Name = "progressBarProductionB";
            progressBarProductionB.Size = new Size(454, 23);
            progressBarProductionB.TabIndex = 9;
            // 
            // progressBarProductionC
            // 
            progressBarProductionC.Location = new Point(318, 397);
            progressBarProductionC.Name = "progressBarProductionC";
            progressBarProductionC.Size = new Size(454, 23);
            progressBarProductionC.TabIndex = 10;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 11;
            menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { démarrerToolStripMenuItem, arrêterToolStripMenuItem, continuerToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            démarrerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItemStart, bToolStripMenuItemStart, cToolStripMenuItemStart });
            démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            démarrerToolStripMenuItem.Size = new Size(180, 22);
            démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // aToolStripMenuItemStart
            // 
            aToolStripMenuItemStart.Name = "aToolStripMenuItemStart";
            aToolStripMenuItemStart.Size = new Size(82, 22);
            aToolStripMenuItemStart.Text = "A";
            aToolStripMenuItemStart.Click += aToolStripMenuItemStart_Click;
            // 
            // bToolStripMenuItemStart
            // 
            bToolStripMenuItemStart.Name = "bToolStripMenuItemStart";
            bToolStripMenuItemStart.Size = new Size(82, 22);
            bToolStripMenuItemStart.Text = "B";
            bToolStripMenuItemStart.Click += bToolStripMenuItemStart_Click;
            // 
            // cToolStripMenuItemStart
            // 
            cToolStripMenuItemStart.Name = "cToolStripMenuItemStart";
            cToolStripMenuItemStart.Size = new Size(82, 22);
            cToolStripMenuItemStart.Text = "C";
            cToolStripMenuItemStart.Click += cToolStripMenuItemStart_Click;
            // 
            // arrêterToolStripMenuItem
            // 
            arrêterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItemStop, bToolStripMenuItemStop, cToolStripMenuItemStop });
            arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            arrêterToolStripMenuItem.Size = new Size(180, 22);
            arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuItemStop
            // 
            aToolStripMenuItemStop.Name = "aToolStripMenuItemStop";
            aToolStripMenuItemStop.Size = new Size(82, 22);
            aToolStripMenuItemStop.Text = "A";
            aToolStripMenuItemStop.Click += aToolStripMenuItemStop_Click;
            // 
            // bToolStripMenuItemStop
            // 
            bToolStripMenuItemStop.Name = "bToolStripMenuItemStop";
            bToolStripMenuItemStop.Size = new Size(82, 22);
            bToolStripMenuItemStop.Text = "B";
            bToolStripMenuItemStop.Click += bToolStripMenuItemStop_Click;
            // 
            // cToolStripMenuItemStop
            // 
            cToolStripMenuItemStop.Name = "cToolStripMenuItemStop";
            cToolStripMenuItemStop.Size = new Size(82, 22);
            cToolStripMenuItemStop.Text = "C";
            cToolStripMenuItemStop.Click += cToolStripMenuItemStop_Click;
            // 
            // continuerToolStripMenuItem
            // 
            continuerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItemContinue, bToolStripMenuItemContinue, cToolStripMenuItemContinue });
            continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            continuerToolStripMenuItem.Size = new Size(180, 22);
            continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuItemContinue
            // 
            aToolStripMenuItemContinue.Name = "aToolStripMenuItemContinue";
            aToolStripMenuItemContinue.Size = new Size(180, 22);
            aToolStripMenuItemContinue.Text = "A";
            aToolStripMenuItemContinue.Click += aToolStripMenuItemContinue_Click;
            // 
            // bToolStripMenuItemContinue
            // 
            bToolStripMenuItemContinue.Name = "bToolStripMenuItemContinue";
            bToolStripMenuItemContinue.Size = new Size(180, 22);
            bToolStripMenuItemContinue.Text = "B";
            bToolStripMenuItemContinue.Click += bToolStripMenuItemContinue_Click;
            // 
            // cToolStripMenuItemContinue
            // 
            cToolStripMenuItemContinue.Name = "cToolStripMenuItemContinue";
            cToolStripMenuItemContinue.Size = new Size(180, 22);
            cToolStripMenuItemContinue.Text = "C";
            cToolStripMenuItemContinue.Click += cToolStripMenuItemContinue_Click;
            // 
            // FormProduction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBarProductionC);
            Controls.Add(progressBarProductionB);
            Controls.Add(progressBarProductionA);
            Controls.Add(labelProductionC);
            Controls.Add(labelProductionB);
            Controls.Add(labelProductionA);
            Controls.Add(tabControlInfos);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip;
            Name = "FormProduction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Production des caisses";
            tabControlInfos.ResumeLayout(false);
            tabPageTypeA.ResumeLayout(false);
            tabPageTypeA.PerformLayout();
            tabPageTypeB.ResumeLayout(false);
            tabPageTypeB.PerformLayout();
            tabPageTypeC.ResumeLayout(false);
            tabPageTypeC.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControlInfos;
        private TabPage tabPageTypeA;
        private TabPage tabPageTypeB;
        private TabPage tabPageTypeC;
        private Label labelNbCratesFromStartTypeA;
        private Label labelDefectRatePerHourTypeA;
        private TextBox textBoxNbCratesFromStartTypeA;
        private TextBox textBoxDefectRatePerHourTypeA;
        private TextBox textBoxDefectRateFromStartTypeA;
        private Label labelDefectRateFromStartTypeA;
        private Label labelProductionA;
        private Label labelProductionB;
        private Label labelProductionC;
        private ProgressBar progressBarProductionA;
        private ProgressBar progressBarProductionB;
        private ProgressBar progressBarProductionC;
        private Label labelNbCratesFromStartTypeB;
        private TextBox textBoxNbCratesFromStartTypeB;
        private Label labelDefectRatePerHourTypeB;
        private TextBox textBoxDefectRatePerHourTypeB;
        private Label labelDefectRateFromStartTypeB;
        private TextBox textBoxDefectRateFromStartTypeB;
        private Label labelNbCratesFromStartTypeC;
        private TextBox textBoxDefectRateFromStartTypeC;
        private Label labelDefectRateFromStartTypeC;
        private TextBox textBoxDefectRatePerHourTypeC;
        private Label labelDefectRatePerHourTypeC;
        private TextBox textBoxNbCratesFromStartTypeC;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem démarrerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItemStart;
        private ToolStripMenuItem arrêterToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItemStop;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItemContinue;
        private ToolStripMenuItem bToolStripMenuItemStart;
        private ToolStripMenuItem cToolStripMenuItemStart;
        private ToolStripMenuItem bToolStripMenuItemStop;
        private ToolStripMenuItem cToolStripMenuItemStop;
        private ToolStripMenuItem bToolStripMenuItemContinue;
        private ToolStripMenuItem cToolStripMenuItemContinue;
        private System.Windows.Forms.Timer timer1;
    }
}