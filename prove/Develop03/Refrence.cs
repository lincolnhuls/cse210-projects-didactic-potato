using System.ComponentModel.DataAnnotations;

public class Refrence 
{
    private string _book;

    private int _chapter;

    private int _firstVerse;

    private int _lastVerse;
    
    private string _text;

    public Refrence()
    {
        _book = "John";
        _chapter = 3;
        _firstVerse = 16;   
        _lastVerse = 16;
        _text = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have eternal life.";
    }

    public Refrence(string book, int chapter, int firstVerse, string text) 
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = firstVerse;
        _text = text;
    }
    public Refrence(string book, int chapter, int firstVerse, int lastVerse, string text) 
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        _text = text;
    }
    public string GetText(){
        return _text;
    }
    public string GetDisplay() {
        if (_firstVerse == _lastVerse)
        {
            return $"{_book} {_chapter}:{_firstVerse} -";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse} -";
        }
    }
}