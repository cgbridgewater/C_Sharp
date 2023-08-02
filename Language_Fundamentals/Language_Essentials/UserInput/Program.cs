// Console.WriteLine("Type Something, then push enter: ");
// string InputLine = Console.ReadLine();
// Console.WriteLine($"You wrote: {InputLine}");


////// Fails if not a number
// Console.WriteLine("Type a number, then push enter: ");
// string InputLine = Console.ReadLine();
// int converted = Convert.ToInt32(InputLine);
// Console.WriteLine($"You wrote: {converted}");
////// Fails if not a number


// This can catch string or number!
Console.WriteLine("Type a number, then hit enter");
string NumberInput = Console.ReadLine();
if(Int32.TryParse(NumberInput, out int j)){
    Console.WriteLine($"The number was {j}");
}
else {
    Console.WriteLine("I'll ask one more time, type a number, then hit enter");
    string NumberInput2 = Console.ReadLine();
    if(Int32.TryParse(NumberInput2, out int i)){
        Console.WriteLine($"The number was {i}");
    }else{
        Console.WriteLine("Nevermind, Exiting....");
    }
}