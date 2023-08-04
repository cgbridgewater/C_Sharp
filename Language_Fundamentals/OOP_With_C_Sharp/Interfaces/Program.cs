Bird Tweety = new Bird(true,"Tweety", "Herbivore", 3);
Bird Daffy = new Bird(true,"Daffy", "Herbivore", 0);
Bird DaisyDuck = new Bird(true,"Daisy Duck", "Herbivore", 3);
Bird Robin = new Bird(true,"Robyn the Robin", "Herbivore", 3);
Dog Juniper = new Dog("White with spots", "Kibble", true, "Juniper");
Cat Kitty = new Cat("Grey with stripes","Omnivorous", "Kitty");
Reptile Snek = new Reptile("Snek","Onmivorous", 6);

List<ILayEggs> canLayEggs = new List<ILayEggs>();
canLayEggs.Add(Tweety);
canLayEggs.Add(Daffy);
canLayEggs.Add(DaisyDuck);
canLayEggs.Add(Snek);
foreach(ILayEggs e in canLayEggs)
{
    e.LayEggs();
    if(e.EggsPerBatch ==0){
        Console.WriteLine("He's a boy, duh!");
    }
        Console.WriteLine("*********************");
}

// Tweety.ShowInfo();
// Snek.ShowInfo();
// Juniper.ShowInfo();
// Kitty.ShowInfo();


// Let's make a string array
string[] wordArray = new string[]
{
    "Goat", "Bear", "Skunk", "Deer"
};

// And a List of strings
List<string> wordList = new List<string>()
{
    "Plate", "Cup", "Fork", "Meat Cleaver", "Spatula"
};

// Next we'll write our function that loops through a collection and prints the values out
static void LoopingSomeWords(IEnumerable<string> someWords)
{
    foreach(var word in someWords)
    {
        Console.WriteLine(word);
    }
}

// And then we can call our function with either!
LoopingSomeWords(wordArray);
LoopingSomeWords(wordList);
// This is because our function will accept ANY collection of strings
// that have the IEnumerable interface applied