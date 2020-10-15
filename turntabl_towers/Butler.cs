using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Butler:Person
    {
        string apartmentNumber;

        public Butler(string name, string jobType, string apartmentNumber):base(name, jobType)
        {
            this.apartmentNumber = apartmentNumber;
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
