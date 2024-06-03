namespace DogRacing
{
    public class BettingHouse // When should we use GUID?
    {
        public List<Bettor> BettorList { get; set; }

        // Can I write this method then use it on a test?
        // Is it better to always write class methods that take parameters so we can test them using [theory]?
        // In this case, there's user input, the name of the bettors

        public void RegisterBettors(int numberOfBettors, List<string> nameList)
        {
            BettorList = new List<Bettor>();
            {
                for (int i = 0; i < numberOfBettors; i++)
                {
                    int id = i + 1;
                    string name = Console.ReadLine();

                    Bettor bettor = new Bettor();
                    bettor.Id = i;
                    bettor.Name = nameList[i];

                    this.BettorList.Add(bettor);
                }
            }

        }
    }
}
