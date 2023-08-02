Random rand = new Random();
// make a loop that gives 10 random numbers between 1 and 100
// for (int i = 1; i <= 10; i++){
//     Console.WriteLine($"random number {i} = {rand.Next(1,101)}");
// }


// Try all the different versions of .Next listed in the chart.
// See what sorts of numbers each one is producing and how you might be able to use those values. Leave comments in your code on your results.
// Console.WriteLine(rand.Next());  // produces a random number between 1 and 2,147,483,647 (max value)
// Console.WriteLine(rand.Next(20)); // produces a result greater than 0 and less than provided number
// Console.WriteLine(rand.Next(1,10)); // produces a result greater or equal to first int and less than the second int
// Console.WriteLine(rand.NextDouble()); // produces a floating number between greater or equal to 0 and less than 1

// Which one of the methods you tested would be ideal for creating a dice roller?
// Console.WriteLine(rand.Next(1,7)); // generates a random result for a 6 sided dice roller

// Combine what you've learned so far! Write a loop that runs 15 times and gets a random number between 1 and 10 (10 inclusive) each time. However, you should only print the value if it is equal to 1 OR 7. Run this code several times and see how many times you get results on each run. Tip: Break this problem into multiple parts, first get ALL values to print, then limit it to only printing the values you need.

int start = 1;
int stop = 15;
Console.WriteLine(start);
Console.WriteLine(stop);
for (int i = start; i <= stop; i++){
    int MyRandomNumber = rand.Next(1,11);
    if(MyRandomNumber == 1 || MyRandomNumber == 7){
        Console.WriteLine($"a match for random number {i} = {MyRandomNumber}");
    }
}