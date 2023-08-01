// 1. Iterate and print values
// Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)

static void PrintList(List<string> MyList)
{
    Console.WriteLine("----- Method 1 -----");
    foreach(string name in MyList){
        Console.WriteLine(name);
    }
    Console.WriteLine("----- Method 2 -----");
    for(int idx =0; idx < MyList.Count; idx++){
        Console.WriteLine(MyList[idx]);
    }
    Console.WriteLine("----- Method 3 -----");
    Console.WriteLine(string.Join(", ", MyList));
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);



// 2. Print Sum
// Given a List of integers, calculate and print the sum of the values.

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach(int num in IntList){
        sum += num;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);



// 3. Find Max
// Given a List of integers, find and return the largest value in the List.

static int FindMax(List<int> IntList)
{
    int maxNum = 0;
    foreach(int num in IntList){
        if (maxNum == 0){
            maxNum = num;
        } else {
            if (maxNum < num){
                maxNum = num;
            }
        }
    }
    return maxNum;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));



// 4. Square the Values
// Given a List of integers, return the List with all the values squared.

static List<int> SquareValues(List<int> IntList)
{
    for(int idx =0; idx< IntList.Count; idx++){
        IntList[idx] =   IntList[idx] * IntList[idx];
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
Console.WriteLine(string.Join(", ", SquareValues(TestIntList3)));



// 5. Replace Negative Numbers with 0
// Given an array of integers, return the array with all values below 0 replaced with 0

static int[] NonNegatives(int[] IntArray)
{
    for(int idx = 0; idx< IntArray.Length; idx++){
        if(IntArray[idx] < 0){
            IntArray[idx] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);
Console.WriteLine(string.Join(",", NonNegatives(TestIntArray)));