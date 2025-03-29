using System.Drawing.Text;

namespace FinalProject;

public partial class Form1 : Form
{
    private Label _flagLabel;
    private Label _mineLabel;
    private int _flagsPlaced = 0;
    private int _totalMines = 0;

    public Form1(Difficulty difficulty)
    {
        InitializeComponent();
        Board board = new Board(difficulty, form: this);

        _totalMines = board.GetTotalMines();
        int buttonSize = 30;
        int verticalOffset = 30; 
        int gridHeight = board.GetRows() * 30;
        int gridWidth = board.GetCols() * 30;

        this.ClientSize = new Size(gridWidth + 20, gridHeight + 60);
        this.StartPosition = FormStartPosition.CenterScreen;

        _flagLabel = new Label
        {
            Text = "Flags: ",
            AutoSize = true,
            Location = new Point(0, 0),
            TextAlign = ContentAlignment.MiddleLeft
        };

        _mineLabel = new Label
        {
            Text = "Mines: ",
            AutoSize = true,
            Location = new Point((gridWidth/2), 0),
            TextAlign = ContentAlignment.MiddleLeft
        };

        Label bottomLabel = new Label
        {
            Text = "Click a cell to reveal it. If it's a mine, it will show as '*'.",
            AutoSize = true,
            Location = new Point(10, gridHeight + 10 + verticalOffset),
            TextAlign = ContentAlignment.MiddleCenter
        };

        this.Controls.Add(_flagLabel);
        this.Controls.Add(_mineLabel);
        DisplayGrid(board, buttonSize, verticalOffset);
        this.Controls.Add(bottomLabel);
        this.Text = "Minesweeper";
    }

    
    public void UpdateLabels()
    {
        _flagLabel.Text = $"Flags: {_flagsPlaced}";
        _mineLabel.Text = $"Mines: {_totalMines - _flagsPlaced}";
    }

    public void DisplayGrid(Board board, int buttonSize, int verticalOffset)
    {
        int gridButtonSize = buttonSize;
        int girdVerticalOffset = verticalOffset;

        UpdateLabels();

        for (int row = 0; row < board.GetRows(); row++)
        {
            for (int col = 0; col < board.GetCols(); col++)
            {
                Button button = new Button
                {
                    Width = buttonSize,
                    Height = buttonSize,
                    Location = new Point(col * buttonSize, row * buttonSize + verticalOffset),
                    Tag = new Point(row, col)
                };

                button.Click += (sender, e) =>
                {
                    Point position = (Point)button.Tag;
                    Cell cell = board.GetCell(position.X, position.Y);
                    cell.Reveal();

                    if (cell.IsMine())
                    {
                        button.Text = "*";
                        button.BackColor = Color.Red;
                    }
                    else if (cell is Number numbercell)
                    {
                        button.Text = numbercell.CountAdjacentMines().ToString();
                        button.Enabled = false;
                    }
                };

                button.MouseUp += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        if (!button.Enabled) return;

                        if (button.Text == "F")
                        {
                            button.Text = "";
                            button.BackColor = Color.LightGray;
                            _flagsPlaced--;
                        }
                        else
                        {
                            button.Text = "F";
                            button.BackColor = Color.LightGreen;
                            _flagsPlaced++;
                        }
                        UpdateLabels();
                    }
                };
                this.Controls.Add(button);
                button.BackColor = Color.LightGray; // Default color for buttons
            }
        }
    }

    public void UpdateGrid(int row, int col, Cell cell)
    {
        foreach (Control control in this.Controls)
        {
            if (control is Button button && button.Tag is Point tag && tag == new Point(row, col))
            {
                if (cell.IsMine())
                {
                    button.Text = "*";
                    button.BackColor = Color.Red;
                }
                else if (cell is Number numberCell)
                {
                    int adjacentMines = numberCell.CountAdjacentMines();
                    if (adjacentMines > 0)
                    {
                        button.Text = adjacentMines.ToString();
                    }
                    else
                    {
                        button.Text = "";
                    }
                }
            }
        }
    }
}