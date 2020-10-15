using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Resident:Person
    {
        //? why did i add residence in the first place
        //(¬_¬ )(¬_¬ )(¬_¬ )
        string residence;

        public string Residence { get => residence; set => residence = value; }

        public Resident(string name, string jobType, string residence):base(name, jobType)
        {
            Residence = residence;
        }

        public override void answerDoorBell()
        {
            throw new NotImplementedException();
        }

        public override string greeting()
        {
            throw new NotImplementedException();
        }
    }
}
