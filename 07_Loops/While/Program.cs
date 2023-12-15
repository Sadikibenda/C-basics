
/*While loops execute a statement or a block of statements while the specified boolean expression evaluates to true.

This means you give the while loop a boolean to evaluate; if it's true it loops and if it's false it does not.*/


// Declaring a variable to use in our loop's boolean expression
int number = 0;

// While the value in number is less than or equal to 100, run the following
while (number <= 100)
{
    // Write the value of number to the console and then increment by 5
    Console.WriteLine(number);
    number = number + 5;
}


