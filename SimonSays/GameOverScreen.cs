﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern
            patternLabel.Text = $"Pattern Length: {Form1.patternList.Count}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close this screen and open the MenuScreen
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //close this screen and open the MenuScreen
            Form1.ChangeScreen(this, new MenuScreen());

        }
    }
}
