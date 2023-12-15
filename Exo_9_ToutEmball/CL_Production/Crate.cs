using CL_Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CrateProduction
{
    internal class Crate
    {
        // Attributes
        private bool inGoodOrder;
        private DateTime productionDate;
 

        // Getters and setters
        public bool InGoodOrder { get => inGoodOrder; }
        public DateTime ProductionDate { get => productionDate;  }

        // Constructors
        public Crate(bool _inGoodOrder, DateTime _productionDate)
        {
            this.inGoodOrder = _inGoodOrder;
            this.productionDate = _productionDate;
        }

        public Crate(Crate crateToCopy)
           : this(crateToCopy.inGoodOrder,crateToCopy.ProductionDate)
        {

        }

        // Methods
        public override string ToString()
        {
            return "Crate in good order : " + this.inGoodOrder.ToString() + "\n\r" +
                    "Date and time of the production : " + this.productionDate.ToShortDateString() + "\n\r";
        }

        public override bool Equals(object? obj)
        {
            return obj is Crate crate &&
                   inGoodOrder == crate.inGoodOrder &&
                   productionDate == crate.productionDate &&
                   InGoodOrder == crate.InGoodOrder &&
                   ProductionDate == crate.ProductionDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(inGoodOrder, productionDate, InGoodOrder, ProductionDate);
        }

      







    }
}
