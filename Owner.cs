using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeSell.Classes
{
    [Serializable]
    public class Owner
    {
        public string PersonalId { get; set; }
        public string FullName { get; set; }
        public string[] OwnedVehiclesVins { get; set; }
        public string[] OwnedEstatesCadCodes { get; set; }

        public static Owner DefaultOwner
        {
            get
            {
                return new Owner()
                {
                    PersonalId = "1234567890",
                    FullName = "Mark Twain",
                    OwnedVehiclesVins = new string[]{ Vehicle.DefaultVehicle.VinCode },
                    OwnedEstatesCadCodes = new string[] { Estate.DefaultEstate.CadastrialCode }
                };
            }
        }

        public override string ToString()
        {
            return PersonalId;
        }
    }
}
