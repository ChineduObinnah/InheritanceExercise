using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {

        // Create a class Animal
        // give this class 4 members that all Animals have in common


        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public Animal() { }

        public int legs { get; set; }

        public bool tail { get; set; }
        
        public string diet { get; set; }

        public string name { get; set; }    
    }
}
