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
        List<Person> conciergeTeam;

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
            Console.WriteLine("Constructing TurnTabl Towers");
            Console.WriteLine("============================\n\n");
            this.constructFloors();
        }
        void constructFloors()
        {
            this.floorList = new List<Floor>(numberOfFloors);
            //creating n number of floors.

            for (int i = numberOfFloors; i > 0; i--)
            {
                //Floor numbers start from 0 to 11.

                Console.WriteLine($"============Floor #{i}==========");
                floorList.Add(new Floor(i));
                Console.WriteLine("\n==============================");
            }

            Console.WriteLine("\n\n=======================================");
            Console.WriteLine(" *** Turntabl Towers Grand Opening ***");
            Console.WriteLine("=======================================");
        }

        public void hireConciergePersonnel()
        {
            Console.WriteLine("Hiring a team of super duper concierge personnel");
        }

        public void takeTheRegister()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("|Apartment #      |   Type         |     Residents                                       ");
            Console.WriteLine("=========================================================================================");
            int i = 0;
            foreach (Floor floor in this.FloorList)
            {
                foreach (var apartment in floor.ApartmentList)
                {
                    i++;
                    if(i < 10)
                        Console.WriteLine($"|#{i}               |{apartment.ApartmentType}          |    {apartment.currentResidents()}                                      ");
                    else
                        Console.WriteLine($"|#{i}              |{apartment.ApartmentType}          |    {apartment.currentResidents()}                                      ");

                    Console.WriteLine("----------------------------------------------------------------------------------");
                }
            }
        }

        public void ringAllDoorbells()
        {
            Console.WriteLine("\n\n**** Ringing a Bell ****\n");

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
