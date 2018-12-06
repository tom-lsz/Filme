using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.DataManagement;

namespace FilmeSchauspieler.SystemSpecification
{
    static class SystemSpecificationFactory
    {
        public static ISystemSpecification get(string specType = "ASC", string dataType = "SQL")
        {
            IDataManagement dataManagement = DataManagementFactory.get(dataType);
            switch(specType)
            {
                case "ASC":
                    return new SystemSpecificationAsc(dataManagement);

                case "DESC":
                    return new SystemSpecificationDesc(dataManagement);

                default:
                    return new SystemSpecificationAsc(dataManagement);
            }
        }
    }
}
