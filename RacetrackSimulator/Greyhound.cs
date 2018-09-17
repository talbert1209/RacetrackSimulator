using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            Randomizer = new Random();
            var speed = Randomizer.Next(1, 4);
            Location += speed;
            MyPictureBox.Left = StartingPosition + Location;

            if (MyPictureBox.Left >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}