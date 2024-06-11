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

        // For testing purposes, we will use a random number for the type of runner
        Random random = new Random();
        int typeOfRunner = random.Next(0, 3);

        bettingHouse.RegisterRunners(nameList, typeOfRunner);

        // Assert
        Assert.True(bettingHouse.RunnerList.Count >= 4);

    }
}
