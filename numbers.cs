// C# has BODMAS precedence
int a = 5;
int b = 4;
int c = 5 / 4;
Console.WriteLine(c); // 1
// Division will return only a whole number (definition of an integer).

// Use % to find remainders, e.g:
int d = 5 % 4;
Console.WriteLine($"{c} remainder: {d}"); // 1 remainder: 1

// C# intergers have min an max limits 
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}"); // The range of integers is -2147483648 to 2147483647

// if you tried:
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// You would return: An example of overflow: -2147483646
// This is an example of "overflow" because the code has overflowed the max value by +3 and looped back to the start of it's number sequence starting at -2147483648

// Use the "double" type to represent floating point numbers
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d); // 4.5

// Double-precision is the use of twice the binary digits to compute the sum (Single precision numbers are declared using the "float" keyword). 

//The range of floating point numbers is much larger than whole integers. 
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}"); // The range of double is -1.79769313486232E+308 to 1.79769313486232E+308
// NOTE: that E+308 is representing some number TO THE POWER OF 308

// The decimal type has a smaller range than double but greater precision.
// The M suffix is used to denote decimal types. E.g:
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b); // 0.333333333333333

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d); // 0.3333333333333333333333333333

//

Math.PI // is a public const double. E.g: Radius of a circle

double Radius = 2.5;
double area = (Radius * Radius) * Math.PI;
Console.WriteLine(area); // 19.6349540849362

