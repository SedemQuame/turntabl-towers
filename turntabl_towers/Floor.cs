using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace turntabl_towers
{
    class Floor
    {
        int floorNumber;
        List<Apartment> apartmentList = new List<Apartment>();
        static int numberOfApartmentsPerFloor = 6;


        //Accessors
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public List<Apartment> ApartmentList { get => apartmentList; set => apartmentList = value; }


        //Constructor
        public Floor(int floorNumber, List<Apartment> apartmentList)
        {
            this.floorNumber = floorNumber;
            this.apartmentList = apartmentList;
        }
    }
}
