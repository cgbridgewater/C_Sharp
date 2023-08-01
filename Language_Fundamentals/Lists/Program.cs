// Initializing an empty list of Motorcycle Manufacturers that expects string values
// List<string> bikes = new List<string>();
// // Use the Add function in a similar fashion to push
// bikes.Add("Kawasaki");
// bikes.Add("Triumph");
// bikes.Add("BMW");
// bikes.Add("Moto Guzzi");
// bikes.Add("Harley Davidson");
// bikes.Add("Suzuki");
// // Accessing a generic list value is the same as an array
// Console.WriteLine(bikes[2]); //Prints "BMW", remember we start at 0!
// // To get the size of a List, we use Count instead of Length
// Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");


// foreach(string bike in bikes){
//     Console.WriteLine(bike);
// }


//     Console.WriteLine("");
//     Console.WriteLine("----------");
//     Console.WriteLine("");



// bikes.Remove("Suzuki");
// foreach(string bike in bikes){
//     Console.WriteLine(bike);
// }


//     Console.WriteLine("");
//     Console.WriteLine("----------");
//     Console.WriteLine("");


// bikes.Add("Suzuki");
// bikes.Add("Honda");
// foreach(string bike in bikes){
//     Console.WriteLine("-" + bike);
// }

// Create a List of strings and fill it with a few grocery items.
List<string> groceries = new List<string>();
groceries.Add("Ketchup");
groceries.Add("swiss cheese");
groceries.Add("hamburger meat");
groceries.Add("potato buns");
groceries.Add("bar-b-que sauce");
groceries.Add("pineapple rings");
groceries.Add("tater tots");
groceries.Add("cross cut fries");

// Loop through your List and print out the values.

Console.WriteLine("My Grocery list:");
foreach(string item in groceries){
    Console.WriteLine("-" + item);
}

// Remove one of the values from your grocery list.
groceries.Remove("cross cut fries");

// Remove the first item from your grocery list.
groceries.RemoveAt(0);

// Console.WriteLine your grocery list variable. Based on what you learned about printing a whole array, what does this tell you?
Console.WriteLine(groceries);

// Fix it!
Console.WriteLine(string.Join(", ", groceries));

// Write some code that gives you a random item from your grocery List. (Tip: remember Random is a built-in feature we have and think about how to get a random number within the Lists' range)

Random rand = new Random();
Console.WriteLine($"Random item from list => {groceries[rand.Next(0,groceries.Count)]}");




////// NEW LIST WITH values declared in the list
List<string> nameList = new List<string> (new string[]{"steve", "mike", "tim"});

foreach(string name in nameList){
Console.WriteLine(name);
}