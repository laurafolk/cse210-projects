using System;

class Word
{
    public string Text { get; private set; } //This is encapsulated data.
    public bool Hidden { get; private set; } // This also is encapsulated data.
    public Word(string text)
    {
        Text = text;  // This is constructor and setting the value of the text.
        Hidden = false; //Will initialize hidden.
    }
    public void Hide()
    {
        Hidden = true; //Shows method to modify to hidden encapsulated.
    }
    public void Reveal()
    {
        Hidden = false; //Shows method to modify to hidden encapsulated.
    }
    public string GetWord() //GetDisplayText()
    {
        if (Hidden)
        {
            //This gives underscores if the word is hidden and the same length as the word.
            return new string('_', Text.Length);
        }
        else
        {
            return Text; //This will return the word
        }
    }

    //public override string ToString()
    //{
    // Method: Check if all words in the scripture are hidden.
    //    return GetDisplayText();
    //}
}
