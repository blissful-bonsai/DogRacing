namespace BettingHouseTest;

using Classes;

public class AtLeastFiveBettors
{
    [Fact]
    public void ShouldHaveAtLeastFiveBettors()
    {
        // Arrange
        BettingHouse bettingHouse = new BettingHouse();
        List<string> names = new List<string> { "Tiago", "Tux", "Pixie", "Victor", "Will", "Sean" };

        // Act
        bettingHouse.RegisterBettors(names);

        // Assert
        Assert.True(bettingHouse.BettorList.Count >= 5);
    }

    //[Fact]
    //public void EachBettorShouldPickRunner()
    //{
    //    BettingHouse bettingHouse = new BettingHouse();
    //    List<string> names = new List<string> { "Tiago", "Tux", "Pixie", "Victor", "Will", "Sean" };

    //    // Act
    //    bettingHouse.RegisterBettors(names);


    //}
}
