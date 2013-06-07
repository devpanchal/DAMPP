using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAMP_Forms.Class
{
    public static class DAMPGlobalVar
    {
        public static string LoginUserID = string.Empty;
        public static string SaveSuccessFully = "Save Susseccfully";
        public static string DeleteSuccessFully = "Deleted Successfully";

        #region "Enum"

        enum FormMode
        {
            None,
            Add,
            Edit,
            View
        }

        #endregion
    }
}
