using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    abstract class Person
    {
        string name;
        string jobType;

        protected Person(string name, string jobType)
        {
            this.name = name;
            this.jobType = jobType;
        }


        //return greeting.
        abstract public string greeting();
    }
}
