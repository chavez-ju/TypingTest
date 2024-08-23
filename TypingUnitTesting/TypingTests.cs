using System.Diagnostics;
using TypingTest;

namespace TypingUnitTesting
{
    [TestClass]
    public class TypingTests
    {
        [TestMethod]
        public void GrossWPMValidation()
        {   
            /*
            TypingTester t = new TypingTester();
            Stopwatch s = new Stopwatch();
            int expected = 0;
            
            t.TypedEntries = 10;
            s.Start();
            Thread.Sleep(2000);
            s.Stop();
            expected = 60;
            Assert.AreEqual(expected, t.GrossWPM(s), 0.0001, "WPM not calculated correctly");

            t.TypedEntries = 200;
            s.Restart();
            Thread.Sleep(30000);
            s.Stop();
            expected = 80;
            Assert.AreEqual(expected, t.GrossWPM(s), 0.0001, "WPM not calculated correctly");
            
            
            // Test .TotalMinutes method for Timespan
            t.TypedEntries = 500;
            s.Restart();
            Thread.Sleep(5000);
            s.Stop();
            expected = 1200;
            Assert.AreEqual(expected, t.GrossWPM(s));
            --- Close Results */
        }

        [TestMethod]
        public void MinDistance()
        {
            TypingTester t = new TypingTester();

            string s1 = "Hello I am well";
            string s2 = "hola i not well";
            
            int actual = t.MinDistance(s1, s2);

            int expected = 8;

            Assert.AreEqual(expected, actual);
            
            
        }
    }
}