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

        // Registering the runners then the bettors
        bettingHouse.RegisterRunners(runnerNames);
        bettingHouse.RegisterBettors(bettorNames);

        // Having the bettors pick a runner using the i from the loop
        for (int i = 0; i < bettingHouse.BettorList.Count; i++)
        {
            bettingHouse.BettorList[i].PickRunner(bettingHouse.RunnerList, i);
        }

        // Assert
        for (int i = 0; i < bettingHouse.BettorList.Count; i++)
        {
            Assert.True(bettingHouse.BettorList[i].Runner != null);
        }


    }
}
