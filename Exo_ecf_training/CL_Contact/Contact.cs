namespace CL_Contact
{
    public class Contact
    {
        // Attributs
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string adressePostal;
        private string adresseMail;
        private int codePostal;
        private string numTel;

        // Getters et setters
        public string Nom { get => nom; private set => nom = value; }
        public string Prenom { get => prenom; private set => prenom = value; }
        public DateTime DateDeNaissance { get => dateDeNaissance; private set => dateDeNaissance = value; }
        public string AdressePostal { get => adressePostal; set => adressePostal = value; }
        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public int CodePostal { get => codePostal; private set => codePostal = value; }
        public string NumTel { get => numTel; private set => numTel = value; }
        

        // Constructeurs
        public Contact()
        { }

        public Contact(string _nom,string _prenom,DateTime _dateDeNaissance,string _adressePostal, string _adresseMail,int _codePostal,string _numTel)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.dateDeNaissance = _dateDeNaissance;
            this.adressePostal = _adressePostal;
            this.adresseMail = _adresseMail;
            this.codePostal = _codePostal;
            this.numTel = _numTel;
        }

        public Contact(Contact contactACopier)
            : this(contactACopier.nom,contactACopier.Prenom,contactACopier.dateDeNaissance,contactACopier.adressePostal, contactACopier.adresseMail,contactACopier.codePostal, contactACopier.numTel)
        {

        }

        // Méthodes
        public override string ToString()
        {
            return "Nom : " + this.nom + "\n\r" +
                   "Prénom : " + this.prenom + "\n\r" +
                   "Date de naissance : " + this.dateDeNaissance.ToShortDateString() + "\n\r" +
                   "Adresse postal : " + this.adressePostal + "\n\r" +
                   "Email : " + this.adresseMail + "\n\r" +
                   "Code postal : " + this.codePostal +
                   "Numéro de téléphone : " + this.numTel + "\n\r";
        }

        public override bool Equals(object? obj)
        {
            return obj is Contact contact &&
                   nom == contact.nom &&
                   prenom == contact.prenom &&
                   dateDeNaissance == contact.dateDeNaissance &&
                   adressePostal == contact.adressePostal &&
                   adresseMail == contact.adresseMail &&
                   codePostal == contact.codePostal &&
                   numTel == contact.numTel;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nom, prenom, dateDeNaissance, adressePostal, adresseMail, codePostal, numTel);
        }
    }
}