using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    public class TypingTester
    {
        public const double GrossConst = 5.0;
        public double TypedEntries {  get; set; }
        public Sentence sentence { get; set; }
        public TypingTester()
        {
            TypedEntries = 0.0;
            sentence = new Sentence();
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
        public string SentenceDisplay()
        {
            return sentence.SentenceStr;
        }
        // Levenshtein distance - s2 is the targeted (correct) phrase - for char
        public int MinDistance(string s1, string s2)
        {
            s1 = s1.Insert(0, " ");
            s2 = s2.Insert(0, " ");

            int colSize = s1.Length;
            int rowSize = s2.Length;

            int[,] table = new int[rowSize, colSize];

            // initialize first row
            for (int i = 0; i < colSize; i++)
            {
                table[0, i] = i;
            }

            // initialize first column
            for (int i = 0; i < rowSize; i++)
            {
                table[i, 0] = i;
            }
            // i is rows, j is col
            for (int i = 1; i < rowSize; i++)
            {
                for (int j = 1; j < colSize; j++)
                {
                    if (s1[j] == s2[i])
                    {
                        table[i, j] = table[i - 1, j - 1];
                    }
                    else
                    {
                        int ins = table[i, j - 1];
                        int rep = table[i - 1, j - 1];
                        int del = table[i - 1, j];

                        int least = Math.Min(ins, Math.Min(rep, del));

                        table[i, j] = least + 1;
                    }
                }
            }
            return table[rowSize - 1, colSize - 1];
        }
        public int NetWPM(int errors, Stopwatch sw)
        {
            TimeSpan tw = sw.Elapsed;
            double grossDouble = Math.Abs(((TypedEntries / GrossConst) - errors)) / tw.TotalMinutes;
            return Convert.ToInt32(Math.Round(grossDouble, 0));
        }
        public double Accuracy(int correct, int total)
        {
            return (Convert.ToDouble(correct) / Convert.ToDouble(total) * 100);
        }
    }
}
