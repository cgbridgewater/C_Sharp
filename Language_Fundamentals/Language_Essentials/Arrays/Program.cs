// // Declaring an array of length 5, initialized by default to all zeroes
// int[] numArray = new int[5];
// // Declaring an array with pre-populated values
// // For arrays initialized this way, the length is determined by the size of the given data
// int[] numArray2 = {1,2,3,4,6};
// int[] numArray3 = {10,2,30,44,65};


// for (int idx = 0; idx < numArray.Length; idx++){
//     Console.WriteLine($"the array number at {idx} position is {numArray[idx]}");
// } //// gives 5 zeros!!!

// for (int idx = 0; idx < numArray2.Length; idx++){
//     Console.WriteLine($"the array number at {idx} position is {numArray2[idx]}");
// }

// for (int idx = 0; idx < numArray3.Length; idx++){
//     Console.WriteLine($"the array number at {idx} position is {numArray3[idx]}");
// }

// basic for loop
// string[] myCars = new string[] {"Mazda Miata", "Ford Mustang", "Dodge Challenger", "Nissan 300zx"};
// for (int idx = 0; idx < myCars.Length; idx++){
//     Console.WriteLine($"the car at index position {idx} is a {myCars[idx]}");
// }

// foreach loop
// string[] myCars = new string[] {"Mazda Miata", "Ford Mustang", "Dodge Challenger", "Nissan 300zx"};
// foreach (string car in myCars){
//     Console.WriteLine($"I own a {car}");
// }


// Create an array of integers that will hold 8 values. (Do not fill in the values, just create 8 slots.)
int[] numArray = new int[8];
for (int idx = 0; idx < numArray.Length; idx++){
    Console.WriteLine($"the array number at {idx} position is {numArray[idx]}");
}   //// gives 8 zeros

// Place the number 17 in the third spot of your array. (Think carefully about the index number you need to make this happen!)
numArray[2] = 17;

// Try to place the word "Hello" in the fifth spot. What happens? Comment your code explaining what happened.
//numArray[2] = "hello world";  // Cannot implicitly convert type 'string' to 'int'

// Loop through your array and print out the values.
for (int idx = 0; idx < numArray.Length; idx++){
    Console.WriteLine($"the array number at {idx} position is {numArray[idx]}");
} //// 0,0,17,0,0,0,0,0

// If you did the above action with a for loop, do it again but with a foreach loop.
foreach(int num in numArray){
    Console.WriteLine(num);
} //// 0,0,17,0,0,0,0,0


// Try to Console.WriteLine your array. What result do you get? Weird, right? Do a bit of research on this to find out why it happens and how to work around it!
// Console.WriteLine(numArray);  ////System.Int32[]

// bypass method force it to a string and concatenate it
Console.WriteLine("Array line : "+ string.Join(",", numArray));