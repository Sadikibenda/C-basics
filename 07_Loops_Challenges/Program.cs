
//Write a for loop to print the numbers 500 through 525.

int numbers = 525;

for (int i=500; i<=numbers; i++){
    Console.WriteLine(i);
}

//Create a for loop to print the numbers from 0-100 by 5's.

int number = 100;

for (int i=0; i<= number; i+=5){
    Console.WriteLine(i);
}

/*Create a for loop to print the numbers 1-100. If the number is divisible by 3,
 print Fizz instead of the number. If it's divisible by 5, print Buzz, instead of the number.
  If it's divisible by both 3 and 5, print FizzBuzz otherwise print the number.*/

//-- Gold
for (int i = 0; i <= 100; i++)
{
    if (i % 15 == 0) // alternatively (i % 5 == 0 && i % 3 ==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
