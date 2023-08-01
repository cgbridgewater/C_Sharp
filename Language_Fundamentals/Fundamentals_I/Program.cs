Random rand = new Random();
// Create a loop that prints all values from 1-255.
// for(int i = 1; i <=255; i++){
//     Console.WriteLine(i);
// }

// Create a new loop that generates 5 random numbers between 10 and 20.
// for(int i = 1; i <=5; i++){
//     Console.WriteLine(rand.Next(10,21));
// }


// Modify the previous loop to add the random values together and print the sum after the loop finishes.
// int numSum = 0;
// for(int i = 1; i <=5; i++){
//     int rando = rand.Next(10,21);
//     Console.WriteLine($"random number = {rando}");
//     numSum += rando;
// }
//     Console.WriteLine($"sum = {numSum}");



// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
// for (int i =1; i<=100; i++){
//     if(i % 3 == 0 || i % 5 == 0){
//         if(i % 3 == 0 && i % 5 == 0){
//         } else{
//         Console.WriteLine(i);
//     }
//     }
// }


// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
// for (int i =1; i<=100; i++){
//     if(i % 3 == 0 || i % 5 == 0){
//         if(i % 3 == 0 && i % 5 == 0){

//         } else if(i % 3 == 0) {
//         Console.WriteLine("Fizz");
//         } else {
        
//         Console.WriteLine("Buzz");
//         }
//     }
// }


// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
// for (int i =1; i<=100; i++){
//     if(i % 3 == 0 || i % 5 == 0){
//         if(i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine("FizzBuzz");
//         } else if(i % 3 == 0) {
//         Console.WriteLine("Fizz");
//         } else {
        
//         Console.WriteLine("Buzz");
//         }
//     }
// }


// (Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!
int i = 1;
while(i <=100)
{
    if(i % 3 == 0 || i % 5 == 0){
        if(i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
        } else if(i % 3 == 0) {
        Console.WriteLine("Fizz");
        } else {
        
        Console.WriteLine("Buzz");
        }
    }
    i++;
}