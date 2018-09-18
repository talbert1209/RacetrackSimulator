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
            MyBet = new Bet();
            MyLabel.Text = MyBet.GetDescription(this);
            MyRadioButton.Text = $@"{Name} has ${Cash} dollars";
        }

        public bool PlaceBet(int betAmount, int dogToWin)
        {
            if (betAmount <= Cash)
            {
                MyBet.Amount = betAmount;
                MyBet.Dog = dogToWin;
                return true;
            }

            return false;
        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
            ClearBet();
            UpdateLabels();
        }
    }
}