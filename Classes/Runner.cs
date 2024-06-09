public class Runner
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal TotalDistance { get; set; }
    public decimal MinSpeed { get; set; }
    public decimal MaxSpeed { get; set; }


    public Runner()
    {
        Id = Guid.NewGuid();
        TotalDistance = 0;
    }

    public void Run()
    {
        // I think we should use the same Random instance for EVERY run, and don't instantiate another one for each run
        Random random = new Random();
        int minSpeed = (int)(this.MinSpeed * 10);
        int maxSpeed = (int)(this.MaxSpeed * 10);
        int distance = random.Next(minSpeed, maxSpeed);
        //Console.WriteLine(distance); // Testing
        decimal distanceToDecimal = (decimal)distance / 10;
        this.TotalDistance += distanceToDecimal;
    }

    public bool Won()
    {
        if (this.TotalDistance >= 100)
        {
            return true;
        }
        return false;
    }

}

public class ZeroSeventyRunner : Runner
{
    public ZeroSeventyRunner()
    {
        this.MinSpeed = 0m;
        this.MaxSpeed = 0.7m;
    }
}

public class ThirtyFiftyRunner : Runner
{
    public ThirtyFiftyRunner()
    {
        this.MinSpeed = 0.3m;
        this.MaxSpeed = 0.5m;
    }
}

public class TwentyFortyRunner : Runner
{
    public TwentyFortyRunner()
    {
        this.MinSpeed = 0.2m;
        this.MaxSpeed = 0.4m;
    }
}

public class TenSixtyRunner : Runner
{
    public TenSixtyRunner()
    {
        this.MinSpeed = 0.1m;
        this.MaxSpeed = 0.6m;
    }
}


