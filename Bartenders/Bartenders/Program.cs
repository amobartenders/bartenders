using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartenders
{

    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static ArduinoCom arduino;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            arduino = new ArduinoCom("#", "%");
            Application.Run(new Form1());
        }
    }
}
