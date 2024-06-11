namespace BettingHouseTest;

using Classes;

public class AtLeastFiveBettors
{
    [Fact]
    public void ShouldHaveAtLeastFiveBettors()
    {
        // Arrange
        BettingHouse bettingHouse = new BettingHouse();
        List<string> bettorNames = new List<string> { "Tiago", "Tux", "Pixie", "Victor", "Will", "Sean" };
        List<string> runnerNames = new List<string>() { "Dylan", "Thomas", "Auden", "Tars", "Frankestein" };
        // Act
        bettingHouse.RegisterRunners(runnerNames, 0);
        bettingHouse.RegisterBettors(bettorNames, 0);

        // Assert
        Assert.True(bettingHouse.BettorList.Count >= 5);
    }

}

