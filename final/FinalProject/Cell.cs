// Each spot in the game and its generic methods
public class Cell
{
    private int _row;

    private int _col;

    private bool _isMine;

    private bool _isRevealed;

    private bool _isFlagged;    

    private int _adjacentMines;

    public Cell(int row, int col, bool isMine = false)
    {
        _row = row;
        _col = col;
        _isMine = isMine;
        _isRevealed = false;
        _isFlagged = false;
        _adjacentMines = 0;
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
}