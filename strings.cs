// Variables are typed
string hello = "Hello Baby";
Console.WriteLine(hello);

// String Interpolation
string myDog = "Dave";
Console.WriteLine($"Hello {myDog}"); // "Hello Dave"

// Methods
// Like functions (in JS) - methods should end with arguments()
string someText = "      Here lies some text       ";
// Trim
Console.WriteLine(someText.Trim()); // "Here lies some text"
Console.WriteLine(someText.TrimStart()); // "Here lies some text      "
Console.WriteLine(someText.TrimEnd()); // "      Here lies some text"

// Replace
Console.WriteLine(sometext.Replace("lies", "is")); // "Here is some text"

// case manipulation
Console.WriteLine(sometext.ToUpper());
Console.WriteLine(sometext.ToLower());

// Search strings, returns booleans
string aBlockOfText = "Friendship is everything. Friendship is more than talent. It is more than the government. It is almost the equal of family.- Don Corleone";

Console.WriteLine(aBlockOfText.Contains("Friendship")); // true
Console.WriteLine(aBlockOfText.Contains("shotguns")); // false
// is case sensitive:
Console.WriteLine(aBlockOfText.Contains("FRIENDSHIP")); // false

Console.WriteLine(aBlockOfText.StartsWith("Friendship")); // true
Console.WriteLine(aBlockOfText.StartsWith("government")); // false
Console.WriteLine(aBlockOfText.EndsWith("Corleone")); // true

Console.WriteLine(aBlockOfText.StartsWith("friendship")); // false
// NOTE: that most sentances will probbaly end with a period "."

