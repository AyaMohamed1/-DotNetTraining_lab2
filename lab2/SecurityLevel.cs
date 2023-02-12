using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [Flags]
    public enum SecurityLevel : byte{
        guest = 1,
        developer = 2,
        secretary = 3,
        DBA = 4,
        securityOfficer = 0x0f 
    }
}
