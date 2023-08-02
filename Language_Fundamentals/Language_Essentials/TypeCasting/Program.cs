
//// Implicit Casting

int IntegerValue = 3;
double DoubleValue = IntegerValue;

Console.WriteLine(DoubleValue);


//// Explicit Casting

double DoubleValue2 = 3.1459;
int IntegerValue2 = (int)DoubleValue2; // Notice the (int) to cast it to integer before setting it to an int value

Console.WriteLine(IntegerValue2);


//// Unboxing  -- Not A Good Practice!!
// object BoxedData = "This is clearly a string";
object BoxedData = 2;
Console.WriteLine("Whats in the boooooox....!?");
// Make sure it is the type you need before proceeding
if (BoxedData is int) {
    // This shouldn't run
    Console.WriteLine("I guess we have an integer value in this box?");
}
if (BoxedData is string) {
    Console.WriteLine("It is totally a string in the box!");
}


// //// Safe Explicit Casting
// // THIS WILL WORK!!
// object ActuallyString = "a string";
// string ExplicitString = ActuallyString as string;
 
// // THIS WON'T WORK!!
// object ActuallyInt = 256;
// int ExplicitInt = ActuallyInt as int;