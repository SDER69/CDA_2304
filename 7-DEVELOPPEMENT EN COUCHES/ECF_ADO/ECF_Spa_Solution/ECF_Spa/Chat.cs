using System.Numerics;

namespace ECF_Spa
{
    public class Chat
    {
        // Attributs
        private int numero_puce;
        private string nom;
        private int age;
        private int race;
        private PersistanceChat persistance;


        // Getters et setters
        public int Numero_puce { get => numero_puce; set => numero_puce = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Age { get => age; set => age = value; }
        public int Race { get => race; set => race = value; }
        public PersistanceChat Persistance { get => persistance; set => persistance = value; }
        


        // Constructeurs
        public Chat() { }

        public Chat(int _numero_puce,string _nom,int _age,int _race)
        {
            this.Numero_puce = _numero_puce;
            this.nom = _nom;
            this.age = _age;
            this.race = _race;
        }

        public void Save()
        {
            if (persistance != null)
            {
                    this.Numero_puce = persistance.Insert(this);
                }
                else
                {
                    throw new Exception("Persistance non defini");
                }

            }



        }
    }




