
public class Cat : Animal{
    public string FurType;

    public Cat(string furtype, string diet, string name) : base("Cat",name, diet , true, true)  // <== can replace diet passed down with a variable, but must call it in the program.cs side

    {
        FurType = furtype;
    }

    public override void ShowInfo() //    // Notice the addition of the keyword "override"
    {
        base.ShowInfo();
        Console.WriteLine($"Fur Type: {FurType}");
    }

}