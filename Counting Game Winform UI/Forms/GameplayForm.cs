using System;                                                    // בס"ד
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Game_Winform_UI.Forms
{
    public partial class GameplayForm : Form
    {
        private Random rnd = new Random();
        private MainMenuForm mainMenuForm;
        private WinformCountingGame game1;

        public GameplayForm(MainMenuForm mainMenuForm, WinformCountingGame game1)
        {
            this.mainMenuForm = mainMenuForm;
            this.game1 = game1;

            InitializeComponent();
            InitializeUI(); // order matters. first set game1
        }

        private void GameplayForm_Shown(object sender, EventArgs e)
        {
            if (game1.ComputerStarts)
                ComputerDoesTurn();
            else SetUIForUserTurn();
        }

        private void InitializeUI()
        {

            if (game1.AdditionMode)
            {
                AddSubtractButton.Text = "Add To Total";
                TotalLabel.Text = "Total: 0";

                TargetLabel.Visible = true;
                TargetLabel.Text = $"Target: {game1.TargetNumber}";

                ComputerAddsLabel.Text = "Computer Adds:";
                UserAddsLabel.Text = "You Add:";
                UserAddsLabel.Location = new Point(10, 22);
                UserNumber.Location = new Point(158, 22);
                UserNumber.Size = new Size(114, 35);
            }
            else
            {
                TotalLabel.Text = "Total: " + game1.TargetNumber;
                AddSubtractButton.Text = "Subtract From Total";
                TargetLabel.Visible = false;

                ComputerAddsLabel.Text = "Computer Subtracts:";
                UserAddsLabel.Text = "You Subtract:";
                UserAddsLabel.Location = new Point(3, 22);
                UserNumber.Location = new Point(184, 22);
                UserNumber.Size = new Size(102, 35);
            }

            game1.CenterLabelHorizontallyInPanel(StatPanel, TotalLabel, TargetLabel);
            game1.CenterLabelHorizontallyInPanel(ComputerPanel, ComputerAddsLabel);

            ModeLabel.Text = $"Mode: {game1.Mode}";
            DifficultyLabel.Text = $"Difficulty: {game1.GetDifficulty()}";

            WinLoseLabel.Visible = false;
            PlayAgainButton.Visible = false;

            UserNumber.Minimum = game1.MinRange;
            UserNumber.Maximum = game1.MaxRange;

            ComputerNumber.Text = "--";

            ResetScoreAndGameNumber();

            game1.AddKeyDownEventToNumericUpDownThatPressesButton(AddSubtractButton, UserNumber);
            game1.AddEventThatExitsApplicationWhenPressESC(this);

            ModeToolTip.SetToolTip(ModeLabel, game1.GetInstructions(false));
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = this.Location;
            mainMenuForm.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }


        private async Task ComputerNumberLoadingAnimation(int sec)
        {
            for (int i = 0; i < sec; i++)
            {
                ComputerNumber.Text = "Loading";
                game1.CenterLabelHorizontallyInPanel(ComputerPanel, ComputerNumber);
                await Task.Delay(250);

                for (int j = 0; j < 3; j++)
                {
                    ComputerNumber.Text += ".";
                    await Task.Delay(250);
                }
            }
        }

        private async void ComputerDoesTurn()
        {
            DisableUserPanel();
            EnableComputerPanel();

            TurnLabel.Visible = true;
            TurnLabel.Text = "Computer's Turn";
            game1.CenterLabelHorizontallyInForm(this, TurnLabel);


            game1.ChangeLabelSize(ComputerNumber, 22);
            await ComputerNumberLoadingAnimation(rnd.Next(1, 4));

            game1.ChangeLabelSize(ComputerNumber, 26);
            ComputerNumber.Text = game1.GetComputerNumberAndUpdateTotal().ToString();

            TotalLabel.Text = "Total: " + game1.CurrentTotal.ToString();

            game1.CenterLabelHorizontallyInPanel(ComputerPanel, ComputerNumber);
            game1.CenterLabelHorizontallyInPanel(StatPanel, TotalLabel);

            if (game1.IsGameOver())
                EndGameOperations(true);
            else SetUIForUserTurn();
        }


        private void SetUIForUserTurn()
        {
            DisableComputerPanel();
            EnableUserPanel();

            TurnLabel.Visible = true;
            TurnLabel.Text = "Your Turn";
            game1.CenterLabelHorizontallyInForm(this, TurnLabel);

            UserNumber.Focus();
            UserNumber.Select(0, UserNumber.Text.Length);
        }

        private void AddSubtractButton_Click(object sender, EventArgs e)
        {
            game1.UpdateTotalWithUserNumber((int)UserNumber.Value);
            TotalLabel.Text = "Total: " + game1.CurrentTotal.ToString();

            game1.CenterLabelHorizontallyInPanel(StatPanel, TotalLabel);

            if (game1.IsGameOver())
                EndGameOperations(false);
            else ComputerDoesTurn();
        }


        private void EndGameOperations(bool computerSender)
        {
            DisableComputerPanel();
            DisableUserPanel();

            PlayAgainButton.Visible = true;
            WinLoseLabel.Visible = true;
            TurnLabel.Visible = false;

            if (game1.IsWin() ^ computerSender)
            {
                WinLoseLabel.ForeColor = Color.SpringGreen;
                WinLoseLabel.Text = "You Win!";
                game1.AddToUserWins();
            }
            else
            {
                WinLoseLabel.ForeColor = Color.Red;
                WinLoseLabel.Text = "You Lose";
                game1.AddToComputerWins();
            }

            ScoreLabel.Text = game1.Score;

            PlayAgainButton.Focus();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            if (!game1.IsScoreZeroZero())
            {
                game1.IncrementGameNumber();
                GameNumberLabel.Text = game1.GameNumber;
            }

            game1.ResetTotal();
            TotalLabel.Text = "Total: " + game1.CurrentTotal;
            game1.CenterLabelHorizontallyInPanel(StatPanel, TotalLabel, TargetLabel);

            WinLoseLabel.Visible = false;
            PlayAgainButton.Visible = false;
            ComputerNumber.Text = "--";

            if (game1.ComputerStarts)
                ComputerDoesTurn();
            else SetUIForUserTurn();
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetScoreAndGameNumber();
        }

        private void ResetScoreAndGameNumber()
        {
            game1.ResetScoreAndGameNumber();

            ScoreLabel.Text = game1.Score;
            GameNumberLabel.Text = game1.GameNumber;
            game1.CenterLabelHorizontallyInPanel(ScorePanel, ScoreLabel, GameNumberLabel);
        }


        private void EnableUserPanel()
        {
            UserPanel.Enabled = true;
            UserPanel.BackColor = Color.DarkSlateGray;
            AddSubtractButton.BackColor = Color.Lime;
            AddSubtractButton.FlatAppearance.BorderSize = 3;
            AddSubtractButton.FlatAppearance.BorderColor = Color.White;
            UserNumber.BackColor = Color.White;
        }
        
        private void DisableUserPanel()
        {
            UserPanel.Enabled = false;
            UserPanel.BackColor = Color.FromArgb(100, 47, 79, 79);
            AddSubtractButton.BackColor = Color.FromArgb(100, 47, 79, 79);
            AddSubtractButton.FlatAppearance.BorderSize = 1;
            AddSubtractButton.FlatAppearance.BorderColor = Color.DarkBlue;
            UserNumber.BackColor = Color.DarkSlateGray;
        }
       
        private void EnableComputerPanel()
        {
            ComputerPanel.Enabled = true;
            ComputerPanel.BackColor = Color.DarkSlateGray;
        }
       
        private void DisableComputerPanel()
        {
            ComputerPanel.Enabled = false;
            ComputerPanel.BackColor = Color.FromArgb(100, 47, 79, 79);
        }


        private void BasadLable_DoubleClick(object sender, EventArgs e)
        {
            CheatSheetToolTip.Show(game1.CheatSheat(), this.BasadLable, BasadLable.Width + 1, -20);
        }

        private void BasadLable_MouseLeave(object sender, EventArgs e)
        {
            CheatSheetToolTip.Hide(BasadLable);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                if (ActiveControl == BackToMainMenuButton && ComputerPanel.Enabled)
                    return true; 
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}