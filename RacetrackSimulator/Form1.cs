using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class Form1 : Form
    {
        Greyhound[] Dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        Random myRandom = new Random();
       
        public Form1()
        {
            InitializeComponent();

            //Initialize all the dog objects 
            Dogs[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = pictureBox1.Width - pictureBox2.Width,
                Randomizer = myRandom
            };
            Dogs[1] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = pictureBox1.Width - pictureBox3.Width,
                Randomizer = myRandom
            };
            Dogs[2] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = pictureBox1.Width - pictureBox4.Width,
                Randomizer = myRandom
            };
            Dogs[3] = new Greyhound()
            {
                MyPictureBox = pictureBox5,
                StartingPosition = pictureBox5.Left,
                RacetrackLength = pictureBox1.Width - pictureBox5.Width,
                Randomizer = myRandom
            };

            //Initialize all the guy objects
            guys[0] = new Guy()
            {
                Cash = 50,
                MyBet = null,
                MyLabel = joeBetLabel,
                MyRadioButton = joeRadioButton,
                Name = "Joe"
            };
            guys[1] = new Guy()
            {
                Cash = 75,
                MyBet = null,
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton,
                Name = "Bob"
            };
            guys[2] = new Guy()
            {
                Cash = 45,
                MyBet = null,
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton,
                Name = "Al"
            };

            //Set the labels
            foreach (Guy guy in guys)
            {
                guy.MyBet = new Bet();
                guy.ClearBet();
                guy.UpdateLabels();
            }

            minimumBetLabel.Text = $@"Minimum bet is ${BetAmount.Minimum}";
        }

        private void race_Click(object sender, EventArgs e)
        {
            timer1.Start();
            bettingParlor.Enabled = false;
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = guys[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = guys[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = guys[2].Name;
        }

        private void PlaceBet_Click(object sender, EventArgs e)
        {
            if (guys[0].MyRadioButton.Checked)
            {
                if (guys[0].PlaceBet((int)BetAmount.Value, (int)DogToWin.Value))
                {
                    guys[0].UpdateLabels();
                }
            }
            if (guys[1].MyRadioButton.Checked)
            {
                if (guys[1].PlaceBet((int)BetAmount.Value, (int)DogToWin.Value))
                {
                    guys[1].UpdateLabels();
                }
            }
            if (guys[2].MyRadioButton.Checked)
            {
                if (guys[2].PlaceBet((int)BetAmount.Value, (int)DogToWin.Value))
                {
                    guys[2].UpdateLabels();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Dogs[i].Run())
                {
                    var winner = i + 1;
                    timer1.Stop();
                    MessageBox.Show($@"Dog number {winner} wins!", @"We Have A Winner");

                    foreach (Guy guy in guys)
                    {
                        guy.Collect(winner);
                    }

                    foreach (Greyhound dog in Dogs)
                    {
                        dog.TakeStartingPosition();
                    }

                    bettingParlor.Enabled = true;
                    break;
                }
            }
        }
    }
}
