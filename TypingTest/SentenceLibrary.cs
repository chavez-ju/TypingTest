using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    public class SentenceLibrary
    {
        public List<string> Library {  get; set; }

        public SentenceLibrary()
        {
            Library = new List<string>();
            string line;

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\SentenceLibDir\sentences.txt";

            System.IO.StreamReader fileSR = new System.IO.StreamReader(file);
            while ((line = fileSR.ReadLine()) != null)
            {
                Library.Add(line);
            }

            fileSR.Close();

        }
    }
}
