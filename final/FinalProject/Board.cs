// Handles the game board and all of its pieces
using FinalProject;

public class Board
{
    private int _rows;

    private int _cols;

    private int _totalMines;

    private Form1 _form;

    // private int _minesRemaining;

    // private int _totalFlags;

    // private bool _isGameOver;

    // private string _difficulty;

    private List<List<Cell>> _grid;

    // public Board(int rows, int cols, Form1 form, string difficulty)
    // {
    //     _rows = rows;
    //     _cols = cols;
    //     _form = form;
    //     _difficulty = difficulty;

    //     _grid = new List<List<Cell>>();

    //     InitBoard();
    // }

    public Board(Difficulty difficulty, Form1 form)
    {
        _form = form;
        _rows = difficulty.GetRows();
        _cols = difficulty.GetCols();
        _totalMines = difficulty.GetTotalMines();

        _grid = new List<List<Cell>>();

        InitBoard();
    }

    public void InitBoard()
    {
        Random random = new Random();
        int minesPlaced = 0;
        int totalMines = _totalMines;

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

        while (minesPlaced < totalMines)
        {
            int randRow = random.Next(0, _rows);
            int randCol = random.Next(0, _cols);

            if (!(_grid[randRow][randCol] is Bomb))
            {
                _grid[randRow][randCol] = new Bomb(randRow, randCol, this);
                minesPlaced++;
            }
        }

        for (int row = 0; row < _rows; row++)
        {
            for (int col = 0; col < _cols; col++)
            {
                if (!(_grid[row][col] is Bomb))
                {
                    _grid[row][col] = new Number(row, col, this);
                }
            }
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

        public bool IsValidCell(int row, int col)
    {
        if (row >= 0 && row < GetRows() && col >= 0 && col < GetCols())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetTotalMines()
    {
        return _totalMines;
    }

    public Form1 GetForm()
    {
        return _form;
    }

    // public string SetDifficulty(string difficulty)
    // {
    //     _difficulty = difficulty;
    //     return _difficulty;
    // }
}