namespace WinFormsAppLoanRepayment
{
    partial class FormLoanRepayment
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelBorrowedCapital = new Label();
            textBoxBorrowedCapital = new TextBox();
            labelDurationInMonths = new Label();
            numericUpDownDurationInMonths = new NumericUpDown();
            hScrollBarDurationInMonths = new HScrollBar();
            labelRepaymentFrequency = new Label();
            comboBoxRepaymentFrequency = new ComboBox();
            groupBoxInterestRate = new GroupBox();
            radioButtonRate9 = new RadioButton();
            radioButtonRate8 = new RadioButton();
            radioButtonRate7 = new RadioButton();
            labelNumberOfRefunds = new Label();
            DisplayAmount = new Panel();
            buttonValidate = new Button();
            buttonCancel = new Button();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationInMonths).BeginInit();
            groupBoxInterestRate.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(42, 53);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(264, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelBorrowedCapital
            // 
            labelBorrowedCapital.AutoSize = true;
            labelBorrowedCapital.Location = new Point(42, 96);
            labelBorrowedCapital.Name = "labelBorrowedCapital";
            labelBorrowedCapital.Size = new Size(99, 15);
            labelBorrowedCapital.TabIndex = 2;
            labelBorrowedCapital.Text = "Capital emprunté";
            // 
            // textBoxBorrowedCapital
            // 
            textBoxBorrowedCapital.Location = new Point(264, 88);
            textBoxBorrowedCapital.Name = "textBoxBorrowedCapital";
            textBoxBorrowedCapital.Size = new Size(100, 23);
            textBoxBorrowedCapital.TabIndex = 3;
            // 
            // labelDurationInMonths
            // 
            labelDurationInMonths.AutoSize = true;
            labelDurationInMonths.Location = new Point(42, 143);
            labelDurationInMonths.Name = "labelDurationInMonths";
            labelDurationInMonths.Size = new Size(188, 15);
            labelDurationInMonths.TabIndex = 4;
            labelDurationInMonths.Text = "Durée en mois du remboursement";
            // 
            // numericUpDownDurationInMonths
            // 
            numericUpDownDurationInMonths.Location = new Point(264, 135);
            numericUpDownDurationInMonths.Name = "numericUpDownDurationInMonths";
            numericUpDownDurationInMonths.Size = new Size(100, 23);
            numericUpDownDurationInMonths.TabIndex = 5;
            numericUpDownDurationInMonths.ValueChanged += numericUpDownDurationInMonths_ValueChanged;
            // 
            // hScrollBarDurationInMonths
            // 
            hScrollBarDurationInMonths.Location = new Point(398, 135);
            hScrollBarDurationInMonths.Name = "hScrollBarDurationInMonths";
            hScrollBarDurationInMonths.Size = new Size(133, 23);
            hScrollBarDurationInMonths.TabIndex = 6;
            hScrollBarDurationInMonths.Scroll += hScrollBarDurationInMonths_Scroll;
            // 
            // labelRepaymentFrequency
            // 
            labelRepaymentFrequency.AutoSize = true;
            labelRepaymentFrequency.Location = new Point(42, 187);
            labelRepaymentFrequency.Name = "labelRepaymentFrequency";
            labelRepaymentFrequency.Size = new Size(167, 15);
            labelRepaymentFrequency.TabIndex = 8;
            labelRepaymentFrequency.Text = "Périodicité de remboursement";
            // 
            // comboBoxRepaymentFrequency
            // 
            comboBoxRepaymentFrequency.FormattingEnabled = true;
            comboBoxRepaymentFrequency.Location = new Point(264, 184);
            comboBoxRepaymentFrequency.Name = "comboBoxRepaymentFrequency";
            comboBoxRepaymentFrequency.Size = new Size(100, 23);
            comboBoxRepaymentFrequency.TabIndex = 9;
            // 
            // groupBoxInterestRate
            // 
            groupBoxInterestRate.Controls.Add(radioButtonRate9);
            groupBoxInterestRate.Controls.Add(radioButtonRate8);
            groupBoxInterestRate.Controls.Add(radioButtonRate7);
            groupBoxInterestRate.Location = new Point(42, 242);
            groupBoxInterestRate.Name = "groupBoxInterestRate";
            groupBoxInterestRate.Size = new Size(200, 172);
            groupBoxInterestRate.TabIndex = 10;
            groupBoxInterestRate.TabStop = false;
            groupBoxInterestRate.Text = "Taux d'intérêt annuel";
            // 
            // radioButtonRate9
            // 
            radioButtonRate9.AutoSize = true;
            radioButtonRate9.Location = new Point(51, 106);
            radioButtonRate9.Name = "radioButtonRate9";
            radioButtonRate9.Size = new Size(41, 19);
            radioButtonRate9.TabIndex = 2;
            radioButtonRate9.TabStop = true;
            radioButtonRate9.Text = "9%";
            radioButtonRate9.UseVisualStyleBackColor = true;
            // 
            // radioButtonRate8
            // 
            radioButtonRate8.AutoSize = true;
            radioButtonRate8.Location = new Point(51, 69);
            radioButtonRate8.Name = "radioButtonRate8";
            radioButtonRate8.Size = new Size(41, 19);
            radioButtonRate8.TabIndex = 1;
            radioButtonRate8.TabStop = true;
            radioButtonRate8.Text = "8%";
            radioButtonRate8.UseVisualStyleBackColor = true;
            // 
            // radioButtonRate7
            // 
            radioButtonRate7.AutoSize = true;
            radioButtonRate7.Location = new Point(51, 33);
            radioButtonRate7.Name = "radioButtonRate7";
            radioButtonRate7.Size = new Size(41, 19);
            radioButtonRate7.TabIndex = 0;
            radioButtonRate7.TabStop = true;
            radioButtonRate7.Text = "7%";
            radioButtonRate7.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfRefunds
            // 
            labelNumberOfRefunds.AutoSize = true;
            labelNumberOfRefunds.Location = new Point(363, 252);
            labelNumberOfRefunds.Name = "labelNumberOfRefunds";
            labelNumberOfRefunds.Size = new Size(125, 15);
            labelNumberOfRefunds.TabIndex = 12;
            labelNumberOfRefunds.Text = "Remboursements en €";
            // 
            // DisplayAmount
            // 
            DisplayAmount.Location = new Point(289, 311);
            DisplayAmount.Name = "DisplayAmount";
            DisplayAmount.Size = new Size(188, 72);
            DisplayAmount.TabIndex = 13;
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(640, 311);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(120, 33);
            buttonValidate.TabIndex = 14;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(640, 372);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 33);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(327, 252);
            label.Name = "label";
            label.Size = new Size(13, 15);
            label.TabIndex = 16;
            label.Text = "1";
            // 
            // FormLoanRepayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(buttonCancel);
            Controls.Add(buttonValidate);
            Controls.Add(DisplayAmount);
            Controls.Add(labelNumberOfRefunds);
            Controls.Add(groupBoxInterestRate);
            Controls.Add(comboBoxRepaymentFrequency);
            Controls.Add(labelRepaymentFrequency);
            Controls.Add(hScrollBarDurationInMonths);
            Controls.Add(numericUpDownDurationInMonths);
            Controls.Add(labelDurationInMonths);
            Controls.Add(textBoxBorrowedCapital);
            Controls.Add(labelBorrowedCapital);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLoanRepayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprunts";
            Load += FormLoanRepayment_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationInMonths).EndInit();
            groupBoxInterestRate.ResumeLayout(false);
            groupBoxInterestRate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelBorrowedCapital;
        private TextBox textBoxBorrowedCapital;
        private Label labelDurationInMonths;
        private NumericUpDown numericUpDownDurationInMonths;
        private HScrollBar hScrollBarDurationInMonths;
        private Label labelRepaymentFrequency;
        private ComboBox comboBoxRepaymentFrequency;
        private GroupBox groupBoxInterestRate;
        private RadioButton radioButtonRate8;
        private RadioButton radioButtonRate7;
        private RadioButton radioButtonRate9;
        private Label labelNumberOfRefunds;
        private Panel DisplayAmount;
        private Button buttonValidate;
        private Button buttonCancel;
        private Label label;
    }
}