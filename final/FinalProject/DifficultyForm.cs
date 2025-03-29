using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DifficultyForm : Form
    {

    public Difficulty SelectedDifficulty;

        public DifficultyForm()
        {

            SelectedDifficulty = new Difficulty("easy");

            Button easyButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Easy",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(100, 40)
            };
            easyButton.Click += (sender, e) => SetDifficulty("easy");

            Button mediumButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Medium",
                Location = new System.Drawing.Point(10, 60),
                Size = new System.Drawing.Size(100, 40)
            };
            mediumButton.Click += (sender, e) => SetDifficulty("medium");

            Button hardButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Hard",
                Location = new System.Drawing.Point(10, 110),
                Size = new System.Drawing.Size(100, 40)
            };
            hardButton.Click += (sender, e) => SetDifficulty("hard");

            this.Controls.Add(easyButton);
            this.Controls.Add(mediumButton);
            this.Controls.Add(hardButton);

            this.Text = "Select Difficulty";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(500, 500);
        }

        private void SetDifficulty(string difficulty)
        {
            SelectedDifficulty = new Difficulty(difficulty);

            this.Close();
        }
    }
}