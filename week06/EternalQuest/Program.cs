// Main entry point
class Program
{
    /* CREATIVITY/EXCEEDING CORE REQUIREMENTS:
    The program now includes a basic 'Leveling System'.
    The player's current level is displayed in the "Display Player Info" option.
    A new level is gained for every 1000 points earned.
    The system also informs the user how many points are needed to reach the next level.
    */
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
