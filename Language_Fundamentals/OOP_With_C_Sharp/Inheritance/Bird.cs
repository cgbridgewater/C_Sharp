
public class Bird : Animal{
    public string Name;
    public Bird(string diet, string name) : base("Bird", diet , false, true)  // <== can replace diet passed down with a variable, but must call it in the program.cs side

    {
        Name=name;
    }

    public override void ShowInfo() //    // Notice the addition of the keyword "override"
    {
        base.ShowInfo();
        Console.WriteLine($"Name: {Name}");
    }

}