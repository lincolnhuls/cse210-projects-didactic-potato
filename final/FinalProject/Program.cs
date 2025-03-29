namespace FinalProject;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        PlayerForm playerForm = new PlayerForm();
        Application.Run(playerForm);

        Player selectedPlayer = playerForm.SelectedPlayer;

        DifficultyForm difficultyForm = new DifficultyForm();
        Application.Run(difficultyForm);

        Difficulty selectedDifficulty = difficultyForm.SelectedDifficulty;

        Form1 mainForm = new Form1(selectedDifficulty, selectedPlayer);
        Application.Run(mainForm);
    }    
}