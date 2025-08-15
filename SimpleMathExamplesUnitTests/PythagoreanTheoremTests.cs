using SimpleMathExamples;

namespace SimpleMathExamplesUnitTests;

[TestClass]
public class PythagoreanTheoremTests
{
    [TestMethod]
    public void TestSolve()
    {
        // Arrange
        PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();
        double a = 3;
        double b = 4;

        // Act
        double result = pythagoreanTheorem.Solve(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void SquaredTest()
    {
        // Arrange
        PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();
        double input = 3;
        double input2 = 5;

        // Act
        double result = pythagoreanTheorem.Squared(input);
        double result2 = pythagoreanTheorem.Squared(input2);

        // Assert
        Assert.AreEqual(9, result);
        Assert.AreEqual(25, result2);
    }

        [TestMethod]
    public void TestSquareRoot()
    {
        // Arrange
        PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();
        double input = 16;

        // Act
        double result = pythagoreanTheorem.SquareRoot(input);

        // Assert
        Assert.AreEqual(4, result); // Adjusted to match the modified SquareRoot method
    }
}
