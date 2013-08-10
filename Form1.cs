#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region Declaration

        Image[] diceImages;
        int[] dice;
        Random rand;

        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = DiceGame.Properties.Resources.dice_blank;
            diceImages[1] = DiceGame.Properties.Resources.dice_1;
            diceImages[2] = DiceGame.Properties.Resources.dice_2;
            diceImages[3] = DiceGame.Properties.Resources.dice_3;
            diceImages[4] = DiceGame.Properties.Resources.dice_4;
            diceImages[5] = DiceGame.Properties.Resources.dice_5;
            diceImages[6] = DiceGame.Properties.Resources.dice_6;

            dice = new int[5] { 0, 0, 0, 0, 0 };

            rand = new Random();

        }

        #endregion

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
                ///returns a # from 1-6
            }

            lbl_dice1.Image = diceImages[dice[0]];
            lbl_dice2.Image = diceImages[dice[1]];
            lbl_dice3.Image = diceImages[dice[2]];
            lbl_dice4.Image = diceImages[dice[3]];
            lbl_dice5.Image = diceImages[dice[4]];

        }
    }
}
