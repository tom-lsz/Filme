using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmeSchauspieler.SystemSpecification
{
    static class SystemSpecificationFactory
    {
        public static ISystemSpecification get(string type)
        {
            switch(type)
            {
                case "ASC":
                    return new SystemSpecificationAsc();

                case "DESC":
                    return new SystemSpecificationDesc();

                default:
                    return new SystemSpecificationAsc();
            }
        }
    }
}
