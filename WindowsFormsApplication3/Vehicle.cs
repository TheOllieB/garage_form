using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineSize { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Make, Model, EngineSize, Price);
        }
    }
}
