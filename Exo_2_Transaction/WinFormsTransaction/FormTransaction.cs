using CL_VerifTransaction;
using System.Runtime.CompilerServices;
using CL_Transaction;
using System.Windows.Forms;

namespace WinFormsTransaction
{
    public partial class FormTransaction : Form
    {
        //declaration transaction
        Transaction transaction;

        // Getter et setter
        public Transaction Transaction { get => transaction; private set => transaction = value; }

        // Constructeurs
        public FormTransaction()
        {
            InitializeComponent();
            this.transaction = null;
        }

        public FormTransaction(Transaction _transaction)
        {
            InitializeComponent();
            this.transaction = _transaction;
            this.textBoxNom.Text = _transaction.Nom;
            this.textBoxDate.Text = _transaction.Date.ToShortDateString();
            this.textBoxMontant.Text = _transaction.Montant.ToString();
            this.textBoxCodePostal.Text = _transaction.CodePostal.ToString();
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            //TextBox box = (TextBox)sender;
            TextBox box = sender as TextBox;

            if (box != null)
            {
                if (!VerifTransaction.VerifNom(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un nom valide");
                }

                else if (box.Text.Length > 30)
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un nom de 30 caractères maximum");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (!VerifTransaction.VerifDateFormat(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une date valide");
                }

                else if (!VerifTransaction.VerifDateSuperieure(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une date supérieure à la date du jour");
                }

                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void textBoxMontant_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box != null)
            {
                if (!VerifTransaction.VerifMontant(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un montant valide");
                }

                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }

        }

        private void textBoxCodePostal_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box != null)
            {
                if (!VerifTransaction.VerifCodePostal(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un code postal valide");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != null)
            {
                if (this.textBoxNom.Text.Length == 0
                    || (this.textBoxDate.Text.Length == 0)
                    || (this.textBoxMontant.Text.Length == 0)
                    || (this.textBoxCodePostal.Text.Length == 0))
                {
                    MessageBox.Show("Le champ est obligatoire");
                }

                else
                {
                   
                        this.transaction = new Transaction(
                        this.textBoxNom.Text,
                        Convert.ToDateTime(this.textBoxDate.Text),
                        Convert.ToDouble(this.textBoxMontant.Text),
                        Convert.ToInt32(this.textBoxCodePostal.Text)
                        );

                    string message = this.transaction.ToString();
                    const string caption = "Validation effectuée";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        Effacer();

                    }
                }

            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null)
            {
                Effacer();
            }
        }

        private void Effacer()
        {
            this.textBoxNom.Text = "";
            this.textBoxDate.Text = "";
            this.textBoxMontant.Text = "";
            this.textBoxCodePostal.Text = "";

        }

        private void transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Fin de l'appliaction";
            const string caption = "Fin de l'application";
            var result1 = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result1 == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

