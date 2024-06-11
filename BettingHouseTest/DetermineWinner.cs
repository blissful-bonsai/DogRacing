//##### Cenário: Finalização da corrida
//-**Dado que** a corrida está em andamento
//- **Quando** um corredor atingir 100 metros
//- **Então** o sistema deve declarar esse corredor como o vencedor
//- **E** dividir o prêmio entre os apostadores que apostaram no corredor vencedor
namespace BettingHouseTest;
using Classes;
public class DetermineWinner
{
    [Fact]
    public void SomeoneShouldWin()
    {
        // Arrange
        BettingHouse bettingHouse = new BettingHouse();
        List<string> bettorNames = new List<string>() { "Tiago", "Tux", "Pixie", "Victor", "Will" };
        List<string> runnerNamesOne = new List<string>() { "Dylan", "Thomas" };
        List<string> runnerNamesTwo = new List<string>() { "Auden", "Tars", "Frankestein" };

        // Act
        // Registering the runners then the bettors
        bettingHouse.RegisterRunners(runnerNamesOne, 2);
        bettingHouse.RegisterRunners(runnerNamesTwo, 1);
        foreach (Runner runner in bettingHouse.RunnerList) // This loop was created to check whether or not there was a bug on the race, because the ThirtyFity Runner was winning EVERY SINGLE RACE
        {
            if (runner.Name == runnerNamesOne[0] || runner.Name == runnerNamesOne[1])
            {
                runner.TotalDistance = 29; // After 8 iterations and 7 wins from the TwentyForty type, the ThirtyFifty won
            }
        }
        bettingHouse.RegisterBettors(bettorNames, 0);

        // Make them race
        bettingHouse.Race();
        var winner = bettingHouse.RunnerList.FirstOrDefault(r => r.HasWon); // First or default finds the first element in the list being iterated through that meets the specified conditions
        // Assert
        Assert.True(winner != null, $"There's a winner, his/her name is {winner.Name}, he/she ran {winner.TotalDistance}");
        Assert.False(winner.Name == "Auden" || winner.Name == "Tars" || winner.Name == "Frankestein");

    }

}