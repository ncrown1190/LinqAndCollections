// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

//LINQ
//Objective: LINQ and Collections

//Task: Use LINQ to search the following collection.

//Build Specifications:
//Create the following array
//int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//Write code using LINQ to answer the following questions: 

//Find the Minimum value 
//Find the Maximum value
//Find the Maximum value less than 10000
//Find all the values between 10 and 100
//Find all the Values between 100000 and 999999 inclusive 
//Count all the even numbers.


int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//Array.Sort(nums);
//Console.WriteLine("Sorted array of numbers in asscending order: ");

//foreach (int num in nums)
//{
//    Console.Write($"{num}, ");
//}

// 01  Find the Minimum value
int minimumValue = nums.Min();
Console.WriteLine($"Minimum value in the nums array is: {minimumValue} ");

// 02  Find the Maximum value
int maximumValue = nums.Max();
Console.WriteLine($"Maximum value in the array is: {maximumValue} ");

// 03 Find the Maximum value less than 10000
int maxLess = nums.Where(x => x < 10000).Max();
Console.WriteLine($"Maximum value less than 10000: {maxLess}");

// 04 Find all the values between 10 and 100
int[] valuesBetween = nums.Where(x => x > 10 && x < 100).ToArray();
//var firstValues = nums.Where(x => x > 10 && x < 100);

Console.Write($"Values between 10 and 100: ");
foreach (int num in valuesBetween)
{
    Console.WriteLine($"{num}, ");
}
//foreach (int num in firstValues)
//{
//    Console.Write($"{num}, ");
//}

// 05 Find all the Values between 100000 and 999999 inclusive 
var valuesBetweenThosands = nums.Where(x => x > 100000 && x <= 999999);
//var valuesBetween = String.Join(",", valuesBetween2);
Console.Write($"Values between 100000 and 999999 inclusive: ");
foreach (int num in valuesBetweenThosands)
{
    Console.Write($"{num}, ");
}

Console.WriteLine();
// 06 Count all the even numbers
int count = nums.Count(x => x % 2 == 0);
Console.Write($"Count of the even numbers are: {count} ");

Console.WriteLine();


//Display all the even numbers
int[] evenNumbers = nums.Where(x => x % 2 ==0).ToArray();
Array.Sort(evenNumbers);
Console.Write($"All even numbers in the array: ");
foreach (int num in evenNumbers)
{
    Console.Write($"{num}, ");
}

Console.WriteLine("Press any key to Quit.");
Console.ReadLine();