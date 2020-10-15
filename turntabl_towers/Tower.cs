using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Tower
    {
        string blockName;
        string blockLocation;
        static int numberOfFloors = 12;
        //Collections
        List<Floor> floorList;

        //Accessors
        public string BlockName { get => blockName; set => blockName = value; }
        public string BlockLocation { get => blockLocation; set => blockLocation = value; }
        public int NumberOfFloors { get => numberOfFloors; set => numberOfFloors = value; }
        internal List<Floor> FloorList { get => floorList; set => floorList = value; }


        //Constructor
        public Tower(string blockName, string blockLocation)
        {
            this.blockName = blockName;
            this.blockLocation = blockLocation;
            //create turntabl floors
            this.constructFloors();
        }
        void constructFloors()
        {
            this.floorList = new List<Floor>(numberOfFloors);
            //creating n number of floors.

            for (int i = 0; i < numberOfFloors; i++)
            {
                //Floor numbers start from 0 to 11.
                floorList.Add(new Floor(i));
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
