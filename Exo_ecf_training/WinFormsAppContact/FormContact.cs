using CL_Contact;
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


    }
}