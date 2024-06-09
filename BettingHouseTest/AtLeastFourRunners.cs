namespace BettingHouseTest;
using Classes;

public class AtLeastFourRunners
{
    [Fact]
    public void ShouldHaveAtLeastFourRunners()
    {
        // Arrange (create instance of BettingHouse)
        BettingHouse bettingHouse = new BettingHouse();

        // Act (run registerRunners from bettingHouse using a list of names)
        List<string> nameList = new List<string>() { "Dylan", "Thomas", "Auden", "Tars", "Case", "Cooper", "Austen" };
        bettingHouse.RegisterRunners(nameList);

        // Assert
        Assert.True(bettingHouse.RunnerList.Count >= 4);

    }
}
