using System.Diagnostics;
using TypingTest;

namespace TypingUnitTesting
{
    [TestClass]
    public class SentenceLibraryTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            SentenceLibrary lib = new SentenceLibrary();
            Assert.IsNotNull(lib);

            int expected = 724;

            Assert.AreEqual(expected, lib.Library.Count);

            string expStr = "My Mum tries to be cool by saying that she likes all the same things that I do.";
            Assert.AreEqual(expStr, lib.Library[1]);
        }
    }
}
