using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeSell.Classes
{
    [Serializable]
    public class Vehicle
    {
        public string OwnerId { get; set; }
        public string VinCode { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int AccidentCount { get; set; }

        public static Vehicle DefaultVehicle
        {
            get
            {
                return new Vehicle()
                {
                    OwnerId = "1234567890",
                    VinCode = "000100020003",
                    Maker = "Honda",
                    Model = "Civic TypeR 2018",
                    AccidentCount = 0
                };
            }
        }

        public override string ToString()
        {
            return VinCode;
        }
    }
}
