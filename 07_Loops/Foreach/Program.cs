string instructorName = "Amanda";
string[] instructors = new string[] { "Michael", "Joshua", instructorName };

foreach (string name in instructors)
{
    Console.WriteLine(name);
}



/*Exercise
Before moving on, let's have you write another foreach loop.

This time let's add some more logic to it. Complete the following steps:

Declare a new array of integers
Iterate over this array with a foreach loop
Write to the console whether or not the numbers are negative or positive.*/

int[] numbers = new int[] { 1, 5, 10, -4, 12, 0 };

foreach (int number in numbers)
{
    if (number > 0)
    {
        Console.WriteLine($"{number} is a positive number.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{number} is a negative number.");
    }
    else
    {
        Console.WriteLine($"{number} is a neutral number.");
    }
}


            /* Advanced Solution


int[] numbers = new int[] { 1, 5, 10, -4, 12, 0 };

foreach (int number in numbers)
{
    string sign = number > 0 ? "positive" : number == 0 ? "neutral" : "negative";
    Console.WriteLine($"{number} is a {sign} number.");
}*/