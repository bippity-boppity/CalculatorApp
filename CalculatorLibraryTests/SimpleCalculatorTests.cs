using CalculatorLibrary.SimpleCalculator;

namespace CalculatorLibraryTests;

public class SimpleCalculatorTests
{
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        int result = calculator.Add(5, 3);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_NegativeAndPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        int result = calculator.Add(-5, 3);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        int result = calculator.Subtract(10, 3);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_LargerNumberFromSmallerNumber_ReturnsNegativeDifference()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        int result = calculator.Subtract(3, 10);

        // Assert
        Assert.Equal(-7, result);
    }
}
