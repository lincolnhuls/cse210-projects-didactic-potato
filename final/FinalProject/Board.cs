// Handles the game board and all of its pieces
public class Board
{
    private int _rows;

    private int _cols;

    // private int _totalMines;

    // private int _minesRemaining;

    // private int _totalFlags;

    // private bool _isGameOver;

    // private string _difficulty;

    private List<List<Cell>> _grid;

    public Board(int rows, int cols)
    {
        _rows = rows;
        _cols = cols;

        _grid = new List<List<Cell>>();

        InitBoard();
    }

    public void InitBoard()
    {
        for (int row = 0; row < _rows; row++)
        {
            List<Cell> rowList = new List<Cell>();
            for (int col = 0; col < _cols; col++)
            {
                Cell cell = new Cell(row, col);
                rowList.Add(cell);
            }
            _grid.Add(rowList);
        }
    }

    public Cell GetCell(int row, int col)
    {
        return _grid[row][col];
    }

    public int GetRows()
    {
        return _rows;
    }

    public int GetCols()
    {
        return _cols;
    }
}