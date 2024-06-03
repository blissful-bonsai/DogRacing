namespace BettorTest;
using DogRacing;

public class BettorBalance
{
    // This test ensures the balance is equal to 20, but is it really necessary?
    [Fact]
    public void BalanceShouldBeTwenty()
    {
        Bettor bettor = new Bettor();
        decimal valueToBeMatched = 20;
        Assert.Equal(bettor.Balance, valueToBeMatched);
    }
}
