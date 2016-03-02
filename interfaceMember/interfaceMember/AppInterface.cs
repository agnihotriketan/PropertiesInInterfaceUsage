using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace interfaceMember
{
    

    interface AppInterface
{
        // Property signatures:
        int x
        {
            get;
            set;
        }

        int y
        {
            get;
            set;
        }
    }
}
