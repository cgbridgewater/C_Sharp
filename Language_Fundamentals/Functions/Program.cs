// Function with return type
static int AddNums(int a, int b){
    return a+b;
}


Console.WriteLine(AddNums(5,8));

// Function with no return only print line
static void AddNumbers(int a, int b){
    int sum = a+b;
    Console.WriteLine(sum);
}
AddNumbers(2,18);

static void HelloWorld(){
    Console.WriteLine("Hello, World!");
}
HelloWorld();

static void SayHello(string firstName){
    Console.WriteLine($"Hello, {firstName}!");
}
SayHello("Chris");

static void SayHello2(string firstName = "buddy")
{
    Console.WriteLine($"Hey, {firstName}");
}
// We can call it without providing any arguments and the default value will be used...
SayHello2();
// ...or we can call it with an argument and that argument's value will be used
SayHello2("I'm not your buddy, Pal!");

// Create a function that takes in two parameters. A string for name and an integer for age. Have it print to the console "Hi, my name is [insert name here], and I am [insert age here] years old!"
static void MyAge(string name, int age){
    Console.WriteLine($"Hi, my name is {name}, and I am {age} years old!");
}
MyAge("Chris", 44);

// Create a function that passes in a List of strings as an argument but returns an integer that says how many values are in the List.

static int countNames(List<string> nameList){
    return nameList.Count;
}

Console.WriteLine(countNames(new List<string> (new string[]{"steve", "mike", "tim"})));

// Debugging practice! In any of your functions that return a value like string or integer, delete the return statement from your code. What error message do you get? How does it help you to figure out that you are missing the return statement?


// static int AddNewNums(int a, int b){

// }

// Console.WriteLine(AddNewNums(5,8));  // not all code paths return a value <= meaning is expecting a return but didn't get one

