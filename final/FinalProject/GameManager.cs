// // Keeps track of score  and remaining bombs
// public class GameManager
// {
//     private Board _board;
//     private int _flagsPlaced;
//     private int _totalMines;
//     private Label _scoreLabel;
//     private Label _bombsLabel;

//     public GameManager(Difficulty difficulty, Label scoreLabel, Label bombsLabel)
//     {
//         _board = new Board(difficulty.GetRows(), difficulty.GetCols(), difficulty.GetTotalMines());
//         _flagsPlaced = 0;
//         _totalMines = difficulty.GetTotalMines();
//         _scoreLabel = scoreLabel;
//         _bombsLabel = bombsLabel;

//         UpdateLabels();
//     }

//     public void UpdateLabels()
//     {
//         _scoreLabel.Text = $"Score: {_flagsPlaced}";
//         _bombsLabel.Text = $"Bombs Left: {_totalMines - _flagsPlaced}";
//     }

//     public Board GetBoard()
//     {
//         return _board;
//     }
// }