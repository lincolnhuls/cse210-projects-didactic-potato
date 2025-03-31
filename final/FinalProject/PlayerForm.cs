using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PlayerForm : Form
    {

        public Player SelectedPlayer;

        public PlayerForm()
        {
            SelectedPlayer = new Player();

            Button guestButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Guest",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(100, 40)
            };

            guestButton.Click += (sender, e) => SetPlayer("");

            Button loadPlayer = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Load Player",
                Location = new System.Drawing.Point(10, 60),
                Size = new System.Drawing.Size(100, 40)
            };

            loadPlayer.Click += (sender, e) => LoadPlayer("players.txt");

            Button newPlayer = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "New Player",
                Location = new System.Drawing.Point(10, 110),
                Size = new System.Drawing.Size(100, 40)
            };

            newPlayer.Click += (sender, e) => CreateNewPlayer("");

            Button deletePlayer = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Delete Player",
                Location = new System.Drawing.Point(10, 160),
                Size = new System.Drawing.Size(100, 40)
            };

            deletePlayer.Click += (sender, e) => DeletePlayer();

            this.Controls.Add(guestButton);
            this.Controls.Add(loadPlayer);
            this.Controls.Add(newPlayer);
            this.Controls.Add(deletePlayer);

            this.Text = "Select Player";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(500, 500);
        }

        private void SetPlayer(string name)
        {
            SelectedPlayer = new Player(name);
            this.Close();
        }

        private void LoadPlayer(string filename)
        {
            string[]lines = File.ReadAllLines(filename);
            int yOffset = 10;

            foreach (string line in lines)
            {
                Button playerButton = new Button
                {
                    FlatStyle = FlatStyle.Flat,
                    Text = line,
                    Location = new System.Drawing.Point(150, yOffset),
                    Size = new System.Drawing.Size(100, 40)
                };

                this.Controls.Add(playerButton);
                playerButton.Click += (sender, e) => SetPlayer(line);

                yOffset += 50;
            }
        }

        private void CreateNewPlayer(string name)
        {
            string playerName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name: ", "New Player", "Player1", -1, -1);
            if (!string.IsNullOrEmpty(playerName))
            {
                SelectedPlayer = new Player(playerName);

                using (StreamWriter outputFile = new StreamWriter("players.txt", true))
                {
                    outputFile.WriteLine($"{playerName}");
                }

                this.Close();
            }
        }

        private void DeletePlayer()
        {
            string playerName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the player you would like to delete: ", "New Player", "Player1", -1, -1);

            string[]lines = File.ReadAllLines("players.txt");
            List<string> updatedLines = new List<string>();
            foreach (string line in lines) 
            {
                if (line != playerName)
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines("players.txt", updatedLines);
        }
    }
}