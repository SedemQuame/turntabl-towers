using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Grand:Apartment
    {
        static bool respondToDoorBell = true;
        static string apartmentType = "Grand";

        //Accessors
        public static bool RespondToDoorBell { get => respondToDoorBell; set => respondToDoorBell = value; }
        public string ApartmentType { get => apartmentType; set => apartmentType = value; }

        //Constructor
        public Grand(int floorNumber, string doorNumber, List<Person> listOfResidents):base(floorNumber, doorNumber, listOfResidents)
        {
            listOfResidents.Add(new Butler("Alfred (Batman)", "Butler", "apartment#"));
        }

        public override bool respondToBell()
        {
            throw new NotImplementedException();
        }

        public override void constructApartment()
        {
            throw new NotImplementedException();
        }

        public override void populateWithResidents()
        {
            int minValue = 0, maxValue = 3;
            Random rnd = new Random();
            int rndValue = rnd.Next(minValue, maxValue);

            for (int i = 0; i < rndValue; i++)
            {
                base.ListOfResidents.Add(new Resident("resident_name", "engineer", "residence"));

            }

            throw new NotImplementedException();
        }

    }
}
