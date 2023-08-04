double FirstValue = 4.8;
double SecondValue = 2;

double Sum = Calculator.Add(FirstValue,SecondValue);
Console.WriteLine($"{FirstValue} + {SecondValue} = {Sum}");

double Subtract = Calculator.Subtract(FirstValue,SecondValue);
Console.WriteLine($"{FirstValue} - {SecondValue} = {Subtract}");


double Multiply = Calculator.Multiply(Sum,Subtract);
Console.WriteLine($"{Sum} * {Subtract} = {Multiply}");

double Square = Calculator.Square(Multiply);
Console.WriteLine($"{Multiply} squared = {Square}");