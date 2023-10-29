using System;
using System.Collections.Generic;
using System.Linq; //This imports System.Linq namespace for LINQ operations.
using System.IO; //This imports System.IO for file operations.
class Reference
{
    public string book, chapter, verseStart, verseEnd;

    public Reference(string v)
    {
        V = v;
    }

    public Reference(string _book, string _chapter, string _verse)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verse;
        verseEnd = _verse;
    }
    //public string Book { get; }
    //public int Chapter { get; }
    //public int StartVerse { get; }
    //public int EndVerse { get; }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = _verseEnd;
    }

    public string V { get; }

    public string GetReference()
    {
        if (verseEnd == "")
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}