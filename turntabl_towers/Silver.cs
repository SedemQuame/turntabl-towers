using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Silver : Apartment
    {
        static string apartmentType = "Silver";

        public Silver(int floorNumber, string doorNumber, List<Person> listOfResidents) : base(floorNumber, doorNumber, listOfResidents)
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
