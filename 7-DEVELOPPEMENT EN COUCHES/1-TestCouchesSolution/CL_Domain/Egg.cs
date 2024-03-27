using CL_PDomainPersistance;
using System.Runtime.CompilerServices;

namespace CL_Domain
{
    public class Egg
    {
        private float hauteurEnCms;
        private float largeurEnCms;
        private string typeChocolat;
        private int id;
        private IPersistanceForEgg persistance;

        public Egg(int _id)
        {
            this.hauteurEnCms = 0;
            this.largeurEnCms = 0;
            this.typeChocolat = "";
            this.id = _id;
        }

        public Egg(float _hauteurEnCms, float _largeurEnCms, string _typeChocolat, int _id)
        {
            this.hauteurEnCms = _hauteurEnCms;
            this.largeurEnCms = _largeurEnCms;
            this.typeChocolat = _typeChocolat;
            this.id = _id;
        }

        public Egg(float _hauteurEnCms, float _largeurEnCms, string _typeChocolat)
        {
            this.hauteurEnCms = _hauteurEnCms;
            this.largeurEnCms = _largeurEnCms;
            this.typeChocolat = _typeChocolat;
            this.id = -1;
        }

        public void Save()
        {
            if (persistance != null)
            {
                if (id == -1)
                {
                    StructEgg e = this.GetStruct();
                    this.id = persistance.Insert(e);
                }
                else
                {
                    StructEgg e = this.GetStruct();
                    bool ok = persistance.Update(e);
                }
            }
            else
            {
                throw new Exception("persitance non defini");
            }
        }

        public void Load()
        {
            if (persistance != null)
            {
                if (id == -1)
                {
                    StructEgg e = persistance.Select(id);
                    this.id = e.Id;
                    this.hauteurEnCms = e.HauteurEnCms;
                    this.largeurEnCms = e.LargeurEnCms;
                    this.typeChocolat = e.TypeChocolat;
                }
            }
        }

        public void Delete()
        {
            if (persistance != null)
            {
                if (id != -1)
                {
                    bool ok = persistance.Delete(id);
                }
            }
        }

        public StructEgg GetStruct()
        {
            StructEgg structEgg = new StructEgg();
            structEgg.Id = this.id;
            structEgg.HauteurEnCms = this.hauteurEnCms;
            structEgg.LargeurEnCms = this.largeurEnCms;
            structEgg.TypeChocolat = this.typeChocolat;
            return structEgg;
        }

        public void SetPersistance(IPersistanceForEgg persistanceActuelle)
        {
            persistance = persistanceActuelle;
        }
    }
}