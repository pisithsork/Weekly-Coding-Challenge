using CodingChallenge;
using System;
Solutions solution = new Solutions();
Console.WriteLine("Revature Coding Challenge: ");
Console.WriteLine("04/17/2023 Challenge: Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.");
/*
 Examples

IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]

IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]

IndexOfCapitals("determine") ➞ []

IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]

IndexOfCapitals("sUn") ➞ [1]
 */
string[] inputs = { "eDaBiT", "eQuINoX", "determine", "STRIKE", "sUn" };
foreach(string input in inputs)
{
    var result = solution.IndexofCapitals(input);
    Console.WriteLine("IndexOfCapitals(\"{0}\") => [{1}]", input, string.Join(", ", result));
}

