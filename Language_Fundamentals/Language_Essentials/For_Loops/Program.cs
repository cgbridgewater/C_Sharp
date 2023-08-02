// Write a loop 1 to 10 inclusive
//     Console.WriteLine("count 1-10 WITH 10");

// for(int i =1; i <=10; i++){
//     Console.WriteLine(i);
// }

    // Console.WriteLine("count 1-10 WITHOUT 10");

// Write a loop 1 to 10 excluding 10

// for(int i =1; i <10; i++){
//     Console.WriteLine(i);
// }

    // Console.WriteLine("count 1-10 WITH start stop variables");

// make loop with start/stop variables
// int start = 1;
// int stop = 10;
// Console.WriteLine($"start = {start}");
// Console.WriteLine($"stop = {stop}");
// for(int i =start; i <=stop; i++){
//     Console.WriteLine(i);
// }

// write a loop that counts 1 - 50 inclusive
// int start = 1;
// int stop = 50;
// Console.WriteLine($"start = {start}");
// Console.WriteLine($"stop = {stop}");
// for(int i =start; i <=stop; i++){
//     Console.WriteLine(i);
// }

// write a loop that counts even numbers 1 - 50, 50 exlusive

// method 1 modifying the iterator and start point
// int start = 2;
// int stop = 50;
// Console.WriteLine($"start = {start}");
// Console.WriteLine($"stop = {stop}");
// for(int i =start; i <stop; i+=2){
//     Console.WriteLine(i);
// }

// method 2 adding a conditional looking for even numbers
// int start = 1;
// int stop = 50;
// Console.WriteLine($"start = {start}");
// Console.WriteLine($"stop = {stop}");
// for(int i =start; i <stop; i++){
//     if(i % 2 == 0){
//     Console.WriteLine(i);
//     }
// }


//create a loop that goes from 1 to 50, add a condition that prints "+10" for every 10 iterations (you should see +10 in the terminal 5 times) -- you may need to think about how to do this one for a bit!

// int start = 1;
// int stop = 50;
// Console.WriteLine($"start = {start}");
// Console.WriteLine($"stop = {stop}");
// for(int i =start; i <=stop; i++){
//     if(i % 10 == 0){
//     Console.WriteLine("+10");
//     }
// }


// Write a loop that decrements by threes from 99 to 0 and prints the values (all numbers you see should be divisible by 3 if you do this right)
int start =99;
int stop = 0;
Console.WriteLine($"start = {start}");
Console.WriteLine($"stop = {stop}");
for(int i =start; i >=stop; i--){
    if(i % 3 == 0){
    Console.WriteLine(i);
    }
}