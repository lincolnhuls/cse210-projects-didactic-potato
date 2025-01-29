public class Entry {
    // Attributes 
    public string _prompt;

    public string _entryDateTime;

    public string _entryText;

    // Behavior
    public string Display()
    {
        Console.WriteLine($"Date: {_entryDateTime} - Prompt: {_prompt} \n{_entryText} \n");
        string entry = $"Date: {_entryDateTime} - Prompt: {_prompt} \n{_entryText}";
        return entry;
    }
}