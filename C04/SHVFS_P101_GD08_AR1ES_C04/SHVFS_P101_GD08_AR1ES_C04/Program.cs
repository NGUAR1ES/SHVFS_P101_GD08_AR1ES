// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var arithmeticOperatorMultiply = 5;
arithmeticOperatorDivide *= 10;

// arithmeticOperatorMultiply = arithmeticOperatorMultiply

Console.WriteLine("This is BRFORE our FOR LOPP!");


for (var i = 0; i < 10; i++)
{
    Console.WriteLine("This is THE FIRST LINE in our FOR LOOP!");
    Console.WriteLine($"The vaule of i is：{i}");
}
var input = "";

while (input != "Quit")
{
    Console.Clear();
    Console.WriteLine($"Enter \"Quit\" to win the game!");
}

Console.WriteLine("CONGRATS! YOU WON!");
Console.ReadLine();

int i;


Console.WriteLine("Enter 1 for options\n" +
                  "      2 to quit\n" +
                  "      3 to start game");

do
{
    Console.WriteLine("please make a selection! HAHA!");
    i = Convert.ToInt32(Console.ReadLine());
} while (i < 1 || i > 3);

    Console.WriteLine("Excellent choice!");
    Console.ReadLine();

for (var i = 0; i < 7; i++)
{
    for (var j = 0; j < 10; j++)
    {
        Console.WriteLine($"i is: {i}, and j is: {j}");
    }
}

var scores = new int[5];
scores[0] = 7;
scores[1] = 24;
scores[2] = 2;
scores[3] = 9;
scores[4] = 1;

// THIS IS BAD
// IT USES MAGIC NUMBERS eg. "5"
for (var i = 0; i < 5; i++)
{
    //Console.WriteLine(scores[i]);
    Console.WriteLine($"The length of scoress is {scores.Length} | The index is: {i}) | The value is: {scores[i]}");
}

Console.ReadLine();