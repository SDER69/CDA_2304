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
                    this.errorProvider1.SetError(this.textBoxNom, "Champ obligatoire");
                }
                else if (!CL_VerifTransaction.VerifNom(box.Text) || box.Text.Length > 30)
                {
                    this.errorProvider1.SetError(this.textBoxNom, "Veuillez saisir un nom valide");
                }
                else
                {
                    this.errorProvider1.SetError(this.textBoxNom, "");
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
                    this.errorProvider1.SetError(this.textBoxDate, "Veuillez saisir une date valide");
                }

                else if (!CL_VerifTransaction.VerifDateSuperieure(box.Text))
                {
                    this.errorProvider1.SetError(this.textBoxDate, "Veuillez saisir une date supérieure à la date du jour");
                }

                else
                {
                    this.errorProvider1.SetError(this.textBoxDate, "");
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
                    this.errorProvider1.SetError(this.textBoxMontant, "Le montant est invalide");
                }
                else
                {
                    this.errorProvider1.SetError(this.textBoxMontant, "");
                }
            }

        }

        private void textBoxCodePostal_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box != null)
            {
                if (!CL_VerifTransaction.VerifCodePostal(this.Text))
                {
                    this.errorProvider1.SetError(this.textBoxCodePostal, "Le code postal est invalide");
                }
                else
                {
                    this.errorProvider1.SetError(this.textBoxCodePostal, "");
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {

        }


    }
}