public class Scripture
{
    private Reference _reference;
    private Random _random = new Random();
    private string _textBlock;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string textBlock)
    {
        _reference = reference;
        _textBlock = textBlock;

        string[] wordList = textBlock.Split(" ");
        foreach (string word in wordList)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }

    public void DisplayScripture()
    {
        foreach (Word word in _words)
        {
            Console.Write(" ");
            Console.Write(word.DisplayWords());
        }
    }

    public void SwitchRandomWords()
    {
        int num = 3;
        while (num > 0)
        {
            int randomIndex = _random.Next(0, _words.Count);
            Word randomWord = _words[randomIndex];
            randomWord.HideWords();
            num -= 1;
        }
    }

    public bool CheckScripture()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}