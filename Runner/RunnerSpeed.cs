namespace RunnerTest;
public class RunnerSpeed
{

    // This runner runs between 0 and 0.7
    [Fact]
    public void ShouldRunBetweenZeroAndSeventyAndWin()
    {
        // Arrange (Create a runner of the type ZeroSeventy, and a decimal variable to hold his firstPosition value)
        ZeroSeventyRunner zeroSeventy = new ZeroSeventyRunner();

        // Act (Make the zeroSeventy call the run method
        zeroSeventy.Run();

        // Assert (That the firstPosition is between itself and itself + 0.7, 0.7 being the maximum distance that could have been covered
        Assert.True(zeroSeventy.TotalDistance >= zeroSeventy.MinSpeed && zeroSeventy.TotalDistance <= zeroSeventy.MaxSpeed);

        while (!zeroSeventy.Won())
        {
            zeroSeventy.Run();
        }
        Assert.True(zeroSeventy.Won());


    }




}

