using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAMP_Forms.Interface
{
    interface ILogin
    {
        string user_id { get; set; }
        string password { get; set; }
        string name { get; set; }
        DateTime birthday { get; set; }
        string email { get; set; }
        string gender { get; set; }
        Int64 contact_no { get; set; }
        DateTime creation_date { get; set; }
        DateTime updation_date { get; set; }

        DataTable dtTemp { get; set; }
    }
}
