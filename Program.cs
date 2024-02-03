using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240203_Fruit_KorteA
{
    internal static class Program
    {
        public static Form_FruitList nyitoForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            nyitoForm = new Form_FruitList();
            Application.Run(nyitoForm);
        }
    }
}
