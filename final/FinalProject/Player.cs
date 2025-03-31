// Stores player information like high scores that allow for multiple users
public class Player
{
    private string _name;

    public void CreatePlayer(string name)
    {
        _name = name;
    }

    public Player()
    {
        _name = "Guest";
    }

    public Player(string name)
    {
        _name = name;
    }
}
