public class Word
{
    private string _word;
    private bool _isHidden;


    public Word(string word)
    {
        _isHidden = false;
        _word = word;
    }

    public void HideWords()
    {
        _isHidden = true;
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string DisplayWords()
    {
        if (_isHidden == true)
        {
            return "____";
        }

        else
        {
            return _word;
        }
    }
}