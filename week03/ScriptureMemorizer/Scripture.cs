public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        string[] splitText = text.Split(" ");
        foreach (string aWord in splitText)
        {
            Word theWord = new Word(aWord);
            _words.Add(theWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        // look for there are no hidden words
        var theWords = _words
            .Where(p => !p.IsHidden()) // only the words unhidden
            .ToList();

        if (theWords.Count == 0) // if all the words are hidden
            return; // nothing happens
        
        int quantity = Math.Min(numberToHide, theWords.Count); // take wheter posible 3 elements

        // choose the quantity of elements to hide
        var noHiddenWords = theWords
            .OrderBy(x => _random.Next()) //to hide randomly
            .Take(quantity) // the quantity of words to hide
            .ToList()
        ;
        // here applies the change
        foreach (var element in noHiddenWords)
        {
            element.Hide();
        }
    }
    public string GetDisplayText()
    {
        string fullScripture = "";
        foreach (Word theWord in _words)
        {
            fullScripture = fullScripture + " " + theWord.GetDisplayText(); // how to show the scripture
        }
        return $"{_reference.GetDisplayText()}>>{fullScripture}";
    }
    public bool IsCompletelyHidden()
    {
        bool flag = true;
        foreach (Word theWord in _words) // look for all the words
        {
            if (!theWord.IsHidden()) // but one of the words is hidden
            {
                flag = false; // put the mark
                break; // the search finishes
            }
        }
        return flag;
    }
}