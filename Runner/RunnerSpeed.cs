namespace RunnerTest;
using Classes;
public class RunnerSpeed
{
    [Fact]
    public void ShouldRunBetweenZeroAndSeventyAndWin()
    {
        // Arrange
        ZeroSeventyRunner zeroSeventy = new ZeroSeventyRunner();

        // Act
        zeroSeventy.Run();

        // Assert
        Assert.True(zeroSeventy.TotalDistance >= zeroSeventy.MinSpeed && zeroSeventy.TotalDistance <= zeroSeventy.MaxSpeed);

        while (!zeroSeventy.Won())
        {
            zeroSeventy.Run();
        }
        Assert.True(zeroSeventy.Won());
    }

    [Fact]
    public void ShouldRunBetweenThirtyAndFiftyAndWin()
    {
        // Arrange
        ThirtyFiftyRunner thirtyFifty = new ThirtyFiftyRunner();

        // Act
        thirtyFifty.Run();

        // Assert
        Assert.True(thirtyFifty.TotalDistance >= thirtyFifty.MinSpeed && thirtyFifty.TotalDistance <= thirtyFifty.MaxSpeed);

        while (!thirtyFifty.Won())
        {
            thirtyFifty.Run();
        }
        Assert.True(thirtyFifty.Won());
    }

    [Fact]
    public void ShouldRunBetweenTwentyAndFortyAndWin()
    {
        // Arrange
        TwentyFortyRunner twentyForty = new TwentyFortyRunner();

        // Act
        twentyForty.Run();

        // Assert
        Assert.True(twentyForty.TotalDistance >= twentyForty.MinSpeed && twentyForty.TotalDistance <= twentyForty.MaxSpeed);

        while (!twentyForty.Won())
        {
            twentyForty.Run();
        }
        Assert.True(twentyForty.Won());
    }

    [Fact]
    public void ShouldRunBetweenTenAndSixtyAndWin()
    {
        // Arrange
        TenSixtyRunner tenSixty = new TenSixtyRunner();

        // Act
        tenSixty.Run();

        // Assert
        Assert.True(tenSixty.TotalDistance >= tenSixty.MinSpeed && tenSixty.TotalDistance <= tenSixty.MaxSpeed);

        while (!tenSixty.Won())
        {
            tenSixty.Run();
        }
        Assert.True(tenSixty.Won());
    }
}
