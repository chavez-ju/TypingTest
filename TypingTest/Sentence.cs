using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    public class Sentence
    {
        public string SentenceStr {  get; set; }
        public Sentence()
        {
            SentenceLibrary sentenceLibrary = new SentenceLibrary();
            int range = sentenceLibrary.Library.Count;

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, range);

            SentenceStr = sentenceLibrary.Library[randomIndex];
        }
    }
}
