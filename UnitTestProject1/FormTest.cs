using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceGame;

namespace UnitTestProject1
{
    [TestClass]
    [UseReporter(typeof(DiffReporter), typeof(ClipboardReporter))]
    public class FormTest
    {
        // ***** Punter Name test - passed (Positive Test Case) ********* 
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();
            var actual = form.punter[0].GuyName;
            Assert.AreEqual("Joe", actual);
        }

        // ***** Punter Name test - passed (Negative Test Case) ********* 
        [TestMethod]
        public void TestMethod2()
        {
            Form1 form = new Form1();
            var actual = form.punter[1].GuyName;
            Assert.AreNotEqual("Joe", actual);
        }
    }
}
