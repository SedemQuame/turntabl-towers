using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Silver : Apartment
    {
        //static string apartmentType = "Silver";

        //public static string ApartmentType { get => apartmentType; set => apartmentType = value; }

        public Silver(int floorNumber, string doorNumber, string apartmentType, List<Person> listOfResidents) : base(floorNumber, doorNumber, apartmentType, listOfResidents)
        {
            //apartmentType = "Silver";
        }

        public override bool respondToBell()
        {
            /*refactor code to be used across the 3 instances of apartment*/
            //respond to bell ring event 10% of the time.
            int minValue = 0, maxValue = 10;
            Random rnd = new Random();
            int rndValue = rnd.Next(minValue, maxValue);

            return (rndValue <= 8);
        }

        public override void constructApartment()
        {
            throw new NotImplementedException();
        }

        public override void populateWithResidents()
        {
            int minValue = 0, maxValue = 10;
            Random rnd = new Random();
            int rndValue = rnd.Next(minValue, maxValue);

            for (int i = 0; i < rndValue; i++)
            {
                base.ListOfResidents.Add(new Resident("resident_name", "engineer", "residence"));

            }
        }
    }
}
