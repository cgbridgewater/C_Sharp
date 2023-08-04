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