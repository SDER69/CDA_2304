using CL_Contact;
using CL_VerifContact;
using System.Transactions;

namespace WinFormsAppContact
{
    public partial class FormContact : Form
    {
        // declaration contact
        Contact contact;

        // Getter et setter       
        public Contact Contact { get => contact; private set => contact = value; }

        // Contructeurs
        public FormContact()
        {
            InitializeComponent();
            this.contact = null;
        }

        public FormContact(Contact _contact)
        {
            InitializeComponent();
            this.contact = _contact;
            this.textBoxNom.Text = _contact.Nom;
            this.textBoxPrenom.Text = _contact.Prenom;
            this.textBoxDateDeNaissance.Text = _contact.DateDeNaissance.ToShortDateString();
            this.textBoxAdressePostal.Text = _contact.AdressePostal;
            this.textBoxEmail.Text = _contact.AdresseMail;
            this.textBoxCodePostal.Text = _contact.CodePostal.ToString();
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (box != null)
            {
                if (!VerifContact.VerifNom(box.Text))
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

        private void textBoxPrenom_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (box != null)
            {
                if (!VerifContact.VerifPrenom(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un prénom valide");
                }

                else if (box.Text.Length > 30)
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un prénom de 30 caractères maximum");
                }

                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }

        }

        private void textBoxDateDeNaissance_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (!VerifContact.VerifDateFormat(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une date valide");
                }

                else if (!VerifContact.VerifMajorite(Convert.ToDateTime(box.Text)))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un âge supérieur ou égal à 18");
                }

                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void textBoxAdressePostal_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (box.Text.Length > 250)
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une adresse valide limitée à 250 caractères");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (!VerifContact.VerifEmail(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une adresse email valide");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }

        }

        private void textBoxCodePostal_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (!VerifContact.VerifCodePostal(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un code postal valide");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void textBoxTel_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (!VerifContact.VerifTel(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir un numéro de téléphone valide");
                }
                else
                {
                    this.errorProvider1.SetError(box, "");
                }
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (btn != null)
            {
                if (this.textBoxNom.Text.Length == 0
                    || !VerifContact.VerifNom(this.textBoxNom.Text)
                    || (this.textBoxPrenom.Text.Length == 0)
                    || !VerifContact.VerifPrenom(this.textBoxPrenom.Text)
                    || (this.textBoxDateDeNaissance.Text.Length == 0)
                    || !VerifContact.VerifDateFormat(this.textBoxDateDeNaissance.Text)
                    || !VerifContact.VerifMajorite(Convert.ToDateTime(this.textBoxDateDeNaissance.Text))
                    || (this.textBoxEmail.Text.Length == 0)
                    || !VerifContact.VerifEmail(this.textBoxEmail.Text)
                    || (this.textBoxCodePostal.Text.Length == 0)
                    || !VerifContact.VerifCodePostal(this.textBoxCodePostal.Text)
                    || (this.textBoxTel.Text.Length == 0)
                    || !VerifContact.VerifTel(this.textBoxTel.Text)
                    )
                {
                    MessageBox.Show("Tous les champs sont obligatoires");
                }

                else
                {

                    this.contact = new Contact(
                    this.textBoxNom.Text, this.textBoxPrenom.Text,
                    Convert.ToDateTime(this.textBoxDateDeNaissance.Text),
                    this.textBoxAdressePostal.Text, this.textBoxEmail.Text,
                    Convert.ToInt32(this.textBoxCodePostal.Text),
                    this.textBoxTel.Text
                    );

                    this.DialogResult = DialogResult.OK;

                    string message = this.contact.ToString();
                    const string caption = "Inscription effectuée";
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

        private void buttonEffacer_Click(object sender, EventArgs e)
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
            this.textBoxPrenom.Text = "";
            this.textBoxDateDeNaissance.Text = "";
            this.textBoxAdressePostal.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxCodePostal.Text = "";
            this.textBoxTel.Text = "";
        }

       
    }
}

