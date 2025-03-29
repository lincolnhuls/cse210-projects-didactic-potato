// // Keeps track of score  and remaining bombs
public class GameManager
{
    private Board _board;
    
    private bool _gameLost;

    private bool _gameWon;

    public GameManager(Board board)
    {
        _board = board;
        _gameWon = false;
        _gameLost = false;
    }

    public Board GetBoard()
    {
        return _board;
    }

    public bool IsGameLost(int row, int col)
    {
        if (_board.GetCell(row, col).IsRevealed() && _board.GetCell(row, col) is Bomb)
        {
            _gameLost = true;
        }
        return _gameLost;
    }

    public bool IsGameWon()
    {
        return false;
    }
}