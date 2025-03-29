// Specific type of cell that handles number specific cells
using FinalProject;

public class Number : Cell
{

    private Board _board;

    public Number(int row, int col, Board board) : base(row, col)
    {
        _board = board;
    }

    public int CountAdjacentMines()
    {
        int count = 0;
        for (int r = _row -1; r <= _row + 1; r++)
        {
            for (int c = _col - 1; c <= _col + 1; c++)
            {
                if (r == _row && c == _col)
                {
                    continue;
                }

                if (_board.IsValidCell(r, c) && _board.GetCell(r, c).IsMine())
                {
                    count++;
                }
            }
        }
        return count;
    }

    public override void Reveal()
{
    base.Reveal();

    // Update the UI for the current cell
    if (_board.GetForm() is Form1 form)
    {
        // form.UpdateGrid(_row, _col, this);
    }

    // If there are no adjacent mines, reveal all neighbors
    if (_adjacentMines == 0)
    {
        for (int r = _row - 1; r <= _row + 1; r++)
        {
            for (int c = _col - 1; c <= _col + 1; c++)
            {
                if (r == _row && c == _col)
                {
                    continue; // Skip the current cell
                }

                if (_board.IsValidCell(r, c))
                {
                    Cell neighbor = _board.GetCell(r, c);

                    // Reveal the neighbor if it is not already revealed
                    if (!neighbor.IsRevealed())
                    {
                        neighbor.Reveal();

                        // Recursively reveal neighbors if the neighbor has no adjacent mines
                        if (neighbor is Number numberCell && numberCell._adjacentMines == 0)
                        {
                            numberCell.Reveal();
                        }
                    }
                }
            }
        }
    }
}
}