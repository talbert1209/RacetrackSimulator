using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class Form1 : Form
    {
        Greyhound[] Dogs = new Greyhound[4];
        Random myRandom = new Random();
       
        public Form1()
        {
            InitializeComponent();

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
        }

        private void race_Click(object sender, EventArgs e)
        {
            foreach (Greyhound dog in Dogs)
            {
                dog.Run();
            }
        }
    }
}
