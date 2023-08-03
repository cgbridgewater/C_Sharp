
Cat MyCat = new Cat("Shorthair",  "Omnivorous");
Dog MyDog = new Dog("White and spots",  "Kibble", true);
Bird MyBird = new Bird("herbivore", "Tweety");
Bird Quackers = new Bird("herbivore", "Quackers");
Bird Polly = new Bird("herbivore", "Polly");
Bird Daffy = new Bird("herbivore", "Daffy");

MyCat.ShowInfo();
MyDog.ShowInfo();
MyBird.ShowInfo();
List<Animal> AllAnimals = new List<Animal>();
List<Animal> AllBirds = new List<Animal>();
AllAnimals.Add(MyCat);
AllAnimals.Add(MyDog);
AllAnimals.Add(MyBird);
AllAnimals.Add(Quackers);
AllAnimals.Add(Polly);
AllAnimals.Add(Daffy);

foreach(Animal a in AllAnimals)
{
    a.ShowInfo();
    // Remember type casting from the last chapter?
    if(a is Bird)
    {
        Console.WriteLine("SQUUUAAAAK!");
        AllBirds.Add(a);
    }
}

foreach(Animal a in AllAnimals)
{
    // Remember type casting from the last chapter?
    if(a is Dog)
    {
        a.ShowInfo();
    }
}

foreach(Animal a in AllAnimals)
{
    a.ShowInfo();
}