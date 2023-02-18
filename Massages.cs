namespace C_sharp.Exercises__3_;

public class Massages
{
    private Dictionary<string,string> MassageBuffer { get;} = new ();

    public Massages()
    {
        this["Title"] = "Please enter the title of your massage:";
        this["Description"] = "Please enter the Description of your massage:";
    }
    public string this[string key]
    {
        get => MassageBuffer[key];
        
        set => MassageBuffer[key] = value;
    }

}