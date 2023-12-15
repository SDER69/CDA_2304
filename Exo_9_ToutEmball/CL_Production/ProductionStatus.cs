using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CrateProduction
{
    internal class ProductionStatus
    {
        public enum Status
        {
            ProductionWaitingToStart,
            ProductionStarted,
            ProductionSuspended,
            ProductionCompleted
        }
    }
}
