using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfazes
{
    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Woof";
        }
    }
}
