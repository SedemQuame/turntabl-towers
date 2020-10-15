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

        //use events here.
        abstract public void answerDoorBell();

        //return greeting.
        abstract public string greeting();
    }
}
