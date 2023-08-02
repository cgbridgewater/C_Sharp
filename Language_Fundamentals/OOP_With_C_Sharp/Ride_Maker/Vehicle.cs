
class Vehicle{

// FIELDS
    string Name;
    string _Name
    {
        get{ return Name; }
        set{ Name = value; }
    }
    int Passengers;
    int _Passengers
    {
        get{ return Passengers; }
        set{ Passengers = value; }
    }
    string Color;
    string _Color
    {
        get{ return Color; }
        set{ Color = value; }
    }
    bool HasEngine;
    bool _HasEngine
        {
        get{ return HasEngine; }
        set{ HasEngine = value; }
    }
    int MilesTraveled;
    int _MilesTraveled
        {
        get{ return MilesTraveled; }
        set{ MilesTraveled += value; }
    }

// CONSTRUCTORS
    public Vehicle(string name, int passengers, string color, bool hasEngine){
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasEngine;
        MilesTraveled = 0;
    }

    public Vehicle(string name, string color){
    Name = name;
    Color = color;
    Passengers = 4;
    HasEngine = true;
    MilesTraveled = 0;
}

//     public Truck(string name, string color){
//     Name = name;
//     Color = color;
//     Passengers = 2;
//     HasEngine = true;
//     MilesTraveled = 0;
// }

// METHODS

    public void ShowInfo(){
        // Console.WriteLine(this.Name + " is " + this.Color + " and holds " + this.Passengers + " passengers");
        // Console.WriteLine("Engine - " + this.HasEngine + " with " + this.MilesTraveled + " miles logged");
        Console.WriteLine($"{Name} is {Color} and holds {Passengers} passengers. Powered by an engine? {HasEngine}, Logged Miles: {MilesTraveled}");
    }

    public void Travel(int value){
        this._MilesTraveled = value;
        Console.WriteLine($"{Name} traveled {value} miles and now has a total of {MilesTraveled} miles");
    }

}