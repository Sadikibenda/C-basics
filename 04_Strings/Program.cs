﻿string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

// We're concatenating a new string with only a space here
// Notice we can combine it with the variables from above
string concatenatedResult = first +" "+  second;
Console.WriteLine(concatenatedResult);

//-- Composite Formatting
string firstName = "Jenn";
string middleName = "sadiki";
string lastName = "Williams";

// Here we're using the string.Format method that supports composite formatting
string compositeResult = string.Format("Her name is {0} {1} {2}", firstName,middleName, lastName);

Console.WriteLine(compositeResult);
// Console.WriteLine() will also auto implement Composite Formatting for us too
//Console.WriteLine("Her name is {0} {1}", firstName, lastName);

//-- String Interpolation
string interpolationResult = $"Her name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);