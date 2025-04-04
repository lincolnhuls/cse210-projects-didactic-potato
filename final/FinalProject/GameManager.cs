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
        int flaggedMines = 0;
        int totalCorrectFlags = 0;
        int totalRevealed = 0;
        int totalNonMines = (_board.GetRows() * _board.GetCols()) - _board.GetTotalMines();

        for (int row = 0; row < _board.GetRows(); row++)
        {
            for (int col = 0; col < _board.GetCols(); col++)
            {
                Cell cell = _board.GetCell(row, col);

                if (cell.IsMine() && cell.IsFlagged())
                {
                    flaggedMines++;
                    totalCorrectFlags++;
                }
                else if (!cell.IsMine() && cell.IsRevealed())
                {
                    totalRevealed++;
                }
                else if (!cell.IsMine() && cell.IsFlagged())
                {
                    totalCorrectFlags--;
                }
            }
        }

        if (totalRevealed == totalNonMines || (flaggedMines == _board.GetTotalMines() && totalCorrectFlags == _board.GetTotalMines()))
        {
            _gameWon = true;
        }

        return _gameWon;
    }
}