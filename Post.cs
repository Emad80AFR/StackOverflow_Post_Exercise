using System.Globalization;

namespace C_sharp.Exercises__3_;

public class Post
{
    public string? Title { get;}
    public string? Description { get;}
    public string? CreateTime { get;}
    public int Vote { get;  private set; }

    private readonly Massages _internalMassage = new();

    public Post()
    {
        var result = this.SetPost();
        this.Title = result[0];
        this.Description = result[1];
        this.CreateTime = result[2];
        this.Vote = 0;
    }

    public List<string?> SetPost()
    {
        var functionOutput = new List<string?>();
        Console.WriteLine(_internalMassage["Title"]);
        functionOutput.Add(Console.ReadLine()); 

        Console.WriteLine(_internalMassage["Description"]);
        functionOutput.Add(Console.ReadLine());

        functionOutput.Add(DateTime.Now.Date.ToString(CultureInfo.InvariantCulture)); 

        return functionOutput;
    }

    public void Up_Vote()
    {
        this.Vote ++;
    }
    public void Down_Vote()
    {
        this.Vote --;
    }

    public int CurrentVoteValue()
    {
        return this.Vote;
    }

    public override string ToString()
    {
        return $"Title:{this.Title}\n" +
               $"Massage:{this.Description}({this.CreateTime})";
    }
}