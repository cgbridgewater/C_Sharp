// abstract has been added to our first line
public abstract class Animal
{
    public string Type;
    public string Name;
    protected string Diet;
    public bool IsMammal;
    public bool IsPet;
    public Animal(string type, string name, string diet, bool ismammal, bool ispet)
    {

        Type=type;
        Name=name;
        Diet=diet;
        IsMammal=ismammal;
        IsPet=ispet;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Mammal: {IsMammal}");
        Console.WriteLine($"Pet: {IsPet}");
    }

    public abstract void MakeNoise();
}