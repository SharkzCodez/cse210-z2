
class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture()
    {

    }

    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>();
        _reference = reference;
        foreach (string word in text.Split(" "))
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
        }
    }

    public void GetDisplayText()
    {
        Console.WriteLine(_reference.ToString());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText());
            Console.Write(" ");
        }
    }
    public void HideRandomWords()
    {
        Random random = new Random();
        int hiddenCount = 0;


        int nonHiddenWords = _words.Count(word => !word.IsHidden());


        if (nonHiddenWords <= 3)
        {
            foreach (var word in _words)
            {
                if (!word.IsHidden())
                {
                    word.Hide(true);
                    hiddenCount++;
                }
            }
        }

        else
        {
            while (hiddenCount < 3)
            {
                int index = random.Next(0, _words.Count);

                if (!_words[index].IsHidden())
                {
                    _words[index].Hide(true);
                    hiddenCount++;
                }
            }
        }
    }


    public bool IsCompletelyHidden()
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