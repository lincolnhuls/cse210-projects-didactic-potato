// A spefic type of cell for handling bombs in the game
public class Bomb : Cell
{
    private Board _board;

    public Bomb(int row, int col, Board board) : base(row, col, true)
    {
        _board = board;
    }

    public override void Reveal()
    {
        base.Reveal();
        // _board.GameOver();
    }
}