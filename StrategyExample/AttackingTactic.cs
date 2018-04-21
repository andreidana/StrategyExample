namespace StrategyExample
{
    public class AttackingTactic: AbstractFootballTactic
    {
        public override void GiveSpecialInstructions()
        {
            SpecialInstructions = "Attacking tactic";
        }
    }
}