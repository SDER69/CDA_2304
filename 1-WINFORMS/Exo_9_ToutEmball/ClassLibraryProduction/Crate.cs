using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    public class Crate
    {
        // Attributes
        private bool isInGoodOrder;
        private DateTime productionDate;


        // Getters and setters
        public bool IsInGoodOrder { get => isInGoodOrder; }
        public DateTime ProductionDate { get => productionDate; }

        // Constructors
        public Crate(bool _isInGoodOrder, DateTime _productionDate)
        {
            this.isInGoodOrder = _isInGoodOrder;
            this.productionDate = _productionDate;
        }

        public Crate(Crate crateToCopy)
           : this(crateToCopy.isInGoodOrder, crateToCopy.ProductionDate)
        {

        }

        // Methods
        public override string ToString()
        {
            return "Crate in good order : " + this.isInGoodOrder.ToString() + "\n\r" +
                    "Date and time of the production : " + this.productionDate.ToShortDateString() + "\n\r";
        }

        public override bool Equals(object? obj)
        {
            return obj is Crate crate &&
                   isInGoodOrder == crate.isInGoodOrder &&
                   productionDate == crate.productionDate &&
                   IsInGoodOrder == crate.IsInGoodOrder &&
                   ProductionDate == crate.ProductionDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(isInGoodOrder, productionDate, isInGoodOrder, ProductionDate);
        }
    }
}
