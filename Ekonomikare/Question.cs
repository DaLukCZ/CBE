using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chcete_byt_EXPERTEM
{
    class Question
    {
        /*
         * 0-9 = nejmensi a nejvetsi stupen
         */
        public int step = 0;
        public string question;
        public string[] answers = new string[4];
        public int rightAnswer;

        public Question(int step, string question, string[] answers, int rightAnswer)
        {
            this.step = step;
            this.question = question;
            this.answers = answers;
            this.rightAnswer = rightAnswer;
        }
    }
}