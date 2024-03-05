using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfazes
{
    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow";
        }
    }
}
