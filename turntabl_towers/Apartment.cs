using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    abstract class Apartment
    {
        int floorNumber;
        string doorNumber;
        List<Person> listOfResidents;
        Bell doorBell ;

        //constructor
        protected Apartment(int floorNumber, string doorNumber, List<Person> listOfResidents)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.listOfResidents = listOfResidents;
            this.doorBell = new Bell();
        }

        abstract public void constructApartment();

        //tostring
        public override string ToString()
        {
            return base.ToString();
        }

        abstract public bool respondToBell();
    }
}
