using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    class RSCaseClass: IRSCaseInterface
    {
        

        public String CreateDisRest(IDictionary hashMap)
        {
            return "createDisRest";
        }

        

        public String CreateRBDRest(IDictionary hashMap)
        {
            return "createRBDRest";
        }

        public String CreateRBDSSRest(IDictionary hashMap)
        {
            return "CreateRBDSSRest";
        }

    }
}
