class Submarine
{
    private int length;
    private int maxMiles;

    public int Length
    {
        get { return length; }
        set {length = value; }
    }

    public int MaxMiles
    {
        get { return maxMiles; }
        set { maxMiles = value; }
    }
} 

// this class is derived from the submarine class
class NuclearSubmarine : Submarine
{
    private int reactorOutput; // output will be in MW (megawatts)

    public int ReactorOutput
    {
        get { return reactorOutput; }
        set { reactorOutput = value; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // regular submarine object
        Submarine submarine = new Submarine(); // instantiating new object of the Submarine class
        submarine.Length = 295; // measured in feet
        submarine.MaxMiles = 10000;

        // nuclear submarine object
        NuclearSubmarine nuclearSubmarine = new NuclearSubmarine();
        nuclearSubmarine.Length = 560; // measured in feet
        nuclearSubmarine.MaxMiles = 30000;
        nuclearSubmarine.ReactorOutput = 200; // measured in megawatts

        Console.WriteLine("Regular Submarine: ");
        Console.WriteLine($"The max length for regular submarine is {submarine.Length} feet.");
        Console.WriteLine($"The maximum distance for a regular submarine is {submarine.MaxMiles} miles.");

        Console.WriteLine("\nNuclear Submarine: ");
        Console.WriteLine($"The max length for a nuclear Submarine is {nuclearSubmarine.Length} feet.");
        Console.WriteLine($"The maximum distance for a nuclear submarine is {nuclearSubmarine.MaxMiles} miles.");
        Console.WriteLine($"The reactor output of a nuclear submarine is {nuclearSubmarine.ReactorOutput} megawatts.");


    }
}

