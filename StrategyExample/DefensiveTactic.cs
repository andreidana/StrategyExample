namespace StrategyExample
{
    public class DefensiveTactic: AbstractFootballTactic
    {
        public override void GiveSpecialInstructions()
        {
            SpecialInstructions = "Defensive tactic";
        }
    }
}