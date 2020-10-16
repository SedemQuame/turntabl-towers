﻿using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Basic : Apartment
    {
        static string apartmentType = "Basic";

        public static string ApartmentType { get => apartmentType; set => apartmentType = value; }

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

        public override void populateWithResidents()
        {
            int minValue = 0, maxValue = 5;
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
