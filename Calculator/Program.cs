// See https://aka.ms/new-console-template for more information

// Ask the user to imput the numbers
Console.WriteLine("type the first number and hit enter");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("type the second number and hit enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Preform the calculation
int result = firstNumber + secondNumber;

// Output answer to console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);





