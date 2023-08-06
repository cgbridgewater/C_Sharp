#pragma warning disable CS8618
namespace TestAppMCV.Models;
public class Friend
{

    public string FirstName {get;set;}
    public string LastName {get;set;}
    // Location is now optional
    public string? Location {get;set;}
    // public string? Location {get;set;} = null!;  // alternative using null forgiving operator --> requires null! infront of EVERY property that triggers that warning
    public int Age {get;set;}


}