using FizzBuzz.Game;
using FluentAssertions;

namespace FizzBuzz.Tests;

/// <summary>
/// AI-driven unit tests using Red-Green-Refactor pattern and Devil's Advocate approach
/// These tests challenge the implementation with edge cases, boundary conditions, and adversarial inputs
/// </summary>
public class AIGameTest
{
    #region Devil's Advocate: Edge Cases - Zero and Negative Numbers
    
    [Fact]
    public void When_Send_Zero_Then_Should_Return_FizzBuzz()
    {
        // Arrange - Devil's Advocate: What happens with zero? It's divisible by everything!
        var board = new GameBoard();
        var number = 0;

        // Act
        var word = board.GetWord(number);

        // Assert - Zero is divisible by both 3 and 5, should return "FizzBuzz"
        word.Should().Be("FizzBuzz");
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(-6)]
    [InlineData(-9)]
    public void When_Send_Negative_Divisible_By_Three_Then_Should_Return_Fizz(int number)
    {
        // Arrange - Devil's Advocate: Do negative numbers work correctly?
        var board = new GameBoard();

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(-5)]
    [InlineData(-10)]
    [InlineData(-20)]
    public void When_Send_Negative_Divisible_By_Five_Then_Should_Return_Buzz(int number)
    {
        // Arrange - Devil's Advocate: Negative numbers divisible by 5
        var board = new GameBoard();

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(-15)]
    [InlineData(-30)]
    [InlineData(-45)]
    public void When_Send_Negative_Divisible_By_Both_Then_Should_Return_FizzBuzz(int number)
    {
        // Arrange - Devil's Advocate: Negative numbers divisible by both 3 and 5
        var board = new GameBoard();

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be("FizzBuzz");
    }

    #endregion

    #region Devil's Advocate: Boundary Values
    
    [Theory]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void When_Send_Extreme_Integer_Values_Then_Should_Not_Throw(int number)
    {
        // Arrange - Devil's Advocate: What about extreme values?
        var board = new GameBoard();

        // Act
        Action act = () => board.GetWord(number);

        // Assert - Should handle extreme values without throwing
        act.Should().NotThrow();
    }

    [Fact]
    public void When_Send_MaxValue_Divisible_By_Three_Then_Should_Return_Appropriate_Word()
    {
        // Arrange - Devil's Advocate: Check if int.MaxValue is handled correctly
        var board = new GameBoard();
        var number = 2147483646; // int.MaxValue - 1, divisible by 3

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be("Fizz");
    }

    #endregion

    #region Devil's Advocate: Complete FizzBuzz Rules
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(25)]
    public void When_Send_Divisible_By_Five_Only_Then_Should_Return_Buzz(int number)
    {
        // Arrange - Devil's Advocate: Is the "Buzz" rule implemented?
        var board = new GameBoard();

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(60)]
    [InlineData(75)]
    public void When_Send_Divisible_By_Both_Three_And_Five_Then_Should_Return_FizzBuzz(int number)
    {
        // Arrange - Devil's Advocate: Order matters! FizzBuzz should come before Fizz or Buzz
        var board = new GameBoard();

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be("FizzBuzz");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(11)]
    public void When_Send_Not_Divisible_By_Three_Or_Five_Then_Should_Return_Number_String(int number)
    {
        // Arrange - Devil's Advocate: Normal numbers should just return their string representation
        var board = new GameBoard();

        // Act
        var word = board.GetWord(number);

        // Assert
        word.Should().Be(number.ToString());
    }

    #endregion

    #region Devil's Advocate: Consistency and Determinism
    
    [Fact]
    public void When_Called_Multiple_Times_With_Same_Input_Then_Should_Return_Same_Output()
    {
        // Arrange - Devil's Advocate: Is the function deterministic?
        var board = new GameBoard();
        var number = 15;

        // Act
        var word1 = board.GetWord(number);
        var word2 = board.GetWord(number);
        var word3 = board.GetWord(number);

        // Assert
        word1.Should().Be(word2);
        word2.Should().Be(word3);
        word1.Should().Be("FizzBuzz");
    }

    [Fact]
    public void When_Created_New_Instance_Then_Should_Work_Independently()
    {
        // Arrange - Devil's Advocate: Are instances independent?
        var board1 = new GameBoard();
        var board2 = new GameBoard();

        // Act
        var word1 = board1.GetWord(3);
        var word2 = board2.GetWord(3);

        // Assert
        word1.Should().Be(word2);
        word1.Should().Be("Fizz");
    }

    #endregion

    #region Devil's Advocate: Type Safety and Return Values
    
    [Fact]
    public void When_Called_Then_Should_Never_Return_Null()
    {
        // Arrange - Devil's Advocate: Should never return null
        var board = new GameBoard();

        // Act & Assert - Test multiple scenarios
        for (int i = -10; i <= 100; i++)
        {
            var word = board.GetWord(i);
            word.Should().NotBeNull();
        }
    }

    [Fact]
    public void When_Called_Then_Should_Never_Return_Empty_String()
    {
        // Arrange - Devil's Advocate: Should never return empty string
        var board = new GameBoard();

        // Act & Assert
        for (int i = -10; i <= 100; i++)
        {
            var word = board.GetWord(i);
            word.Should().NotBeEmpty();
        }
    }

    #endregion

    #region Devil's Advocate: Large Range Validation
    
    [Fact]
    public void When_Process_Range_1_To_100_Then_Should_Have_Correct_Distribution()
    {
        // Arrange - Devil's Advocate: Classic FizzBuzz range validation
        var board = new GameBoard();
        var fizzCount = 0;
        var buzzCount = 0;
        var fizzBuzzCount = 0;
        var numberCount = 0;

        // Act
        for (int i = 1; i <= 100; i++)
        {
            var word = board.GetWord(i);
            
            if (word == "FizzBuzz") fizzBuzzCount++;
            else if (word == "Fizz") fizzCount++;
            else if (word == "Buzz") buzzCount++;
            else numberCount++;
        }

        // Assert - Devil's Advocate: Verify mathematical correctness
        // Numbers divisible by 15 (both 3 and 5): 15, 30, 45, 60, 75, 90 = 6
        fizzBuzzCount.Should().Be(6);
        
        // Numbers divisible by 3 only (excluding 15): 3,6,9,12,18,21,24,27,33,36,39,42,48,51,54,57,63,66,69,72,78,81,84,87,93,96,99 = 27
        fizzCount.Should().Be(27);
        
        // Numbers divisible by 5 only (excluding 15): 5,10,20,25,35,40,50,55,65,70,80,85,95,100 = 14
        buzzCount.Should().Be(14);
        
        // Regular numbers: 100 - 6 - 27 - 14 = 53
        numberCount.Should().Be(53);
    }

    #endregion

    #region Devil's Advocate: Performance and Resource Usage
    
    [Fact]
    public void When_Called_Repeatedly_Then_Should_Complete_In_Reasonable_Time()
    {
        // Arrange - Devil's Advocate: Performance test
        var board = new GameBoard();
        var iterations = 10000;

        // Act
        var startTime = DateTime.Now;
        for (int i = 0; i < iterations; i++)
        {
            board.GetWord(i);
        }
        var elapsed = DateTime.Now - startTime;

        // Assert - Should complete quickly (less than 1 second for 10k iterations)
        elapsed.TotalSeconds.Should().BeLessThan(1.0);
    }

    #endregion
}