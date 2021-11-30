using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biglietteria.Composite;
using Biglietteria.Builder;
using Biglietteria.Visitor;
using Biglietteria.Singleton;


namespace Biglietteria
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Biglietteria visualizza = new Biglietteria();
            visualizza.Visible = false;

            Controller controller = new Controller(visualizza, @"C:\Users\Martina\Desktop\Progetto-PMO\Biglietteria\File");

            visualizza.ShowDialog();
            
        }
    }
}
