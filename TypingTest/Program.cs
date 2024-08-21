using System;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace TypingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TypingTester tester = new TypingTester();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Start Typing when you are ready!\n");
            tester.SentenceDisplay();

            do
            {
                cki = Console.ReadKey();

                //for initial start
                if (tester.TypedEntries == 0)
                {
                    sw.Start();
                }

                // In order for the enter input to not count
                if (cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.Backspace)
                {
                    tester.EntryCountAdd();
                }
            } while (cki.Key != ConsoleKey.Enter);
            sw.Stop();
       
            /*
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            */

            Console.WriteLine("GrossWPM: " + tester.GrossWPM(sw));
            Console.WriteLine(tester.TypedEntries);
            
        }
    }
}