using CodingChallenge_5_23;
using System;

Solution solution = new Solution();
Console.WriteLine("Revature Coding Challenge: ");
Console.WriteLine("05/24/23 Challenge: Write a program that accepts sets of three numbers, and prints the second-maximum number among the three.");

int[][] inputs =
{
    new int[] { 1, 2, 3 },
    new int[] { 10, 15, 5, },
    new int [] {100, 999, 500 }
};
foreach (int[] input in inputs)
{
    var result = solution.SecondMaxValue(input);
    Console.WriteLine("SecondMaxValue({{{0}, {1}, {2}}}) => [{3}]", input[0], input[1], input[2], string.Join(", ", result));
}



Console.WriteLine("Revature Coding Challenge: ");
Console.WriteLine("05/24/23 Challenge: Given an alphanumeric string made up of digits and lower case Latin characters only, find the sum of all the digit characters in the string.");

string input2 = "ab1234cd";

var result2 = solution.AlphnumericValue(input2);
Console.WriteLine(result2);
