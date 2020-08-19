// Types are specific forms of data with specific structure & set limits.
    // Value types store data directly
    // Referance types store referances to data stored elsewheer. (Think of a shortcut on your computer).

// All types will be stored in multiples of 8 bits (1 byte).

// Integral types - Storing whole numbers. (Smallest > largest). 
sbyte mySByte; // -128 to 127, signed 8 bit
byte myByte; // 0 to 255, unsigned 8 bit
short myShort; // -32,768 to 32,767, signed 16 bit
ushort myUShort; // 0 to 65,535, unsigned 16 bit
int myInt; // -2,147,483,648 to 2,147,483,647 signed 32 bit
uint myUInt; // 0 to 4,294,967,295 unsigned 32 bit
long myLong; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 signed 64 bit
ulong myULong; // 0 to 18,446,744,073,709,551,615 unsigned 64 bit

// Floating point numbers - decimals will be rounded off to the below:
float myFloat; // Approx 6-9 digits, 32 bit
double myDouble; // Approx 15-17 digits, 64 bit
decimal myDecimal; // Approx 28-29 digits, 128 bit
// Floating point types cannot be unsigned (this is due to CPU operation rather than a C# limitation, most languages also have this limitation).

// Other simple types
bool myBool; // True || False logical type (8 bit, the smallest value C# will allow you to store)
char myChar; // A single 'Character' represents unicode characters(16 bit, 65,535 possible characters stored) 
// Character literals should be written with 'single quotes'
string myString; // An array of char's. 
// Strings should be written in "double quotes"

// Mnay other types exsist in C# such as 
DateTime myDate;
TimeSpan myTime;
// etc. However those are all made up of the above simple types

