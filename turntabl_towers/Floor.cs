﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace turntabl_towers
{
    class Floor
    {
        int floorNumber;
        List<Apartment> apartmentList;
        static int numberOfApartmentsPerFloor = 6;

        //Accessors
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public List<Apartment> ApartmentList { get => apartmentList; set => apartmentList = value; }

        //Constructor
        public Floor(int floorNumber)
        {
            this.floorNumber = floorNumber;
            //Console.WriteLine("Apartments.");
            this.constructApartments();
        }

        void constructApartments()
        {
            this.apartmentList = new List<Apartment>(numberOfApartmentsPerFloor);
            //randomly create grand, silver and basic  apartments.
            int minValue = 0, maxValue = 10;

            for (int i = 0; i < numberOfApartmentsPerFloor; i++)
            {
                Random rnd = new Random();
                int rndValue = rnd.Next(minValue, maxValue);
                string denotation = "";

                if (rndValue < 6)
                {
                    apartmentList.Add(new Basic(this.floorNumber, (this.floorNumber.ToString() + i.ToString()), "Basic ",  new List<Person>()));
                    denotation = "B";
                }
                else if (rndValue < 9)
                {
                    apartmentList.Add(new Silver(this.floorNumber, (this.floorNumber.ToString() + i.ToString()), "Silver", new List<Person>()));
                    denotation = "S";
                }
                else
                {
                    apartmentList.Add(new Grand(this.floorNumber, (this.floorNumber.ToString() + i.ToString()), "Grand ", new List<Person>()));
                    denotation = "G";
                }
                Console.Write($"| {denotation}-{(this.floorNumber.ToString() + i.ToString())} |");
            }
        }
    }
}
