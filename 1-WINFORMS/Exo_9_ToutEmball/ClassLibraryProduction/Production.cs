using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    public class Production
    {
        // Attributes
        private string productionName;
        private readonly int numberOfCratesToProduce;
        private readonly int numberOfCratesProducedPerHour;
        private char productionType;
        private ProductionStatus status;
        private List<Crate> producedCrates;
        private Thread thread;

        private Random r;

        //Events
        public delegate void DelegateCrateProductionInfo(int numberOfCratesProduced, int target,Production p);
        public event DelegateCrateProductionInfo NewCrateProduced;
    
        // Getters and setters
        public string ProductionName { get => productionName; private set => productionName = value; }

        public char ProductionType { get => productionType; private set => productionType = value; }

        public int NumberOfCratesToProduce => numberOfCratesToProduce;

        public int NumberOfCratesProducedPerHour => numberOfCratesProducedPerHour;

        public ProductionStatus Status { get => status; private set => status = value; }
        public List<Crate> ProducedCrates { get => producedCrates; private set => producedCrates = value; }

        // Constructors
        public Production(string _productionName, int _numberOfCratesToProduce, char _productionType)
        {
            this.productionName = _productionName;
            this.numberOfCratesToProduce = _numberOfCratesToProduce;
            this.productionType = _productionType;
            this.producedCrates = new List<Crate>();
            this.status = ProductionStatus.ProductionWaitingToStart;
            r = new Random();
            thread = new Thread(new ThreadStart(Run));
            this.thread.Start();
        }

        public void Run()
        {
            while (this.NumberOfGoodCratesProduced() != this.numberOfCratesToProduce)
            {
                if (this.status == ProductionStatus.ProductionStarted)
                {
                    AddCrate();
                }
                Thread.Sleep(100);
            }
            this.status = ProductionStatus.ProductionCompleted;
        }

        public Production(Production productionToCopy)
            : this(productionToCopy.ProductionName, productionToCopy.numberOfCratesToProduce, productionToCopy.productionType)
        {

        }

        // Methods
        public override string ToString()
        {
            return "Name : " + this.productionName + "\n\r" +
                   "Number of crates to produce : " + this.numberOfCratesToProduce + "\n\r" +
                   "Number of good crates to produce : " + this.NumberOfGoodCratesProduced() + "\n\r" +
                   "Production type : " + this.productionType + "\n\r";

        }
        public override bool Equals(object? obj)
        {
            return obj is Production production &&
                   productionName == production.productionName &&
                   numberOfCratesToProduce == production.numberOfCratesToProduce &&
                   productionType == production.productionType &&
                   ProductionName == production.ProductionName &&
                   ProductionType == production.ProductionType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(productionName, numberOfCratesToProduce, productionType, ProductionName, ProductionType);
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
            return this.status == ProductionStatus.ProductionCompleted;
        }

        public bool StartProduction()
        {

            if (this.status == ProductionStatus.ProductionWaitingToStart || this.status == ProductionStatus.ProductionSuspended)
            {
                this.status = ProductionStatus.ProductionStarted;
                return true;
            }
            return false;
        }

        public bool SuspendProduction()
        {
            if (this.status == ProductionStatus.ProductionStarted)
            {
                this.status = ProductionStatus.ProductionSuspended;
                return true;
            }
            return false;
        }

        public bool AchievedProductionTarget()
        {
            return this.producedCrates.Count == this.numberOfCratesToProduce;
        }

        public void AddCrate()
        {
            int val = r.Next(1, 10);
            Crate crate = new Crate((val != 1), DateTime.Now);
            this.producedCrates.Add(crate);
            NewCrateProduced(this.NumberOfGoodCratesProduced(), this.numberOfCratesToProduce,this);
        }

        public int NumberOfGoodCratesProduced()
        {
            //return this.producedCrates.Count;
            int count = 0;
            //foreach(Crate c in this.producedCrates)
            //{
            //    if (c.IsInGoodOrder)
            //    {
            //        count++;
            //    }
            //}
            count = this.producedCrates.FindAll(c => c.IsInGoodOrder).Count;
            return count;
        }
    }      
}
