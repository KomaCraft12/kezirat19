namespace kezirat;

public class Kezirat
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int PageCount { get; set; }
    
    public Kezirat(string title, string author, int year, int pageCount)
    {
        Title = title;
        Author = author;
        Year = year;
        PageCount = pageCount;
    }
    
    public override string ToString()
    {
        return $"{Title} ({Year}) by {Author} - {PageCount} pages";
    }
}