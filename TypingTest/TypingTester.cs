using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    public class TypingTester
    {
        public const double GrossConst = 5.0;

        public double TypedEntries {  get; set; }

        public TypingTester()
        {
            TypedEntries = 0.0;
        }
        public void EntryCountAdd()
        {
            TypedEntries++;
        }

        public int GrossWPM(Stopwatch sw)
        {
            TimeSpan tw = sw.Elapsed;
            double grossDouble = (TypedEntries / GrossConst) / tw.TotalMinutes;
            return Convert.ToInt32(Math.Round(grossDouble, 0));
        }
        public void SentenceDisplay()
        {
            Sentence sentence = new Sentence();
            Console.WriteLine(sentence.SentenceStr + "\n");
        }
    }

}
