using FizzBuzz.Game;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class GameTests
    {
        //[Fact]
        //public void ItExists()
        //{
        //    FizzBuzz.Game.GameBoard board = new FizzBuzz.Game.GameBoard();
        //    int number = 2;
        //    string output = board.GetWord(number);
        //}

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void When_Send_A_Number_Then_should_Return_word(int number)
        {
            ///AAA Pattern:

            //A: Arrange
            var board = new GameBoard();
            //var number = 4;

            //A: Act:
            string word = board.GetWord(number);

            //A: Assert:

            Assert.Equal(number.ToString(), word);
        }

        [Fact]
        public void When_Send_3_Then_Return_Fizz()
        {
            var board = new GameBoard();
            var number = 3;

            var word = board.GetWord(number);

            word.Should().Be("Fizz");
           
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void When_Send_Divisible_by_three_Then_Return_Fizz(int number)
        {
            var board = new GameBoard();
            //var number = 3;

            var word = board.GetWord(number);

            word.Should().Be("Fizz");

        }

       





    }
}
