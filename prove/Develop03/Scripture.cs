using System.ComponentModel.DataAnnotations;

public class Scripture 
{
    private string _refrence;

    private List<Word> _words = new List<Word>();

    public string Display()
    {
        Console.Clear();
        Console.WriteLine($"{_refrence}");

        foreach (Word word in _words)
        {
            Console.Write(word.IsHidden() + " ");
        }
        Console.WriteLine($"\n\nPress enter to continue, or type 'quit' to end the program: ");
        string go = Console.ReadLine();
        return go;
    }

    public Scripture(Refrence refrence)
    {
        _refrence = refrence.GetDisplay();
        string[] words = refrence.GetText().Split(' ');
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideWord()
    {
        Random random = new Random();
        int hiddenWords = 0;
        int remainingWords = 0;
        foreach (Word word in _words)
        {
            if (word.GetHidden() == false)
            {
                remainingWords++;
            }
        }
        int wordLimit = 0;
        if (remainingWords < 3)
        {
            wordLimit = remainingWords;
        }
        else
        {
            wordLimit = 3;
        }
        while (hiddenWords < wordLimit)
        {
            int i = random.Next(0, _words.Count);
            if (_words[i].GetHidden() == false)
            {
                _words[i].HideWord();
                hiddenWords++;
            }
        }
    }
    public string CompletelyHidden(){
        int total = 0;
        foreach (Word word in _words)
        {
            if (word.GetHidden())
            {
                total ++;
            }
        }
        if (total == _words.Count)
        {
            return "QUIT";
        }
        else{
            return "";
        }
    }
}