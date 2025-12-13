namespace exercise29;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the reward code (DOUBLE, HEAL, GOLD, SPECIAL): ");
        string rewardCode = Console.ReadLine().ToUpper();

        string message = rewardCode switch
        {
            "DOUBLE" => "Reward: Double XP for 1 hour unlocked.",
            "HEAL" => "Reward: Healing potion unlocked.",
            "GOLD" => "Reward: 1000 gold coins unlocked.",
            "SPECIAL" => "Reward: Legendary item unlocked.",
            _ => $"Reward: {rewardCode} unavailable."
        };

        Console.WriteLine(message);
    }
}
