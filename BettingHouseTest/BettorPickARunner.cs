namespace BettingHouse;
using Classes;
public class BettorPickARunner
{
    // Each bettor should pick a runner
    [Fact]
    public void EachBettorShouldBetOnARunner()
    {
        // Arrange
        BettingHouse bettingHouse = new BettingHouse();
        List<string> bettorNames = new List<string>() { "Tiago", "Tux", "Pixie", "Victor", "Will" };
        List<string> runnerNames = new List<string>() { "Dylan", "Thomas", "Auden", "Tars", "Frankestein" };

        // Act
        Random random = new Random();
        int runnerType = random.Next(0, 3);
        // Registering the runners then the bettors
        bettingHouse.RegisterRunners(runnerNames, runnerType);
        bettingHouse.RegisterBettors(bettorNames, 0);

        // Assert
        for (int i = 0; i < bettingHouse.BettorList.Count; i++)
        {
            Assert.True(bettingHouse.BettorList[i].Runner != null);
        }


    }
}
