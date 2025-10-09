using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    //Open-Closed principle states that entities should be open for extension, but closed for modification. Using an interface like this we can extend functionality without modidfying existing ones.
    //Interface segregation principle states that "clients should not be forced to depend upon interfaces that they do not use.". In other words, our interface do not declare anything unused or further inherit interfaces which would be irrelevant to the factoriser itself.
    public interface IFactoriser
    {
        void DoFactorTen(int value);
    }
}
