using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Grand:Apartment
    {
        static bool respondToDoorBell = true;
        static string apartmentType = "Grand";

        Grand(int floorNumber, string doorNumber) :base(floorNumber, doorNumber)
        {
            this.listOfResidents.Add(new Butler("name", "job_type", "apartment#"));
            //add other residents here. 
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
