using TechInterView.Fibonacci;

A:
Console.WriteLine("Enter number that will reprsent the position in the fibonacci: ");
var input = Console.ReadLine();

if (!int.TryParse(input, out int position)) 
{
    Console.WriteLine("Insert valid number");
    goto A;
}

//Ensure absolut value
position = position < 0 ? position * -1 : position;

var result = FibNumber.GetFib(position);

Console.WriteLine($"Fibonacci number at position: {position} is {result}");