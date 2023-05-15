using ConsoleApp;

namespace ConsoleAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_EmptyString_0()
        {
            string num = string.Empty;
           
            var result = Calculator.Add(num);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_1NumberString_1()
        {
            string num = "1";

            var result = Calculator.Add(num);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Add_2NumberString_3()
        {
            string num = "1,2";

            var result = Calculator.Add(num);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_3NumberString_10()
        {
            string num = "1,2,3,4";

            var result = Calculator.Add(num);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_3NumberStringNewLine_10()
        {
            string num = "1,2,3\n4";

            var result = Calculator.Add(num);

            Assert.AreEqual(10, result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void Add_StringNegativeNumber_Exception()
        {
            string num = "1,2,-3,4";

            Calculator.Add(num);
        }
    }
}