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
            this.Name = name;
            this.JobType = jobType;
        }

        public string Name { get => name; set => name = value; }
        public string JobType { get => jobType; set => jobType = value; }


        //return greeting.
        abstract public string greeting();

        
    }
}
