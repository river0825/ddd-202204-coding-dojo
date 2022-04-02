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
        public void WhenInput1ShouldBe1()
        {
            var input = 1;
            var obj = new FizzBuzzGame();

            var output = "1";
            var result = obj.Result(input);

            Assert.AreEqual(output, result);
        }

        [Test]
        public void WhenInput3ShouldBeFizz()
        {
            var input = 3;
            var obj = new FizzBuzzGame();

            var output = "Fizz";
            var result = obj.Result(input);

            Assert.AreEqual(output, result);
        }

        [Test]
        public void WhenInput4ShouldBe4()
        {
            var input = 4;
            var obj = new FizzBuzzGame();

            var output = "4";
            var result = obj.Result(input);

            Assert.AreEqual(output, result);
        }

        [Test]
        public void WhenInput5ShouldBeBuzz()
        {
            var input = 5;
            var obj = new FizzBuzzGame();

            var output = "Buzz";
            var result = obj.Result(input);

            Assert.AreEqual(output, result);
        }

        [Test]
        public void WhenInput15ShouldBeFizzBuzz()
        {
            var input = 15;
            var obj = new FizzBuzzGame();

            var output = "FizzBuzz";
            var result = obj.Result(input);

            Assert.AreEqual(output, result);
        }
    }

    public class FizzBuzzGame
    {
        public string Result(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (input % 5 == 0)
            {
                return "Buzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }

            return $"{input}";
        }
    }
}