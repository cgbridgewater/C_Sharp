
public class Reptile : Animal, ILayEggs
{
    public int EggsPerBatch {get;set;}
    public Reptile(string name, string diet, int epb) : base("Snake",name, diet , false, true)  // <== can replace diet passed down with a variable, but must call it in the program.cs side

    {
        EggsPerBatch = epb;
    }

    public void LayEggs()
    {
        Console.WriteLine($"{Name} laid {EggsPerBatch} egg(s)!");
    }

    public override void ShowInfo() //    // Notice the addition of the keyword "override"
    {
        base.ShowInfo();
    }

}