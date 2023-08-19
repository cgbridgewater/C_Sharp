List<int> numbers = new List<int>(){2,10,18,12,5,7,16};

List<int> numsAboveTen = numbers.Where(num => num > 10).ToList();

    Console.WriteLine("numbers above 10 :");
foreach(int num in numsAboveTen){
    Console.WriteLine(num);
}

Console.WriteLine("lowest number = " + numbers.Min(numbers => numbers));

Console.WriteLine("highest number = " + numbers.Max(numbers => numbers));
