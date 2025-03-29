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

            this.Controls.Add(guestButton);
            // this.Controls.Add(loadButton);

            this.Text = "Select Player";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(500, 500);
        }

        private void SetPlayer(string name)
        {
            SelectedPlayer = new Player(name);

            this.Close();
        }
    }
}