#region License & Copyright
/*
 * frmNewGame.cs
 * Copyright (C)2007 John Sedlak (http://jsedlak.org)
 * 
 * Purpose: Allows the user to start a new game by
 * selecting options.
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathGame
{
    public partial class frmNewGame : Form
    {
        private bool m_spGame = true;

        public frmNewGame()
        {
            InitializeComponent();

            ValidateNames();
        }

        public bool SinglePlayerGame
        {
            get
            {
                return m_spGame;
            }
        }

        public string DestinationName
        {
            get { return DestinationBox.Text; }
            set { DestinationBox.Text = value; }
        }

        public string PlayerOneName
        {
            get { return string.IsNullOrEmpty(PlayerOneNameTextBox.Text) ? "Player One" : PlayerOneNameTextBox.Text; }
            set { PlayerOneNameTextBox.Text = value; }
        }

        public string PlayerTwoName
        {
            get { return string.IsNullOrEmpty(PlayerTwoNameTextBox.Text) ? "Player Two" : PlayerTwoNameTextBox.Text; }
            set { PlayerTwoNameTextBox.Text = value; }
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            m_spGame = true;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            m_spGame = false;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            //Application.Exit();
            this.Close();
        }

        private void PlayerOneNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNames();
        }

        private void PlayerTwoNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNames();
        }

        public void ValidateNames()
        {
            /*
            bool result = !string.IsNullOrEmpty(PlayerOneNameTextBox.Text) && !string.IsNullOrEmpty(PlayerTwoNameTextBox.Text);

            this.btnSingle.Enabled = result;
            this.btnMulti.Enabled = result;
            */
        }
    }
}