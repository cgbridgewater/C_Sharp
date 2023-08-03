
public class Animal{
    public string Name;
    protected string Diet;
    public bool IsMammal;
    public bool IsPet;

    public Animal(string name, string diet, bool ismammal, bool ispet){
        Name=name;
        Diet=diet;
        IsMammal=ismammal;
        IsPet=ispet;
    }

    public virtual void ShowInfo() //    // Notice the addition of the keyword "virtual" this allows it to have an override in the childern!
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Mammal: {IsMammal}");
        Console.WriteLine($"Pet: {IsPet}");
    }
}
