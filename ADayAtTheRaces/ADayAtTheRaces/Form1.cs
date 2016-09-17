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
        private bool raceOver = false;
        private Random myRandomizer = new Random();
        private Greyhound[] dogs = new Greyhound[4];
        private Guy[] guys = new Guy[3];

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in guys)
            {
                if (guy.MyRadioButton.Checked)
                {
                    if (guy.PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value))
                    {
                        guy.MyLabel.Text = guy.MyBet.GetDescription();
                    }
                    else
                    {
                        MessageBox.Show(guy.Name + " does not have enough money to place a bet!");
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                raceOver = dogs[i].Run();
                if (raceOver)
                {
                    timer1.Stop();
                    int winner = i + 1;
                    MessageBox.Show("The winner is the dog #" + winner);
                    foreach (Guy guy in guys)
                    {
                        guy.Collect(winner);
                    }
                    foreach (Greyhound dog in dogs)
                    {
                        dog.TakeStartingPosition();
                    }
                    break;
                }
            }
        }

        private void Setup()
        {
            dogs[0] = new Greyhound
            {
                MyPictureBox = dog1PictureBox,
                StartingPosition = dog1PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog1PictureBox.Width,
                Randomizer = myRandomizer
            };

            dogs[1] = new Greyhound
            {
                MyPictureBox = dog2PictureBox,
                StartingPosition = dog2PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog2PictureBox.Width,
                Randomizer = myRandomizer
            };

            dogs[2] = new Greyhound
            {
                MyPictureBox = dog3PictureBox,
                StartingPosition = dog3PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog3PictureBox.Width,
                Randomizer = myRandomizer
            };

            dogs[3] = new Greyhound
            {
                MyPictureBox = dog4PictureBox,
                StartingPosition = dog4PictureBox.Left,
                RacetrackLength = racetrackPictureBox.Width - dog4PictureBox.Width,
                Randomizer = myRandomizer
            };

            guys[0] = new Guy
            {
                Name = "Joe",
                Cash = 50,
                MyBet = null,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            guys[1] = new Guy
            {
                Name = "Bob",
                Cash = 75,
                MyBet = null,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            guys[2] = new Guy
            {
                Name = "Al",
                Cash = 45,
                MyBet = null,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }
    }
}