using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FacebookTest.Core
{
    class Configurator
    {
        public static string GetConfiguration(string setting) {
            return ConfigurationManager.AppSettings[setting];
        }

    }
}
