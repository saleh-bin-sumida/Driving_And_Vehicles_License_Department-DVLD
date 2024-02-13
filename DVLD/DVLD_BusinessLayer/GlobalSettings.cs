using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public static class GlobalSettings
    {
        public static  clsUser CurrentUser { get; set; }

        public static readonly  string destinationFolder = @"C:\DVLD - People - Images";
    }
}
