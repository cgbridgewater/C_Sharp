Dictionary<string,string> MyDictionary = new Dictionary<string, string>();

MyDictionary.Add("Name", "Chris");
MyDictionary.Add("Location", "Creswell");
MyDictionary.Add("Age", "44");

Console.WriteLine(MyDictionary["Name"]);

foreach(KeyValuePair<string,string> entry in MyDictionary){
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}



// Create a dictionary where the keys are strings and the values are integers.
Dictionary<string,int> MyNumbers = new Dictionary<string, int>();

// Add a few entries. Don't worry about what to name your keys, anything will do for now.
MyNumbers.Add("First Number", 1);
MyNumbers.Add("Second Number", 2);
MyNumbers.Add("Third Number", 3);
MyNumbers.Add("Fourth Number", 4);
MyNumbers.Add("Fifth Number", 5);
MyNumbers.Add("Sixth Number", 6);
MyNumbers.Add("Test Number", 22);


// Loop through the dictionary to print out the values, but only print the value if the number is higher than 5.
foreach(KeyValuePair<string,int> number in MyNumbers){
    Console.WriteLine($"{number.Key} - {number.Value}");
}

// What would happen if you tried to add a new entry that used an already existing key name? Test it out and make notes on what happened!
// MyNumbers.Add("Test Number", 24);    ////Unhandled exception. System.ArgumentException: An item with the same key has already been added. 


// Can you make a dictionary where the value is a List of integers?
// Dictionary<string, List<int>> MyLists = new Dictionary<string,List<int>>();
// MyLists.Add("Test list 1", new List<int>{1,2,3,4,5,9} );
// MyLists.Add("Test list 2", new List<int>{4,32,12,2,5,3} );

// Console.WriteLine("My lists entry");
// Console.WriteLine(MyLists[0][1]);


// Research this! How would we remove an entry from our dictionary? What do you think it is based on what you have learned so far? Look it up and see if you were right! While you're at it, look up if there is an easy way to remove all entries from a dictionary with one command.
MyNumbers.Clear();
    Console.WriteLine("Cleared my numbers!!");
foreach(KeyValuePair<string,int> number in MyNumbers){
    Console.WriteLine($"{number.Key} - {number.Value}");
}