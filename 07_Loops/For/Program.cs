// Creating an initial target

//a for loop is more often used for saying "do this for a certain amount of times" rather than simply while some condition is true.
int number = 100;

//  1   // 2      // 3      // 4
for (int i = 0; i < number; i+=5)
{
    // 5
    Console.WriteLine(i);
}

// 1 - for keyword
// 2 - Declaration and initialization of an iterator variable 
// 3 - Boolean expression comparing the new iterator to the number variable
// 4 - Incrementing the iterator at the end of each loop
// 5 - Body of the loop, runs once per iteration after the boolean is evaluated as true



/*Exercise
Now that we've talked about the basics of a for loop, go ahead and let's have you write some more code.

Prompt the user for a number to count to from zero. Take the input from the user and write to the console all numbers
 from zero to the number given by the user. This should be inclusive, 
 meaning you'll write both zero and the number they gave you to the console.*/


Console.WriteLine("Give me any number");
string response = Console.ReadLine();
int n = int.Parse(response);


for (int i = 0; i <= n; i++){
    Console.WriteLine(i);
}
