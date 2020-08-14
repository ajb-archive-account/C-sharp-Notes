// if...else statements are commonly written as follows:
int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
  Console.WriteLine("The answer is greater than 10");
  Console.WriteLine("And the first number is equal to the second");
}
else
{
  Console.WriteLine("The answer is not greater than 10");
  Console.WriteLine("Or the first number is not equal to the second");
}

// While loops - Checks a condition and executes code while the condition is true.
int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}

// do...while loops - executes the code first, then checks the condition.
int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);

// for loops
for (int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}

// Nested loops
for (int row = 0; row < 10; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}

// e.g. find the sum of all int's divisible by 3
int sum = 0;
for (int i = 1; i <= 20; i++)
{
  if (i % 3 == 0)
  {
    sum = sum + i;
  }
}

Console.Write(sum);