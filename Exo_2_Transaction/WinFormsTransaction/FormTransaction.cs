using System.Runtime.CompilerServices;

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
                if (box.Text.Length == 0)
                {
                    this.errorProvider1.SetError(box, "Champ obligatoire");
                }
                else if (!CL_VerifTransaction.VerifNom(box.Text) || box.Text.Length > 30)
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un nom valide");
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
                    this.errorProvider1.SetError(box, "Le montant est invalide");
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
                    this.errorProvider1.SetError(box, "Le code postal est invalide");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null)
            {
                this.textBoxNom.Text = "";
                this.textBoxDate.Text = "";
                this.textBoxMontant.Text = "";
                this.textBoxCodePostal.Text = "";
            }
        }

        /*private void ChampVide(string champ)
        {
            if (champ == "")
            {
               this.errorProvider1.SetError(this.textBoxNom, "Champ obligatoire");
            }

        }*/
}
    }