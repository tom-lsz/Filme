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
            ISystemSpecification systemSpecification = new SystemSpecificationAsc();            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GUI gui = new GUI(systemSpecification);
            Application.Run(gui);
            DataManagementTest test = new DataManagementTest();            
        }
    }
}
