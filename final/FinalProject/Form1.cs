namespace FinalProject;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // RunTests();
        int rows = 50;
        int cols = 50;
        Board board = new Board(rows, cols);
        DisplayGrid(board);
    }

    public void RunTests()
    {
        int rows = 5;
        int cols = 5;
        Board board = new Board(rows, cols);

        if (board == null)
        {
            MessageBox.Show("Board initialization failed.");
            return;
        }

        bool boardIsCorrect = true;
        for (int row = 0; row < rows; row++)
        {
            for (int colIndex = 0; colIndex < cols; colIndex++) // Renamed 'col' to 'colIndex'
            {
                Cell cell = board.GetCell(row, colIndex);
                if (cell == null)
                {
                    boardIsCorrect = false;
                    break;
                }
            }
            if (!boardIsCorrect)
            {
                MessageBox.Show($"Cell is not initialized correctly.");
                return;
            }
        }

        // Test 3: Test Cell functionality
        Cell testCell = board.GetCell(2, 2);
        if (testCell == null)
        {
            MessageBox.Show("Failed to retrieve a cell from the board!");
            return;
        }

        // Test ToggleFlag
        testCell.ToggleFlag();
        if (!testCell.IsFlagged())
        {
            MessageBox.Show("Cell.ToggleFlag() failed!");
            return;
        }
        // Test Reveal
        testCell.Reveal();
        if (!testCell.IsRevealed())
        {
            MessageBox.Show("Cell.Reveal() failed!");
            return;
        }

        // If all tests pass
        MessageBox.Show("All tests passed successfully!");
    }

    public void DisplayGrid(Board board)
    {
        int buttonSize = 30;
        for (int row = 0; row < board.GetRows(); row++)
        {
            for (int col = 0; col < board.GetCols(); col++)
            {
                Button button = new Button
                {
                    Width = buttonSize,
                    Height = buttonSize,
                    Location = new Point(col * buttonSize, row * buttonSize),
                    Tag = new Point(row, col)
                };

                this.Controls.Add(button);
            }
        }
    }
}
