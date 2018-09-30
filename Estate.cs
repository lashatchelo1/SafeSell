using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeSell.Classes
{
    [Serializable]
    public class Estate
    {
        public string OwnerId { get; set; }
        public string CadastrialCode { get; set; }
        public string Address { get; set; }
        public int RoomCount { get; set; }
        public int AppArea { get; set; }
       
        public static Estate DefaultEstate
        {
            get
            {
                return new Estate()
                {

                    CadastrialCode = "001.002.003",
                    Address = "Vaja Pshavela Ave. 34",
                    RoomCount = 4,
                    AppArea = 82
                };
            }
        }

        public override string ToString()
        {
            return CadastrialCode;
        }
    }
}
