using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //create an int guess variable to track what part of the pattern the user is at
        int playerGuess = 0;


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1
            Form1.patternList.Clear();
            //TODO: refresh
            Refresh();
            //pause for a bit
            Thread.Sleep(1000);
            //run ComputerTurn()
            ComputerTurn();

        }

        private void ComputerTurn()
        {
            gameScreenLength.Text = $"{Form1.patternList.Count}";
            //get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            Random randGen = new Random();
            Form1.patternList.Add(randGen.Next(0, 4));
            //create a for loop that shows each value in the pattern by lighting up approriate button
            Thread.Sleep(200);


            for (int i = 0; i < Form1.patternList.Count; i++)
            {
                if (Form1.patternList.Count <= 6)
                {
                    if (Form1.patternList[i] == 0)
                    {
                        greenButton.BackColor = Color.LimeGreen;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.green);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(600);
                        greenButton.BackColor = Color.ForestGreen;
                        Refresh();
                        Thread.Sleep(600);

                    }
                    //red button
                    else if (Form1.patternList[i] == 1)
                    {
                        redButton.BackColor = Color.Red;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.red);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(600);
                        redButton.BackColor = Color.DarkRed;
                        Refresh();
                        Thread.Sleep(600);


                    }
                    //yellow button
                    else if (Form1.patternList[i] == 2)
                    {
                        yellowButton.BackColor = Color.Yellow;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.yellow);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(600);
                        yellowButton.BackColor = Color.Goldenrod;
                        Refresh();
                        Thread.Sleep(600);



                    }
                    else if (Form1.patternList[i] == 3)
                    {
                        blueButton.BackColor = Color.Blue;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.blue);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(600);
                        blueButton.BackColor = Color.DarkBlue;
                        Refresh();
                        Thread.Sleep(600);



                    }
                }

                //speed up computer turn at level 7 
                else if (Form1.patternList.Count >= 6 && Form1.patternList.Count <= 10)
                {
                    if (Form1.patternList[i] == 0)
                    {
                        greenButton.BackColor = Color.LimeGreen;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.green);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(300);
                        greenButton.BackColor = Color.ForestGreen;
                        Refresh();
                        Thread.Sleep(300);

                    }
                    //red button
                    else if (Form1.patternList[i] == 1)
                    {
                        redButton.BackColor = Color.Red;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.red);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(300);
                        redButton.BackColor = Color.DarkRed;
                        Refresh();
                        Thread.Sleep(300);


                    }
                    //yellow button
                    else if (Form1.patternList[i] == 2)
                    {
                        yellowButton.BackColor = Color.Yellow;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.yellow);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(300);
                        yellowButton.BackColor = Color.Goldenrod;
                        Refresh();
                        Thread.Sleep(300);



                    }
                    else if (Form1.patternList[i] == 3)
                    {
                        blueButton.BackColor = Color.Blue;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.blue);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(300);
                        blueButton.BackColor = Color.DarkBlue;
                        Refresh();
                        Thread.Sleep(300);



                    }
                }

                //SPEED UP AT LEVEL 10 
                else if (Form1.patternList.Count > 10)
                {
                    if (Form1.patternList[i] == 0)
                    {
                        greenButton.BackColor = Color.LimeGreen;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.green);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(150);
                        greenButton.BackColor = Color.ForestGreen;
                        Refresh();
                        Thread.Sleep(150);

                    }
                    //red button
                    else if (Form1.patternList[i] == 1)
                    {
                        redButton.BackColor = Color.Red;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.red);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(150);
                        redButton.BackColor = Color.DarkRed;
                        Refresh();
                        Thread.Sleep(150);


                    }
                    //yellow button
                    else if (Form1.patternList[i] == 2)
                    {
                        yellowButton.BackColor = Color.Yellow;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.yellow);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(150);
                        yellowButton.BackColor = Color.Goldenrod;
                        Refresh();
                        Thread.Sleep(150);



                    }
                    else if (Form1.patternList[i] == 3)
                    {
                        blueButton.BackColor = Color.Blue;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.blue);
                        soundPlayer.Play();
                        Refresh();
                        Thread.Sleep(150);
                        blueButton.BackColor = Color.DarkBlue;
                        Refresh();
                        Thread.Sleep(150);



                    }

                }
                // set guess value back to 0
                playerGuess = 0;

            }
        }

        //create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //is the value in the pattern list at index [guess] equal to a green?
            if (Form1.patternList[playerGuess] == 0)
            {
                greenButton.BackColor = Color.LimeGreen;
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.green);
                soundPlayer.Play();
                Refresh();
                Thread.Sleep(100);
                greenButton.BackColor = Color.ForestGreen;
                Refresh();
                Thread.Sleep(100);
                playerGuess++;
            }
            else
            {
                GameOver();
            }

            if (playerGuess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[playerGuess] == 1)
            {
                redButton.BackColor = Color.Red;
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.red);
                soundPlayer.Play();
                Refresh();
                Thread.Sleep(100);
                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(100);
                playerGuess++;
            }
            else
            {
                GameOver();
            }

            if (playerGuess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[playerGuess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.yellow);
                soundPlayer.Play();
                Refresh();
                Thread.Sleep(100);
                yellowButton.BackColor = Color.Goldenrod;
                Refresh();
                Thread.Sleep(100);
                playerGuess++;
            }
            else
            {
                GameOver();
            }

            if (playerGuess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[playerGuess] == 3)
            {
                blueButton.BackColor = Color.Blue;
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.blue);
                soundPlayer.Play();
                Refresh();
                Thread.Sleep(100);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                Thread.Sleep(100);
                playerGuess++;
            }
            else
            {
                GameOver();
            }

            if (playerGuess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        public void GameOver()
        {
            // Play a game over sound
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.mistake);
            soundPlayer.Play();
            // close this screen and open the GameOverScreen
            Form1.ChangeScreen(this, new GameOverScreen());
        }
    }
}

