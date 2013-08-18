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

namespace DiceGame
{
    public partial class Form1 : Form
    {
        #region Declaration

        Image[] diceImages;
        Player player1, player2;

        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");

            lbl_p1Name.Text = player1.Name;
            lbl_p2Name.Text = player2.Name;

            diceImages = new Image[7];
            diceImages[0] = DiceGame.Properties.Resources.dice_blank;
            diceImages[1] = DiceGame.Properties.Resources.dice_1;
            diceImages[2] = DiceGame.Properties.Resources.dice_2;
            diceImages[3] = DiceGame.Properties.Resources.dice_3;
            diceImages[4] = DiceGame.Properties.Resources.dice_4;
            diceImages[5] = DiceGame.Properties.Resources.dice_5;
            diceImages[6] = DiceGame.Properties.Resources.dice_6;
        }

        #endregion

        #region Game Methods

        private void btn_p1RollDice_Click(object sender, EventArgs e)
        {
            if (!player1.Played)
            {
                player1.RollDice();

                lbl_p1dice1.Image = diceImages[player1.Dice[0]];
                lbl_p1dice2.Image = diceImages[player1.Dice[1]];
                lbl_p1dice3.Image = diceImages[player1.Dice[2]];
                lbl_p1dice4.Image = diceImages[player1.Dice[3]];
                lbl_p1dice5.Image = diceImages[player1.Dice[4]];
                lbl_p1DisplayResults.Text = player1.Result;

                player1.Played = true;

                CheckWinner();
            }
        }

        private void btn_p2RollDice_Click(object sender, EventArgs e)
        {
            if (!player2.Played)
            {
                player2.RollDice();

                lbl_p2dice1.Image = diceImages[player2.Dice[0]];
                lbl_p2dice2.Image = diceImages[player2.Dice[1]];
                lbl_p2dice3.Image = diceImages[player2.Dice[2]];
                lbl_p2dice4.Image = diceImages[player2.Dice[3]];
                lbl_p2dice5.Image = diceImages[player2.Dice[4]];
                lbl_p2DisplayResults.Text = player2.Result;

                player2.Played = true;

                CheckWinner();
            }
        }

        private void CheckWinner()
        {
            if (player1.Played && player2.Played)
            {
                if (player1.HandRank > player2.HandRank)
                {
                    lbl_compare.Text = player1.Name + " Wins!";
                }

                else if (player2.HandRank > player1.HandRank)
                {
                    lbl_compare.Text = player2.Name + " Wins!";
                }

                else if (player1.HandRank == 8 && player2.HandRank == 8)
                {
                    if (player1.Mod1 > player2.Mod1 &&
                        player1.Mod2 > player2.Mod2)
                    {
                        lbl_compare.Text = player1.Name + " Wins!";
                    }

                    else if (player1.Mod2 > player2.Mod1 &&
                             player1.Mod2 > player2.Mod2)
                    {
                        lbl_compare.Text = player1.Name + " Wins!";
                    }

                    else if (player1.Mod1 == player2.Mod1 &&
                             player1.Mod2 == player2.Mod2 ||
                             player1.Mod2 == player2.Mod1 &&
                             player1.Mod2 == player2.Mod1)
                    {
                        if (player1.Mod3 > player2.Mod3)
                        {
                            lbl_compare.Text = player1.Name + " Wins!";
                        }

                        else if (player2.Mod3 > player1.Mod3)
                        {
                            lbl_compare.Text = player2.Name + " Wins!";
                        }

                        else
                        {
                            lbl_compare.Text = "Tie!";
                        }
                    }
                }
                else if (player1.HandRank == player2.HandRank)
                {
                    if (player1.Mod1 > player2.Mod1)
                        lbl_compare.Text = player1.Name + " Wins!";
                    else if (player2.Mod1 > player1.Mod1)
                        lbl_compare.Text = player2.Name + " Wins!";
                    else if (player1.Mod1 == player2.Mod2)
                    {
                        if (player1.Mod2 > player2.Mod2)
                            lbl_compare.Text = player1 + " Wins!";
                        else if (player2.Mod2 > player1.Mod2)
                            lbl_compare.Text = player2 + " Wins!";
                        else if (player1.Mod2 == player2.Mod2)
                        {
                            if (player1.Mod3 > player2.Mod3)
                                lbl_compare.Text = player1 + " Wins!";
                            else if (player2.Mod3 > player1.Mod3)
                                lbl_compare.Text = player2 + " Wins!";
                            else if (player1.Mod3 == player2.Mod3)
                                lbl_compare.Text = "Tie!";
                        }
                    }
                }
                player1.ResetPlayer();
                player2.ResetPlayer();
            }
            else if (player1.Played && !player2.Played)
                lbl_compare.Text = "Waiting for " + player2.Name + " to roll";
            else if (player2.Played && !player1.Played)
                lbl_compare.Text = "Waiting for " + player1.Name + " to roll";
        }
        #endregion
    } 
}