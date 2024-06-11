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
        bettingHouse.RegisterRunners(runnerNamesOne, 0);
        bettingHouse.RegisterRunners(runnerNamesTwo, 1);
        bettingHouse.RegisterBettors(bettorNames);

        // Make them race
        bettingHouse.Race();
        var winner = bettingHouse.RunnerList.FirstOrDefault(r => r.HasWon); // First or default finds the first element in the list being iterated through that meets the specified conditions
        // Assert
        Assert.True(winner == null, $"There's a winner! His name is: {winner.Name}!");

    }

}
