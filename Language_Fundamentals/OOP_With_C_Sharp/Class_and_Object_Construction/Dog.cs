//// a class allows you to group several parameters or ideas into one object

class Dog  // class structure  ALWAYS capitalized!!!!
{
////// FIELDS

    private string Name;  // <= fields, keep capitalized
    public string _Name   // <= getter
    { 
        get { return Name; }
        set { if(value[0] != 'H') Name = value; }
    }
    string Breed;
    string FurColor {get; set;}
    


/////// CONSTRUCTORS

    // Notice how this is like a function taking in a parameter for name
    public Dog(string name, string breed, string fur){ // <= constructor call on the class and include variables assoacted to the field
        // Notice how we used a capital "N" for our Name above, but a lower case "n" for our parameter
        // This helps us to distinguish which is which
        Name = name;
        Breed = breed;
        FurColor = fur;
    }



/////// METHODS

    void Bark(){  // <= methods
        Console.WriteLine("Bark! Bark!");
    }
    // void Fetch(string item){
    //     Console.WriteLine($"{Name} hurriers to fetch the {Item}!");
    // }

}

 // Notice the type here is "Dog". Classes create their very own data type! 
 // PLEASE NOTE: This line will throw an error for now until we make
 // the proper adjustments on the next page! The syntax IS correct!
// Dog MyDog = new Dog("Juniper");


