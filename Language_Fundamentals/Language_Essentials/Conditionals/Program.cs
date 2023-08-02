int temperature = 100;
string weather = "Sunny";
if(temperature >= 72 || weather == "Sunny")
{
    Console.WriteLine("It's a beautiful day to go outside!");

} else if(temperature > 64 && weather != "Rainy") {
	Console.WriteLine("I think it should be fine to go outside today with a jacket.");    
} else {
    Console.WriteLine("Maybe I'll stay inside today.");
}

int height = 40;

if(height >= 42 && height < 78){
    Console.WriteLine("Enjoy The ride");
} else if(height >78){
    Console.WriteLine("You're too tall for this ride");
}else{
    Console.WriteLine("You're too short, come back when you grow a little more");
}

bool orderCompleted = true;

if(orderCompleted == true){
    Console.WriteLine("Your drink is ready!");
} else {
    Console.WriteLine("Your order is still processing");
}
