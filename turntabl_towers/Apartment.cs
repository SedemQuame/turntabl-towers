using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    abstract class Apartment
    {
        int floorNumber;
        string doorNumber;
        string apartmentType;
        List<Person> listOfResidents;
        Bell doorBell;

        //constructor
        protected Apartment(int floorNumber, string doorNumber, string apartmentType, List<Person> listOfResidents, Bell doorBell)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.apartmentType = apartmentType;
            this.listOfResidents = listOfResidents;
            this.doorBell = doorBell;
        }

        //tostring
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
