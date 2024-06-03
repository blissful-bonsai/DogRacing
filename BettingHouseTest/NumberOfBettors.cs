namespace BettingHouseTest;
using DogRacing;

public class NumberOfBettors
{
    [Fact]
    public void ShouldHaveAtLeastFiveBettors()
    {
        // Arrange
        BettingHouse bettingHouse = new BettingHouse();
        int minimumNumberOfBettors = 5;
        List<string> names = new List<string> { "Tiago", "Tux", "Pixie", "Victor", "Will", "Sean" };

        // Act
        bettingHouse.RegisterBettors(minimumNumberOfBettors, names);

        // Assert
        Assert.Equal(bettingHouse.BettorList.Count, minimumNumberOfBettors);

    }
}
