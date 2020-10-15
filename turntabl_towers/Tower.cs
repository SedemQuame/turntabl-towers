using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Tower
    {
        string blockName;
        string blockLocation;
        int numberOfFloors;
        //Collections
        List<Floor> floorList = new List<Floor>();

        //Accessors
        public string BlockName { get => blockName; set => blockName = value; }
        public string BlockLocation { get => blockLocation; set => blockLocation = value; }
        public int NumberOfFloors { get => numberOfFloors; set => numberOfFloors = value; }

        //Constructor
        public Tower(string blockName, string blockLocation, int numberOfFloors, List<Floor> floorList)
        {
            this.blockName = blockName;
            this.blockLocation = blockLocation;
            this.numberOfFloors = numberOfFloors;
            this.floorList = floorList;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
