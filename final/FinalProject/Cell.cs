// Each spot in the game and its generic methods
public class Cell
{
    protected int _row;

    protected int _col;

    protected bool _isMine;

    protected bool _isRevealed;

    protected bool _isFlagged;    

    protected int _adjacentMines;

    protected bool _gameOver;

    public Cell(int row, int col, bool isMine = false)
    {
        _row = row;
        _col = col;
        _isMine = isMine;
        _isRevealed = false;
        _isFlagged = false;
        _adjacentMines = 0;
        _gameOver = false;
    }

    public void ToggleFlag()
    {
        _isFlagged = !_isFlagged;
    }

    public virtual void Reveal()
    {
        _isRevealed = true;
    }

    public bool IsRevealed()
    {
        return _isRevealed;
    }

    public bool IsFlagged()
    {
        return _isFlagged;
    }

    public bool IsMine()
    {
        return _isMine;
    }
}