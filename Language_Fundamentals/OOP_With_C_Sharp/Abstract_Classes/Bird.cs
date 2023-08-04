public class Bird : Animal, ILayEggs
{
    public bool CanFly;
    public int EggsPerBatch {get;set;}
    public Bird(bool canfly, string name, string diet, int epb) : base("Bird",name, diet , false, true)  // <== can replace diet passed down with a variable, but must call it in the program.cs side

    {
        CanFly = canfly;
        EggsPerBatch = epb;
    }

    public void LayEggs()
    {
        Console.WriteLine($"{Name} laid {EggsPerBatch} egg(s)!");
    }

    public override void ShowInfo() //    // Notice the addition of the keyword "override"
    {
        base.ShowInfo();
        Console.WriteLine($"Can Fly: {CanFly}");
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Tweet, tweet, tweet!");
    }
}