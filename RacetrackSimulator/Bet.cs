namespace RacetrackSimulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription(Guy bettor)
        {
            // this.Bettor associates a reference from the Better field in the Bet class to the guy object that gets passed
            // through the parameter in GetDescription().
            this.Bettor = bettor;
            if (Amount > 0)
            {
                return $@"{this.Bettor.Name} bet ${Amount} on dog {Dog}";
            }
            return $@"{this.Bettor.Name} hasn't placed a bet yet";
        }

        public int PayOut()
        {
            return 0;
        }
    }
}