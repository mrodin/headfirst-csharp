﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
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
            throw new NotImplementedException();
        }

        public void ClearBet()
        {
            throw new NotImplementedException();
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            throw new NotImplementedException();
        }

        public void Collect(int Winner)
        {
            throw new NotImplementedException();
        }
    }
}
