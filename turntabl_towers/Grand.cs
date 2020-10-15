using System;
using System.Collections.Generic;
using System.Text;

namespace turntabl_towers
{
    class Grand:Apartment
    {
        Grand(int floorNumber, string doorNumber, string apartmentType, List<Person> listOfResidents, Bell doorBell) :base(floorNumber, doorNumber, apartmentType, listOfResidents, doorBell)
        {
            listOfResidents.Add(new Butler("name", "job_type", "apartment#"));
            //add other residents here. 
        }

    }
}
