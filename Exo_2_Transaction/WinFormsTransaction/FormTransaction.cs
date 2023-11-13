using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WinFormsTransaction
{
    public partial class FormTransaction : Form
    {
        //declaration transaction

        public FormTransaction()
        {
            InitializeComponent();
        }

        //public FormTransaction()
        //{
        //    InitializeComponent();
        //}

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            //TextBox box = (TextBox)sender;
            TextBox box = sender as TextBox;

            if (box != null)
            {
                if (!CL_VerifTransaction.VerifNom(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un nom valide");
                }

                else if(box.Text.Length > 30)
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
                if (!CL_VerifTransaction.VerifDateFormat(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une date valide");
                }

                else if (!CL_VerifTransaction.VerifDateSuperieure(box.Text))
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
                if (!CL_VerifTransaction.VerifMontant(box.Text))
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


                if (!CL_VerifTransaction.VerifCodePostal(box.Text))
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

                /*else if (this.textBoxNom.Text.Length == 0 && this.textBoxDate.Text.Length == 0 && this.textBoxMontant.Text.Length == 0 && this.textBoxCodePostal.Text.Length == 0)
                {
                    this.errorProvider1.SetError(this.textBoxNom, "Champ obligatoire");
                    this.errorProvider1.SetError(this.textBoxDate, "Champ obligatoire");
                    this.errorProvider1.SetError(this.textBoxMontant, "Champ obligatoire");
                    this.errorProvider1.SetError(this.textBoxCodePostal, "Champ obligatoire");
                    MessageBox.Show("Tous les champs sont obligatoires");
                }*/
               
                else
                {
                    string message = this.labelNom.Text + " : " + this.textBoxNom.Text + "\n"
                                     + this.labelDate.Text + " : " + this.textBoxDate.Text + "\n"
                                     + this.labelMontant.Text + " : " + this.textBoxMontant.Text + "\n"
                                     + this.labelCodePostal.Text + " : " + this.textBoxCodePostal.Text;
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
            else
            {
                e.Cancel = false;
                MessageBox.Show("Au revoir");
            }

        }
    }
}

