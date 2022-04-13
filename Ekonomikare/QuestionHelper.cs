using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chcete_byt_EXPERTEM
{
    internal class QuestionHelper
    {
        public int id { get; set; }
        public string otazka { get; set; }
        public string odpoved_1 { get; set; }
        public string odpoved_2 { get; set; }
        public string odpoved_3 { get; set; }
        public string odpoved_4 { get; set; }
        public int spravna_odpoved { get; set; }
        public string obor { get; set; }
        public int obtiznost { get; set; }
    }
}
