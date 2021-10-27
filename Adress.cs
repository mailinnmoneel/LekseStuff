using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekseStuff
{
    class Adress
    {
       public string StreetName;
       public int StreetNo;
       public int PostNo;
       public string PostPlace;
        public string FullAdress;

        public Adress(string streetname, int streetno, int postno, string postplace)
        {
            StreetName = streetname;
            StreetNo = streetno;
            PostNo = postno;
            PostPlace = postplace;
            FullAdress = " Gatenavn " + streetname + " Gatenummer " + streetno + " Postnummer " + postno + " Poststed " + postplace;
        }
    }
}
