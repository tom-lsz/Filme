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
            ISystemSpecification systemSpecification = SystemSpecificationFactory.get("ASC");
            DataManagementSql test = new DataManagementSql();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GUI gui = new GUI(systemSpecification);
            Application.Run(gui);
        }
    }
}
