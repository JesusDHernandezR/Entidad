using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PresentacionGUI
{
    public static class ConfigConnectionn
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}
