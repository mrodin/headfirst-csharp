using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public int Location = 0;
        public PictureBox MyPictureBox = null;
        public Random Randomizer;

        public bool Run()
        {
            int numberOfSteps = Randomizer.Next(1, 5);
            Location += numberOfSteps;
            MyPictureBox.Left = StartingPosition + Location;

            if (Location >= RacetrackLength)
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = 9;
        }
    }
}
