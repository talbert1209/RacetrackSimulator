namespace RacetrackSimulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription(Guy bettor)
        {
            Bettor = bettor;
            if (Amount > 0)
            {
                return $@"{Bettor.Name} bet ${Amount} on dog {Dog}";
            }
            return $@"{Bettor.Name} hasn't placed a bet yet";
        }

        public int PayOut(int winner)
        {
            if (Dog == winner)
            {
                return Amount;
            }
            return Amount * -1;
        }
    }
}