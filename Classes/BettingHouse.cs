namespace Classes
{
    public class BettingHouse // When should we use GUID?
    {
        public List<Bettor> BettorList { get; set; }
        public List<Runner> RunnerList { get; set; }

        public BettingHouse()
        {
            BettorList = new List<Bettor>();
            RunnerList = new List<Runner>();
        }

        public void AskForNames(bool bettor)
        {
            if (bettor)
            {
                // Why initialize as new list?
                List<string> nameList = new List<string>();
                int userInput = 1;
                while (userInput != 0)
                {
                    Console.WriteLine("Insert a name for the bettor: "); // Not specifying 0 or 1 at the beggining, but rather making it possible to exit the loop ONLY with 5 bettors registered
                    string name = Console.ReadLine();
                    nameList.Add(name);
                    if (nameList.Count >= 5)
                    {
                        Console.WriteLine("You have 5 bettors, specify if you want to continue:");
                        userInput = int.Parse(Console.ReadLine());
                    }
                }
                RegisterBettors(nameList);
            }
            else
            {
                List<string> nameList = new List<string>();
                int userInput = 1;
                while (userInput != 0)
                {
                    Console.WriteLine("Insert a name for the runner: ");
                    string name = Console.ReadLine();
                    nameList.Add(name);
                    Console.WriteLine("Specify the type of runner: ");
                    if (nameList.Count >= 4)
                    {
                        Console.WriteLine("You have 4 runners, specify if you want to continue: ");
                        userInput = int.Parse(Console.ReadLine());
                    }

                }
                RegisterRunners(nameList);
            }
        }

        public void RegisterBettors(List<string> nameList)
        {
            foreach (string name in nameList)
            {
                Guid id = Guid.NewGuid();
                Bettor bettor = new Bettor();
                bettor.Id = id;
                bettor.Name = name;
                BettorList.Add(bettor);
                Console.WriteLine($"Added a bettor\nId:{bettor.Id}\nName: {bettor.Name}\n");
            }
        }

        public void RegisterRunners(List<string> nameList)
        {
            foreach (string name in nameList)
            {
                Guid id = Guid.NewGuid();
                Runner runner = new Runner();
                runner.Id = id;
                runner.Name = name;
                RunnerList.Add(runner);
                Console.WriteLine($"Added a runner\nId: {runner.Id}\nName: {runner.Name}\n");
            }
        }

        public void Race()
        {
            bool hasWinner = false;
            while (!hasWinner)
            {
                for (int i = 0; i < this.RunnerList.Count; i++)
                {
                    this.RunnerList[i].Run();
                    if (this.RunnerList[i].Won())
                    {
                        hasWinner = true;
                        break;
                    }
                }
            }

            //for (int i = 0; i < this.RunnerList.Count; i++)
            //{
            //    this.RunnerList[i].Run();
            //    if (this.RunnerList[i].Won())
            //    {
            //        Console.WriteLine($"The runner {this.RunnerList[i].Name} has won!");
            //        return true;
            //    }
            //}
            //return false;
        }
    }
}
