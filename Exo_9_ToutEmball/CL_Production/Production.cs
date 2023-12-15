using CL_CrateProduction;
using System.Transactions;

namespace CL_Production
{
    public class Production
    {
        // Attributes
        private string productionName;
        private readonly int numberOfCratestoProduce;
        private char productionType;
        private ProductionStatus.Status status;
        private List<Crate> producedCrates;

        private Random r;

        // Getters and setters
        public string ProductionName { get => productionName; private set => productionName = value; }

        public char ProductionType { get => productionType; private set => productionType = value; }

        // Constructors
        public Production(string _productionName, int _numberOfCratesToProduce, char _productionType)
        {
            this.productionName = _productionName;
            this.numberOfCratestoProduce = _numberOfCratesToProduce;
            this.productionType = _productionType;   
            r= new Random();
        }

        public Production(Production productionToCopy)
            : this(productionToCopy.ProductionName, productionToCopy.numberOfCratestoProduce, productionToCopy.productionType)
        {

        }

        // Methods
        public override string ToString()
        {
            return "Name : " + this.productionName + "\n\r" +
                   "Number of crates to produce : " + this.numberOfCratestoProduce + "\n\r" +
                   "Production type : " + this.productionType + "\n\r";

        }
        public override bool Equals(object? obj)
        {
            return obj is Production production &&
                   productionName == production.productionName &&
                   numberOfCratestoProduce == production.numberOfCratestoProduce &&
                   productionType == production.productionType &&
                   ProductionName == production.ProductionName &&
                   ProductionType == production.ProductionType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(productionName, numberOfCratestoProduce, productionType, ProductionName, ProductionType);
        }

        //public double ErrorRateOfLastHour()
        //{
            
         
        //}

        //public double ErrorRateFromStart()
        //{
        //   for (int i = 0;i < producedCrates.Count; i++)
        //    {
        //        Crate crate = producedCrates[i];
        //        if(crate.InGoodOrder == true)
        //        {

        //        }
        //    }
            
        //}

        public bool IsComplete()
        {
            return this.status == ProductionStatus.Status.ProductionCompleted;  
        }

        public bool StartProduction() 
        {
            
            if(this.status == ProductionStatus.Status.ProductionWaitingToStart || this.status == ProductionStatus.Status.ProductionSuspended)
            {
                this.status = ProductionStatus.Status.ProductionStarted;
                return true;
            }
            return false;
        }

        public bool SuspendProduction()
        {
            if (this.status == ProductionStatus.Status.ProductionStarted)
            {
                this.status = ProductionStatus.Status.ProductionSuspended;
                return true;
            }
            return false;
        }

        public bool AchievedProductionTarget()
        {
            return this.producedCrates.Count == this.numberOfCratestoProduce;
        }

        public void AddCrate()
        {
            int val = r.Next(1, 10);

            Crate crate = new Crate((val!=1), DateTime.Now);
            this.producedCrates.Add(crate);
            
            
        }












    }
}