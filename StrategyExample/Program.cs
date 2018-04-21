using System;

namespace StrategyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFootballTactic tactic = new AttackingTactic();
            tactic.CreateTactic();

            Console.WriteLine(tactic.SpecialInstructions);

            tactic = new DefensiveTactic();
            tactic.CreateTactic();

            Console.WriteLine(tactic.SpecialInstructions);
        }
    }
}
