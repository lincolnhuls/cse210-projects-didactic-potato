using System.ComponentModel;

public class Word
{
    private string _word;

    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public Word()
    {
        _word = "Test";
        _isHidden = false;
    }
    public string GetWord(string word)
    {
        return _word;
    }
    public string HiddenWord()
    {
        string letters = "";
        for (int i = 0; i < _word.Length; i++)
        {
            letters += "_";
        }
        return letters;
    }
    public string ShownWord()
    {
        string letters = _word;
        return letters;
    }
    public string IsHidden()
    {
        if (_isHidden)
        {
            return HiddenWord();
        }
        else{
            return ShownWord();
        }
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    public bool GetHidden()
    {
        return _isHidden;
    }
}