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

        //accessor
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public string DoorNumber { get => doorNumber; set => doorNumber = value; }
        internal List<Person> ListOfResidents { get => listOfResidents; set => listOfResidents = value; }
        internal Bell DoorBell { get => doorBell; set => doorBell = value; }

        //constructor
        protected Apartment(int floorNumber, string doorNumber, List<Person> listOfResidents)
        {
            this.FloorNumber = floorNumber;
            this.DoorNumber = doorNumber;
            this.ListOfResidents = listOfResidents;
            this.DoorBell = new Bell();
        }

        abstract public void constructApartment();

        //tostring
        public override string ToString()
        {
            return base.ToString();
        }

        abstract public bool respondToBell();

        abstract public void populateWithResidents();
    }
}
