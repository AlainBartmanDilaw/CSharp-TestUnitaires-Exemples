using NUnit.Framework;

namespace Mathematics.Tests
{
    [TestFixture]
    public class NUnitTest1
    {
        private MathOperations ope;

        [SetUp]
        public void Init()
        {
            ope = new MathOperations();
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(6, ope.Fois(2, 3));
            Assert.AreEqual(4, ope.Fois(2, 2));
            Assert.AreEqual(18, ope.Fois(3, 6));
        }

        [Test]
        public void TestMethod2()
        {
            string s = "a;b;c;d;e;f"; // 6 éléments

            string[] result = ope.splitThisString(s);

            Assert.AreEqual(6, result.Length);
            Assert.AreEqual("a", result[0]);
            Assert.AreEqual("b", result[1]);

        }

        [TestCase(729, 3, 6)]
        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 2)]
        [TestCase(81, 3, 4)]
        public void TestMoiCetteFonctionPlusieursFois(double result, int a, int b)
        {
            Assert.AreEqual(result, ope.Exposant(a, b));
        }
    }
}