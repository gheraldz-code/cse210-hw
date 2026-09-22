public class Word
{
    private string _text;
    private bool _isHidden;

    public Word() {
        _text = "";
        _isHidden = false;
    }

    public Word(string text) {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
        
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        if (IsHidden()) // if the word is hidden
        {
            string hiddenText = "";
            foreach (char letter in _text)
            {
                hiddenText = hiddenText + "_";
            }
            return hiddenText; // show "_" for each letter of the word
        }
        else
        {
            return _text; // or the word
        }
    }
}