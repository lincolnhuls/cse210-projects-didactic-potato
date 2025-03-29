// Stores difficulties and sets board size and mine number
public class Difficulty
{
    private int _rows;

    private int _cols;

    private int _totalMines;

    public Difficulty(string difficulty)
    {
        if (difficulty == "easy")
        {
            _rows = 9;
            _cols = 9;
            _totalMines = 10;
        }

        else if (difficulty == "medium")
        {
            _rows = 16;
            _cols = 16;
            _totalMines = 40;
        }

        else if (difficulty == "hard")
        {
            _rows = 16;
            _cols = 30;
            _totalMines = 99;
        }
    }

    public Difficulty(int rows, int cols, int totalMines)
    {
        _rows = rows;
        _cols = cols;
        _totalMines = totalMines;
    }

    public int GetRows()
    {
        return _rows;
    }
    
    public int GetCols()
    {
        return _cols;
    }

    public int GetTotalMines()
    {
        return _totalMines;
    }
}