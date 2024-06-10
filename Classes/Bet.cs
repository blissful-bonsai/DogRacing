namespace Classes
{
    public class Bet
    {
        public Guid Id { get; set; }
        public Bettor Bettor { get; set; }
        public Runner Runner { get; set; }
        public decimal Value { get; set; }

        public Bet()
        {
            this.Id = Guid.NewGuid();
        }



    }
}
