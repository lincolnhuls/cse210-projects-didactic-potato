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
        if (IsRevealed())
            return;

        _adjacentMines = CountAdjacentMines();
        base.Reveal();

        // Update the UI for the current cell
        if (_board.GetForm() is Form1 form)
        {
            form.UpdateGrid(_row, _col, this);
        }

        // If there are no adjacent mines, reveal all neighbors
        if (_adjacentMines == 0)
        {
            FloodFill(_row, _col);
        }
    }

    public void FloodFill(int row, int col)
    {
        for (int r = row - 1; r <= row + 1; r++)
        {
            for (int c = col - 1; c <= col + 1; c++)
            {
                if (r == row && c == col)
                {
                    continue;
                }

                if (_board.IsValidCell(r, c))
                {
                    Cell neighbor = _board.GetCell(r, c);

                    if (neighbor.IsMine() || neighbor.IsRevealed() || neighbor.IsFlagged())
                    {
                        continue;
                    }

                    if (neighbor is Number numberCell)
                    {
                        numberCell._adjacentMines = numberCell.CountAdjacentMines();
                        neighbor.Reveal();

                        if (numberCell._adjacentMines == 0)
                        {
                            numberCell.FloodFill(r, c);
                        }
                    }
                }
            }
        }
    }

    public void RevealAdjacentCells(int row, int col)
    {
        if (!_isRevealed)
        {
            return;
        }
        
        int adjacentFlags = 0;
        
        for (int r = row - 1; r <= row + 1; r++)
        {
            for (int c = col - 1; c <= col + 1; c++)
            {
                if (r == row && c == col)
                {
                    continue;
                }
                
                if (_board.IsValidCell(r, c) && _board.GetCell(r, c).IsFlagged())
                {
                    adjacentFlags++;
                }
            }
        }
        
        if (adjacentFlags == _adjacentMines)
        {
            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = col - 1; c <= col + 1; c++)
                {
                    if (r == row && c == col)
                    {
                        continue;
                    }
                    
                    if (_board.IsValidCell(r, c))
                    {
                        Cell neighbor = _board.GetCell(r, c);
                        if (!neighbor.IsRevealed() && !neighbor.IsFlagged())
                        {
                            neighbor.Reveal();
                        }
                    }
                }
            }
        }
    }
}