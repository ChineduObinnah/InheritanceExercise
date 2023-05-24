using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animal
    {
        public bool Flight { get; set; }

        public int NumberOfEggs { get; set; }

        public bool BirdOfPrey { get; set; }

        public bool IsNoctornal { get; set; }

    }
}
