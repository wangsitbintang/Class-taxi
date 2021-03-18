using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine (" Drive Name      : {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine(" On Duty     : Yes", OnDuty); 
            }
            else
            {
                Console.WriteLine(" On Duty     : No", OnDuty);
            }

            Console.WriteLine(" Number Of Passenger : {0}\n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai menjemput penumpang", DriverName);
        }
        
    }

}
