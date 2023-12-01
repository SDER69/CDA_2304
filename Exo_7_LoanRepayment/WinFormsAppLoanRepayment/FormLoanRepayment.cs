namespace WinFormsAppLoanRepayment
{
    public partial class FormLoanRepayment : Form
    {
        //List<string> periodicities = new List<string>();
        public FormLoanRepayment()
        {
            InitializeComponent();
        }

        private void FormLoanRepayment_Load(object sender, EventArgs e)
        {
            this.textBoxName.Focus();
            // Default value of the duration
            this.numericUpDownDurationInMonths.Value = 1;

            // Default values of the combobox
            this.comboBoxRepaymentFrequency.Items.Add("Mensuelle");
            this.comboBoxRepaymentFrequency.Items.Add("Bimestrielle");
            this.comboBoxRepaymentFrequency.Items.Add("Trimestrielle");
            this.comboBoxRepaymentFrequency.Items.Add("Semestrielle");
            this.comboBoxRepaymentFrequency.Items.Add("Annuelle");
            this.comboBoxRepaymentFrequency.SelectedIndex = 0;

            // Default value of the rate
            this.radioButtonRate7.Checked = true;

            // Default value of the number of refunds
            this.label.Text = "1";
        }

        private void hScrollBarDurationInMonths_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownDurationInMonths.Value = e.NewValue;
        }

        private void numericUpDownDurationInMonths_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarDurationInMonths.Value = (int)this.numericUpDownDurationInMonths.Value;
        }
    }
}