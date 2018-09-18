using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription(this);
            MyRadioButton.Text = $@"{Name} has ${Cash} dollars";
        }

        public bool PlaceBet(int betAmount, int dogToWin)
        {
            MyBet = new Bet(){Amount = betAmount, Bettor = this, Dog = dogToWin};

            if (betAmount <= Cash)
            {
                MyBet.Amount = betAmount;
                MyBet.Dog = dogToWin;
                return true;
            }
            ClearBet();
            UpdateLabels();
            return false;
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
            ClearBet();
            UpdateLabels();
        }
    }
}