using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chcete_byt_EXPERTEM
{
    static class FormHandler
    {
        public static MainForm main = new MainForm();
        public static Menu menu = new Menu();
        public static Victory victory = new Victory();
        public static Settings settings = new Settings();
        public static Ask ask = new Ask();
        public static Lose lose = new Lose();
        public static Database dataBase = new Database();

    }
}
