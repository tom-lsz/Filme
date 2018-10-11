using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmeSchauspieler.DataManagement;
using FilmeSchauspieler.Userinterface;
using FilmeSchauspieler.SystemSpecification;

namespace FilmeSchauspieler
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
            DataManagementTest test = new DataManagementTest();

            ISystemSpecification systemSpecification = new SystemSpecificationAsc();

            GUI gui = new GUI(systemSpecification);
        }
    }
}
