using ClassLibraryLoanRepayment;
using CL_CheckButtons;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace WinFormsAppLoanRepayment
{
    public partial class FormLoanRepayment : Form
    {
        LoanRepayment loan;

        public FormLoanRepayment()
        {
            InitializeComponent();

            loan = new LoanRepayment(1, 1, 1, 0.07d);


            #region InitializationDefaultValues
            // Default values of the combobox
            this.comboBoxRepaymentFrequency.Items.Add("Mensuelle");
            this.comboBoxRepaymentFrequency.Items.Add("Bimestrielle");
            this.comboBoxRepaymentFrequency.Items.Add("Trimestrielle");
            this.comboBoxRepaymentFrequency.Items.Add("Semestrielle");
            this.comboBoxRepaymentFrequency.Items.Add("Annuelle");
            this.comboBoxRepaymentFrequency.SelectedIndex = 0;

            // Default value of the duration
            this.numericUpDownDurationInMonths.Value = 1;

            // Default value of the rate
            this.radioButtonRate7.Checked = true;

            // Default value of the number of refunds
            labeLNumberOfRefundsInt.Text = "1";
            #endregion

            //Default value of the validate button
            this.buttonValidate.Enabled = false;

            #region configuration
            this.hScrollBarDurationInMonths.Minimum = 1;
            this.hScrollBarDurationInMonths.Maximum = 360;
            this.hScrollBarDurationInMonths.LargeChange = 1;
            this.numericUpDownDurationInMonths.Minimum = 1;
            this.numericUpDownDurationInMonths.Maximum = 360;
            //this.loan.NumberOfRefunds = 1;

            #endregion
        }

        private void FormLoanRepayment_Load(object sender, EventArgs e)
        {
            this.textBoxName.Focus();
            this.labelAmountDisplay.Text = string.Empty;
            //this.loan.NumberOfRefunds = 360;
        }

        private void hScrollBarDurationInMonths_Scroll(object sender, ScrollEventArgs e)
        {
            int newValue = RegulationOfNumbersOfRefunds(this.hScrollBarDurationInMonths.Value, this.loan.RepaymentFrequency, false);
            this.loan.NumberOfRefunds = int.Parse(newValue.ToString());
            UpdateIHM();
        }

        private void numericUpDownDurationInMonths_ValueChanged(object sender, EventArgs e)
        {
            int newValue;
            if ((this.numericUpDownDurationInMonths.Value > this.loan.NumberOfRefunds) && (this.loan.RepaymentFrequency != 1))
            {
                newValue = RegulationOfNumbersOfRefunds((int)this.numericUpDownDurationInMonths.Value, this.loan.RepaymentFrequency, true);
            }
            else
            {
                newValue = RegulationOfNumbersOfRefunds((int)this.numericUpDownDurationInMonths.Value, this.loan.RepaymentFrequency, false);
            }
            this.loan.NumberOfRefunds = int.Parse(newValue.ToString());
            UpdateIHM();
        }

        private void textBoxBorrowedCapital_Leave(object sender, EventArgs e)
        {
            if (this.textBoxBorrowedCapital.Text == string.Empty)
            {
                this.errorProviderCheckBorrowedCapital.SetError(this.textBoxBorrowedCapital, "Ce champ est obligatoire");
                this.textBoxBorrowedCapital.Focus();
            }
            else if (!CL_CheckButtons.CheckButtons.CheckNumbers(this.textBoxBorrowedCapital.Text))
            {
                this.errorProviderCheckBorrowedCapital.SetError(this.textBoxBorrowedCapital, "Veuillez saisir un nombre valide");
                this.textBoxBorrowedCapital.Focus();
                this.buttonValidate.Enabled = false;
            }
            else
            {
                this.buttonValidate.Enabled = true;
                this.errorProviderCheckBorrowedCapital.SetError(this.textBoxBorrowedCapital, "");
                this.loan.BorrowedCapital = int.Parse(textBoxBorrowedCapital.Text);
                UpdateIHM();
            }
        }

        private void comboBoxRepaymentFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxRepaymentFrequency.SelectedIndex == 0)
            {
                this.loan.RepaymentFrequency = 1;

            }
            else if (this.comboBoxRepaymentFrequency.SelectedIndex == 1)
            {
                this.loan.RepaymentFrequency = 2;
            }
            else if (this.comboBoxRepaymentFrequency.SelectedIndex == 2)
            {
                this.loan.RepaymentFrequency = 3;
            }
            else if (this.comboBoxRepaymentFrequency.SelectedIndex == 3)
            {
                this.loan.RepaymentFrequency = 6;
            }
            else if (this.comboBoxRepaymentFrequency.SelectedIndex == 4)
            {
                this.loan.RepaymentFrequency = 12;
            }

            this.hScrollBarDurationInMonths.LargeChange = this.hScrollBarDurationInMonths.SmallChange = this.loan.RepaymentFrequency;

            this.loan.NumberOfRefunds = RegulationOfNumbersOfRefunds(this.loan.NumberOfRefunds, this.loan.RepaymentFrequency, false);
            UpdateIHM();
        }

        private int RegulationOfNumbersOfRefunds(int _numberOfRefundsNotRegulated, int _repaymentFrequency, bool hasAForcedDelta)
        {
            int delta = 0;
            if ((_numberOfRefundsNotRegulated / _repaymentFrequency == 0) || hasAForcedDelta)
            {
                delta = 1;
            }
            return (_numberOfRefundsNotRegulated / _repaymentFrequency + delta) * _repaymentFrequency;
        }

        private void UpdateIHM()
        {
            // borrowedCapital
            this.textBoxBorrowedCapital.Text = this.loan.BorrowedCapital.ToString();

            //numberOfRefunds
            if (this.loan.NumberOfRefunds > this.numericUpDownDurationInMonths.Maximum)
            {
                this.loan.NumberOfRefunds = (int)this.numericUpDownDurationInMonths.Maximum;
            }
            else
            {
                int v = this.loan.NumberOfRefunds;
                this.hScrollBarDurationInMonths.Value = v;
                this.numericUpDownDurationInMonths.Value = v;
            }

            //repaymentFrequency
            if (this.loan.RepaymentFrequency == 1)
            {
                this.comboBoxRepaymentFrequency.SelectedIndex = 0;
            }
            else if (this.loan.RepaymentFrequency == 2)
            {
                this.comboBoxRepaymentFrequency.SelectedIndex = 1;
            }
            else if (this.loan.RepaymentFrequency == 3)
            {
                this.comboBoxRepaymentFrequency.SelectedIndex = 2;
            }
            else if (this.loan.RepaymentFrequency == 6)
            {
                this.comboBoxRepaymentFrequency.SelectedIndex = 3;
            }
            else if (this.loan.RepaymentFrequency == 12)
            {
                this.comboBoxRepaymentFrequency.SelectedIndex = 4;
            }

            //interestRate
            if (this.loan.InterestRate == 0.07)
            {
                this.radioButtonRate7.Checked = true;
            }
            else if (this.loan.InterestRate == 0.08)
            {
                this.radioButtonRate8.Checked = true;
            }
            else if (this.loan.InterestRate == 0.09)
            {
                this.radioButtonRate9.Checked = true;
            }
            this.labelAmountDisplay.Text = loan.LoanAmount().ToString();
            this.labeLNumberOfRefundsInt.Text = loan.NumberOfRefundsInt().ToString();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (this.textBoxBorrowedCapital.Text.Length == 0)
            {
                errorProviderCheckBorrowedCapital.SetError(this.textBoxBorrowedCapital, "Ce champ est obligatoire");
            }
            else
            {
                this.labelAmountDisplay.Text = loan.LoanAmount().ToString();
                this.labeLNumberOfRefundsInt.Text = loan.NumberOfRefundsInt().ToString();
            }
        }

        private void radioButtonRate7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRate7.Checked)
            {
                this.loan.InterestRate = double.Parse(this.radioButtonRate7.Text) / 100;
            }
            else if (this.radioButtonRate8.Checked)
            {
                this.loan.InterestRate = double.Parse(this.radioButtonRate8.Text) / 100;
            }
            else if (this.radioButtonRate9.Checked)
            {
                this.loan.InterestRate = double.Parse(this.radioButtonRate9.Text) / 100;
            }
            UpdateIHM();
        }

        private void textBoxBorrowedCapital_TextChanged(object sender, EventArgs e)
        {

            if (this.textBoxBorrowedCapital.Text.Length > 10)
            {
                this.textBoxBorrowedCapital.Text = "";
                this.errorProviderCheckBorrowedCapital.SetError(this.textBoxBorrowedCapital, "Veuillez saisir un nombre de 10 chiffres au maximum");
                this.buttonValidate.Enabled = false;
                this.textBoxBorrowedCapital.Focus();
            }
            else
            {
                this.errorProviderCheckBorrowedCapital.SetError(this.textBoxBorrowedCapital, "");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            loan = new LoanRepayment(1, 1, 1, 0.07d);
            UpdateIHM();
            this.textBoxName.Text = "";
            this.labelAmountDisplay.Text = "";
            this.labeLNumberOfRefundsInt.Text = "1";
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (!CL_CheckButtons.CheckButtons.CheckName(this.textBoxName.Text))
            {
                this.textBoxName.Text = string.Empty;
            }
        }


    }
}


