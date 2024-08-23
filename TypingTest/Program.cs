using System;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TypingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TypingTester tester = new TypingTester();
            //ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Start Typing when you are ready!\n");
            Console.WriteLine(tester.SentenceDisplay());

            string userString = "";
            int curIndex = 0;

            do
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);

                if (tester.TypedEntries == 0)
                {
                    sw.Start();
                }

                // handle Esc
                if (cki.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    break;
                }

                // handle Enter
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                // handle backspace
                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (curIndex > 0)
                    {
                        userString = userString.Remove(userString.Length - 1);
                        Console.Write(cki.KeyChar);
                        Console.Write(' ');
                        Console.Write(cki.KeyChar);
                        curIndex--;
                    }
                }

                else
                // handle all other keypresses
                {
                    userString += cki.KeyChar;
                    Console.Write(cki.KeyChar);
                    curIndex++;
                    tester.EntryCountAdd();
                }

            } while (true);

            sw.Stop();

            int errors = tester.MinDistance(userString, tester.SentenceDisplay());

            //var regex = new Regex(@"\s+");
            //int originalLength = Convert.ToInt32(regex.Replace(tester.SentenceDisplay(), " ")?.Split(' ')?.Count());
            //int correct = originalLength - errors;

            Console.WriteLine("\nNetWPM: " + tester.NetWPM(errors, sw));
            //Console.WriteLine("Accuracy: " + (tester.Accuracy(correct, originalLength) * 100) + "%");
            Console.WriteLine(tester.TypedEntries);
            
        }
    }
}