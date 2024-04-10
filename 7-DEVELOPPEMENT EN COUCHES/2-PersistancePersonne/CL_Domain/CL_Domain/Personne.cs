namespace CL_Domain
{
    public class Personne
    {
        // Attributs
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private PersistancePersonne persistance;

        // Getters et setters
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public PersistancePersonne Persistance { get => persistance; set => persistance = value; }


        // Constructeurs
        public Personne() { }
        public Personne(string _nom, string _prenom, int _age)
        {
            this.id = -1;
            this.nom = _nom;
            this.prenom = _prenom;
            this.age = _age;
        }

        // Méthodes
        public void Save()
        {
            if (persistance != null)
            {
                if (id == -1)
                {
      
                    this.id = persistance.Insert(this);  
                }
                else
                {
                    throw new Exception("Persistance non defini");
                }

            }



        }
    }
}