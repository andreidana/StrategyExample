namespace StrategyExample
{
    public abstract class AbstractFootballTactic
    {
        public int Players { get; set; }
        public string Instructions { get; set; }
        public string SpecialInstructions { get; set; }

        public void CreateTactic()
        {
            SelectPlayers();
            GiveMatchInstructions();
            GiveSpecialInstructions();
        }

        public void SelectPlayers()
        {
            Players = 11;
        }

        public void GiveMatchInstructions()
        {
            Instructions = "Normal instructions";
        }

        public abstract void GiveSpecialInstructions();
    }
}