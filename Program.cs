using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPomodoroApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PomodoroApp PomodoroForm= new PomodoroApp();
            PomodoroForm.ShowDialog();
        }
    }
}
