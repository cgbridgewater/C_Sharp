
public class Dog : Animal{
    public string FurType;
    public bool IsFriendly;
    public Dog(string furtype, string diet, bool isfriendly) : base("Dog", diet , true, true)  // <== can replace diet passed down with a variable, but must call it in the program.cs side
    
    {
        FurType = furtype;
        IsFriendly = isfriendly;
    }

        public override void ShowInfo() //     // Notice the addition of the keyword "override"
    {
        base.ShowInfo();
        Console.WriteLine($"Fur Type: {FurType}");
        Console.WriteLine($"Friendly: {IsFriendly}");

    }

}