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
            var speed = Randomizer.Next(1, 15);
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