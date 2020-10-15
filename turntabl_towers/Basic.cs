using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Basic : Apartment
    {
        static string apartmentType = "Basic";

        public Basic(int floorNumber, string doorNumber, List<Person> listOfResidents) : base(floorNumber, doorNumber, listOfResidents)
        {
        }

        public override bool respondToBell()
        {
            throw new NotImplementedException();
        }

        public override void constructApartment()
        {
            throw new NotImplementedException();
        }
    }
}
