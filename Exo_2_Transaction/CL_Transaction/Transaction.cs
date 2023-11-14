namespace CL_Transaction
{
    public class Transaction
    {
             // Attributs
            private string nom;
            private DateTime date;
            private double montant;
            private int codePostal;

            // Getters et setters
            public string Nom { get => nom; private set => nom = value; }
            public DateTime Date { get => date; private set => date = value; }
            public double Montant { get => montant; private set => montant = value; }
            public int CodePostal { get => codePostal; private set => codePostal = value; }

            // Constructeurs
           

            public Transaction(string _nom,DateTime _date,double _montant,int _codePostal)
            {
                this.nom = _nom;
                this.date = _date;
                this.montant = _montant;
                this.codePostal = _codePostal;
            }

            public Transaction(Transaction transactionACopier)
                : this(transactionACopier.nom,transactionACopier.date,transactionACopier.montant,transactionACopier.codePostal)
            {
              
            }

            // Méthodes
           
            public override string ToString()
            {
                return "------------------------------------------ \n\r" +
                       "Nom : " + this.nom + "\n\r" +
                       "Date : " + this.date + "\n\r" +
                       "Montant : " + this.montant + "\n\r" +
                       "Code postal : " + this.codePostal;
            }

            public override bool Equals(object? obj)
            {
                return obj is Transaction transaction &&
                    nom == transaction.nom &&
                    date == transaction.date &&
                    montant == transaction.montant &&
                    codePostal == transaction.codePostal;
            }
                       

            public override int GetHashCode()
            {
                return HashCode.Combine(nom,date,montant,codePostal);
            }

        }
    }






