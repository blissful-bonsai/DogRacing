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
        List<string> runnerNames = new List<string>() { "Dylan", "Thomas", "Auden", "Tars", "Frankestein" };

        // Act
        // Registering the runners then the bettors
        bettingHouse.RegisterRunners(runnerNames);
        bettingHouse.RegisterBettors(bettorNames);


        // Make the race happen
        bettingHouse.Race();

        // If it was a var, would winner become a Runner instance?
        // What if no runner is found on the list? 
        Runner winner = bettingHouse.RunnerList.FirstOrDefault(r => r.HasWon);

        // Asssert
        // If the FirstOrDefault fails, winner is null
        Assert.NotNull(winner);
    }

}
