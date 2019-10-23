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
            if (Program.arduino.ConnectAutomagically())
            {
                MessageBox.Show("Connected!");
                Application.Run(new Form1());
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Waarschuwing", "Kan geen verbinding maken, toch doorgaan?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Run(new Form1());
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            
        }
    }
}
