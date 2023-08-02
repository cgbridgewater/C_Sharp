
// // // Coin Flip

// static String FlipCoin(){
//     Random rand = new Random();
//     int result = rand.Next(1,3);
//     if(result == 1){
//         return "Heads";
//     }
//     return "Tails";
// }

// Console.WriteLine(FlipCoin());


// // // Dice Roll

// static int ShakeEmUp(){
//     Random rand = new Random();
//     int result = rand.Next(1,7);
//     return result;
// }

// Console.WriteLine(ShakeEmUp());


// // // Stat Roll

// static List<int> ThrowDice(int times){
//     Random rand = new Random();
//     List<int> results = new List<int>();
//     for(int idx = 1; idx<=times; idx++){
//         results.Add(rand.Next(1,7));
//     }
//     return results;
// }

// Console.WriteLine(string.Join(", ",ThrowDice(8)));



Console.WriteLine("--- Lets roll for a number! ---");
// // // Roll Until...

// static string RollTil(int MyNum, int diceSides){
//     if(MyNum < 1 || MyNum > diceSides){ // Check limits
//         return $"The number must be between 1 and {diceSides}, Try again!"; // eject if outside of limits
//     }
//     Random rand = new Random();
//     int count = 1; // start roll count
//     int result = 0; // set default result
//     for(int idx = 0; idx < count; idx++){
//         result = rand.Next(1,diceSides+1); // set range for random roll
//         Console.WriteLine("you rolled a " + result);
//         if(MyNum != result){ // check for match
//             Console.WriteLine("Thats " + count + "! Roll again!"); // if no match, state roll # and add 1 for next roll
//             count++; 
//         }
//     }
//     return $"Rolled a {MyNum} after {count} tries"; // if match, state matched number and rolls til matched
// }


// Console.WriteLine(RollTil(14, 20));




// // // Optional Bonus!
///////////////////////Create a dice roll game to allow user input to pick dice sides and number to match. 

static string RollTil(int MyNum, int diceSides){
    if(MyNum < 1 || MyNum > diceSides){ // Check limits
        return $"The number must be between 1 and {diceSides}, Exiting!"; // eject if outside of limits
    }
    Random rand = new Random();
    int count = 1; // start roll count
    int result = 0; // set default result
    for(int idx = 0; idx < count; idx++){
        result = rand.Next(1,diceSides+1); // set range for random roll
        Console.WriteLine("you rolled a " + result);
        if(MyNum != result){ // check for match
            Console.WriteLine("Thats " + count + "! Roll again!"); // if no match, state roll # and add 1 for next roll
            count++; 
        }
    }
    return $"Rolled a {MyNum} after {count} tries"; // if match, state matched number and rolls til matched
}


// Pick Sides
Console.WriteLine("Tell me what is the size of dice you want to roll, then hit enter"); // promt for a number
string SidesInput = Console.ReadLine(); // intake number
int sides = 0; // set default sides t0 0
if(Int32.TryParse(SidesInput, out int j)){ // check for good result
    Console.WriteLine($"The dice size is set to {j}");
    sides = j; // if good set sides to input
}
else { // if not valid promt again
    Console.WriteLine("C'mon, just give me a dice size, then hit enter.");
    Console.WriteLine("I'll give you one last chance!");
    string SidesInput2 = Console.ReadLine();
    if(Int32.TryParse(SidesInput2, out int i)){ // check for good result
        Console.WriteLine($"The dice size is set to {i}");
        sides = i; // if good set sides to input
    }else{ // if not valid exit
        Console.WriteLine("Too many invalid entries, Exiting....");
    }
}


// Pick Number
    int numToMatch = 0;
if(sides != 0){
    Console.WriteLine("Type a number to match, then hit enter");
    string NumberInput = Console.ReadLine();
    if(Int32.TryParse(NumberInput, out int j2)){ // check for good number To Match
        Console.WriteLine($"The number was {j2}");
        numToMatch = j2; // if good set sides to input
    }
    else { // if not valid promt again
        Console.WriteLine("C'mon, just give me a number to match, then hit enter.");
        Console.WriteLine("I'll give you one last chance!");
        string NumberInput2 = Console.ReadLine();
        if(Int32.TryParse(NumberInput2, out int i2)){ // check for good number To Match
            Console.WriteLine($"The number selected is {i2}");
            numToMatch = i2; // if good set sides to input
        }else{ // if not valid exit
            Console.WriteLine("Too many invalid entries, Exiting....");
        }
    }
    if(numToMatch <= sides){ // check picked number doesn't exceed dice sides
        if(numToMatch !=0 && sides !=0){
            Console.WriteLine(RollTil(numToMatch, sides)); // if good, start rolling
        }
    } else {
        Console.WriteLine("Number to Match must not exceed the number of dice sides, Exiting...."); // if not, exit
    }
}