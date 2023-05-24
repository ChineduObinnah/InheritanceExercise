using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptiles: Animal
    {
        public bool HasVenom { get; set; }

        public string Location { get; set; }    

        public bool CanSwim { get; set; }

        public int NumofTeett { get; set; } 
    }
}
