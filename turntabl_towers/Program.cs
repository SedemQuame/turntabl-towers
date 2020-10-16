using System;

namespace turntabl_towers
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] nameList = {"Sophie"};


            //Constructing turntabl towers, achimota branch.
            Tower turntabl = new Tower("Turntabl Towers", "Achimota");

            //Hire concierge personnel.
            turntabl.hireConciergePersonnel();

        }
    }
}
