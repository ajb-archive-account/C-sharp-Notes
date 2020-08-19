// creat a new variable, List<type> (List<T>) 
var names = new List<string> { "<name>", "Ana", "Felipe" };
// for each "name" in names, print to the console
// NOTE: <name> will default to item if not present
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
// Hello <NAME>!
// Hello ANA!
// Hello FELIPE!

// modify the List
Console.WriteLine();
names.Add("Bill"); // to the end of the list
names.Add("George");
names.Remove("Ana");
foreach (var name in names) // var name, you are declaring the variable name of the elements.
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
// Hello <NAME>!
// Hello FELIPE!
// Hello BILL!
// Hello GEORGE!

// Referance items by index
Console.WriteLine($"My name is {names[0]}."); // My name is <name>.
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list."); // I've added Bill and George to the list.

// Check how long the list is using the "count" property
Console.WriteLine(names.Count()); // 4

IndoxOf(); // returns the list position of an element (the "index of")
Console.WriteLine(IndoxOf("Bill")); // 2

var whereIsFil = names.IndexOf("Felipe");
if (whereIsFil != -1)
  Console.WriteLine($"The name {names[whereIsFil]} is at index {whereIsFil}"); // The name Felipe is at index 1

var notFound = names.IndexOf("Not Found");
  Console.WriteLine($"When an item is not found, IndexOf returns {notFound}"); // When an item is not found, IndexOf returns -1

// The "Sort" method can be used to sort intems in a list to their normal order. (for example alphabetically for strings or in numeric order)
names.Sort();
foreach (var name in names);

Console.WriteLine($"Hello {name.ToUpper()}!");

// Hello < NAME > !
// Hello BILL!
// Hello FELIPE!
// Hello GEORGE!