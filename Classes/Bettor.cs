namespace Classes
{
    public class Bettor
    {
        // When should we use GUID?
        // The id can be equal to the "i" in the for loop used to generate all the bettors, but we could use other ways such as user input
        public Guid Id { get; set; }
        public string Name { get; set; }
        // Why choose decimal over float?
        public decimal Balance; // Does it need a getter setter?
        public Runner Runner { get; set; }

        // The only thing they have in common is balance, which is always equal to 20 in the beggining of the bettings
        public Bettor()
        {
            Balance = 20;
        }

        public void PickARunner(List<Runner> runnerList)
        {
            for (int i = 0; i < runnerList.Count; i++)
            {
                Console.WriteLine($"List of runners available: {i}");
            }
        }
    }

}
