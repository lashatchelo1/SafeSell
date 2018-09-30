using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeSell.Classes
{
    public class DbSim
    {
        public static List<Owner> ownerDb;
        public static List<Vehicle> vehicleDb;
        public static List<Estate> estateDb;

        public DbSim()
        {
            ownerDb = new List<Owner> { Owner.DefaultOwner };
            vehicleDb = new List<Vehicle> { Vehicle.DefaultVehicle };
            estateDb = new List<Estate> { Estate.DefaultEstate };
        }

        public static Owner GetOwner(string PersonalId)
        {
            Owner result = (from owner in ownerDb where owner.PersonalId == PersonalId select owner).DefaultIfEmpty(null).Single();

            return result;
        }

        public static List<Estate> OwnedEstates(string OwnerId)
        {
            List<Estate> result = (from est in estateDb where est.OwnerId == OwnerId select est).DefaultIfEmpty(null).ToList();

            return result;
        }

        public static Estate GetEstate(string CadastrialCode)
        {
            Estate result = (from est in estateDb where est.CadastrialCode == CadastrialCode select est).DefaultIfEmpty(null).Single();

            return result;
        }

        public static List<Vehicle> OwnedVehicles(string OwnerId)
        {
            List<Vehicle> result = (from veh in vehicleDb where veh.OwnerId == OwnerId select veh).DefaultIfEmpty(null).ToList();

            return result;
        }
    }
}
