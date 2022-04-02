using NUnit.Framework;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenInput0ShouldBe0()
        {
            var input = 0;
            var obj = new FizzBuzzGame();
            
            var output = "0";
            var result = obj.Result(input);
            
            Assert.AreEqual(output, result);
        }
    }

    public class FizzBuzzGame
    {
        public string Result(int input)
        {
            return "0";
        }
    }
}