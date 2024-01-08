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
                if(!VerifContact.VerifDateFormat(box.Text))
                {
                    this.errorProvider1.SetError(box, "Veuillez saisir une date valide");
                }

                else { }
            
            }
        }
    }
}