using System;

class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray){
            _words.Add(new Word(wordText));
        }
    }
    public void HideWordAtIndex(int index){
        if (index >= 0 && index <_words.Count){
            _words[index].Hide();
        }
    }
    public string GetDisplayText(){
        string displayText = "";
        foreach (Word word in _words){
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
    public int WordCount => _words.Count;
}