using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    // Identify the different parts of the reference.
    private string _book;
    private string _chapter;
    private string _start;
    public string _end;

    // I use two constructors - one for a one verse scripture, and one for a multi-verse scripture.
    public Reference(string book, string chapter, string start)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
    }

    public Reference(string book, string chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    // I use two Get methods - one for a reference with one verse, and one for a reference with multiple verses
    public string GetOneVerseReference()
    {
        return $"{_book} {_chapter}:{_start}";
    }

    public string GetManyVerseReference()
    {
        return $"{_book} {_chapter}: {_start}-{_end}";
    }
}