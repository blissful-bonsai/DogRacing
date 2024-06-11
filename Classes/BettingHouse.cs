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
        static int runnerType = 0;

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
                    Console.WriteLine("Specify the type of runner:\n 0:0-70\n1:30-50\n2:20-40\n3:10-60 ");
                    // This is a static int declared at the beggining
                    runnerType = int.Parse(Console.ReadLine());
                    if (nameList.Count >= 4)
                    {
                        Console.WriteLine("You have 4 runners, specify if you want to continue: ");
                        userInput = int.Parse(Console.ReadLine());
                    }

                }
                RegisterRunners(nameList, runnerType);
            }
        }

        public void RegisterRunners(List<string> nameList, int runnerType)
        {
            foreach (string name in nameList)
            {
                List<Runner> runnerTypes = new List<Runner>() { new ZeroSeventyRunner(), new ThirtyFiftyRunner(), new TwentyFortyRunner() };
                Runner runner = runnerTypes.ElementAt(runnerType); // Element at index, kind of
                Guid id = Guid.NewGuid();
                runner.Id = id;
                runner.Name = name;
                RunnerList.Add(runner);
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

        }
    }
}
