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

        public bool PlaceBet()
        {
            return true;
        }

        public void ClearBet()
        {

        }

        public void Collect()
        {

        }
    }
}