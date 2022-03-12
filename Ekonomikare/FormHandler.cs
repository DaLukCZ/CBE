using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ekonomikare
{
    static class FormHandler
    {
        public static MainForm main = new MainForm();
        public static Menu menu = new Menu();
        public static Victory victory = new Victory();
        public static Settings settings = new Settings();
        public static Ask ask = new Ask();
        public static CallHelp callHelp = new CallHelp();

    }
}
