using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_PDomainPersistance
{
    public interface IPersistanceForEgg
    {
        int Insert(StructEgg sEgg);

        bool Update(StructEgg sEgg);

        StructEgg Select(int id);
        bool Delete(int id);
    }
}
