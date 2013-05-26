using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAMP_Forms.Interface
{
    interface ILogin
    {
        string userid { get; set; }
        string password { get; set; }
        DataTable dtTemp { get; set; }
    }
}
