﻿#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

#endregion

namespace DiceGame
{
    class Player
    {
        #region Decleration

        int[] dice;
        int[] diceResults;
        static Random rand;
        bool played = false;
        int handRank, mod1, mod2, mod3;
        string result, name;

        #endregion

        #region Properties

        public int[] Dice
        {
            get { return dice; }

        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public bool Played
        {
            set { played = value; }
            get { return played; }
        }

        public string Result
        {
            get { return result; }
        }

        public int HandRank
        {
            get { return handRank; }
        }

        public int Mod1
        {
            get { return mod1; }
        }

        public int Mod2
        {
            get { return mod2; }
        }

        public int Mod3
        {
            get { return mod3; }
        }

        #endregion

        #region Initialization

        public Player(string playerName)
        {
            name = playerName;

            dice = new int[5] { 0, 0, 0, 0, 0 };

            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };

            result = "Roll the Dice";

            rand = new Random();

            handRank = 0;
            mod1 = 0;
            mod2 = 0;
            mod3 = 0;

            played = false;

        }

        #endregion

        #region Public Methods

        public void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
                ///returns a # from 1-6

                switch (dice[i])
                {
                    case 1:
                        diceResults[0]++;
                        break;
                    case 2:
                        diceResults[1]++;
                        break;
                    case 3:
                        diceResults[2]++;
                        break;
                    case 4:
                        diceResults[3]++;
                        break;
                    case 5:
                        diceResults[4]++;
                        break;
                    case 6:
                        diceResults[5]++;
                        break;
                }
            }
            GetResults();
        }

        public void ResetPlayer()
        {
            for (int i = 0; i < diceResults.Length; i++)
                diceResults[i] = 0;

            for (int i = 0; i < dice.Length; i++)
                dice[i] = 0;

            played = false;

            mod1 = 0;
            mod2 = 0;
            mod3 = 0;
        }

        #endregion

        #region Private Methods

        private void GetResults()
        {
            bool fiveKind = false,
                fourKind = false,
                highStraight = false,
                lowStraight = false,
                fullHouse = false,
                threeKind = false,
                twoPair = false,
                onePair = false,
                haveSix = false,
                haveFive = false,
                haveFour = false,
                haveThree = false,
                haveTwo = false,
                haveOne = false;

            for (int i = 0; i < diceResults.Length; i++)
            {
                if (diceResults[i] == 5)
                {
                    fiveKind = true;
                    mod1 = i;
                }
                else if (diceResults[i] == 4)
                {
                    fourKind = true;
                    mod1 = i;
                }
                else if (diceResults[1] == 1 &&
                         diceResults[2] == 1 &&
                         diceResults[3] == 1 &&
                         diceResults[4] == 1 &&
                         diceResults[5] == 1)
                    highStraight = true;
                else if (diceResults[0] == 1 &&
                         diceResults[1] == 1 &&
                         diceResults[2] == 1 &&
                         diceResults[3] == 1 &&
                         diceResults[4] == 1)
                    lowStraight = true;
                else if (diceResults[i] == 3)
                {
                    threeKind = true;
                    mod1 = i;

                    for (int j = 0; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2)
                        {
                            fullHouse = true;
                            mod2 = j;
                        }
                    }
                }
                else if (diceResults[i] == 2)
                {
                    onePair = true;
                    if (mod1 == 0)
                    {
                        mod1 = i;
                    }

                    for (int j = i + 1; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2)
                            twoPair = true;
                        if (mod2 == 0)
                        {
                            mod2 = j;
                        }
                    }
                }
            }

            for (int i = 0; i < dice.Length; i++)
            {
                switch (dice[i])
                {
                    case 6:
                        haveSix = true;
                        mod3 += 6;
                        break;
                    case 5:
                        haveFive = true;
                        mod3 += 5;
                        break;
                    case 4:
                        haveFour = true;
                        mod3 += 4;
                        break;
                    case 3:
                        haveThree = true;
                        mod3 += 3;
                        break;
                    case 2:
                        haveTwo = true;
                        mod3 += 2;
                        break;
                    case 1:
                        haveOne = true;
                        mod3 += 1;
                        break;
                }
            }

            if (fiveKind)
            {
                result = "Five of a kind!";
                handRank = 14;
            }
            else if (fourKind)
            {
                result = "Four of a kind!";
                handRank = 13;
            }
            else if (highStraight)
            {
                result = "High Straight!";
                handRank = 12;
            }
            else if (lowStraight)
            {
                result = "Low Straight!";
                handRank = 11;
            }
            else if (fullHouse)
            {
                result = "Full House!";
                handRank = 10;
            }
            else if (threeKind)
            {
                result = "Three of a kind!";
                handRank = 9;
            }
            else if (twoPair)
            {
                result = "Two Pair!";
                handRank = 8;
            }
            else if (onePair)
            {
                result = "Pair!";
                handRank = 7;
            }
            else if (haveSix)
            {
                result = "You have Crap";
                //Six High
                handRank = 6;
            }
            else if (haveFive)
            {
                result = "You have Crap";
                handRank = 5;
            }
            else if (haveFour)
            {
                result = "You have Crap";
                handRank = 4;
            }
            else if (haveThree)
            {
                result = "You Have Crap";
                handRank = 3;
            }
            else if (haveTwo)
            {
                result = "You Have Crap";
                handRank = 2;
            }
            else if (haveOne)
            {
                result = "You have Crap";
                handRank = 1;
            }
        }

        #endregion

    }
}
