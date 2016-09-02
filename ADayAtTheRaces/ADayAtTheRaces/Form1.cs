using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        private Greyhound[] GreyhoundArray = new Greyhound[4];
        private Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            GreyhoundArray[0] = new Greyhound {
                MyPictureBox = dog1PictureBox,
                StartingPosition = dog1PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog1PictureBox.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound
            {
                MyPictureBox = dog2PictureBox,
                StartingPosition = dog2PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog2PictureBox.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound
            {
                MyPictureBox = dog3PictureBox,
                StartingPosition = dog3PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog3PictureBox.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound
            {
                MyPictureBox = dog4PictureBox,
                StartingPosition = dog4PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog4PictureBox.Width,
                Randomizer = MyRandomizer
            };
        }
    }
}