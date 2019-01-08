using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmeSchauspieler.DataManagement
{
    static class DataManagementFactory
    {
        public static IDataManagement get(string type)
        {
            switch (type)
            {
                case "SQL":
                    return new DataManagementSql();

                case "XML":
                    //return new DataManagementCsv();

                default:
                    return new DataManagementSql();
            }
        }
    }
}
