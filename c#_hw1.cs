using System.Text;
using ConsoleApp1;

// 1. What type would you choose for the following numbers?
// A person's telephone number
    // uint
// A person's height
    // float
// A person's age
    // byte
// A person's gender
    // char
// A person's salary
    // decimal
// A book's ISBN
    // ulong
// A book's price
    // decimal
// A book's shipping weight
    // float
// A country's population
    // uint
// The number of stars in the universe
    // ulong
// The number of employees in each of the small and medium-sized businesses in the United Kingdom
    // uint

// 2. What are the difference between value types and reference type variables? What is boxing and unboxing?
    // value directly hold the value while reference holds the memory address or reference for this value. 
	// value types are stored in stack memory but reference types are stored in heap memory.
	// value type will not be collected by garbage collector but reference type will be collected by the garbage collector.
	// value type can be created by struct, enum while referene type can be created by class, interface delegate or array.
	// value type can't accept NULL, while referene type can accept NULL values.
    //Boxing is the process of converting a value type to a reference type, while unboxing is the process of converting a reference type to a value type.
// 3. What is meant by the terms managed resources and unmanaged resources in .NET?
    // Managed resources are resources that are managed by the .NET runtime, while unmanaged resources are resources that are managed by the developer.
    // Managed resources are automatically managed by the garbage collector, while unmanaged resources must be manually managed by the developer.
    // For example, managed heap memory is organized by garbage collector, while unmanaged heap needs to be manually freed, called dispose() method from IDisposable interface.
    
// 4. What is the purpose of Garbage Collector in .NET?
    // The purpose of the Garbage Collector in .NET is to automatically manage the memory used by the application, freeing up memory that is no longer needed and preventing memory leaks.
    // The Garbage Collector runs in the background, periodically checking for objects that are no longer being used and reclaiming the memory they occupy.
    // The garbage collector puts data into 3 generations, 0, 1, 2. The higher the generation, the less frequently the garbage collector will check it.

//1. Create a console application project named /02UnderstandingTypes/ that outputs the number of bytes in memory that each of the following number types uses, and the minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
namespace ConsoleApp1;
public class ByteOfTypes
{
    public void Main(string[] args)
    {
        Console.WriteLine("Data Type\tBytes\tMinimum Value\tMaximum Value");
        Console.WriteLine("sbyte\t\t{0}\t{1}\t\t{2}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("byte\t\t{0}\t{1}\t\t{2}", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("short\t\t{0}\t{1}\t\t{2}", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("ushort\t\t{0}\t{1}\t\t{2}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("int\t\t{0}\t{1}\t{2}", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("uint\t\t{0}\t{1}\t\t{2}", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("long\t\t{0}\t{1}\t{2}", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("ulong\t\t{0}\t{1}\t\t{2}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("float\t\t{0}\t{1}\t{2}", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("double\t\t{0}\t{1}\t{2}", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("decimal\t\t{0}\t{1}\t{2}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

        Console.ReadLine();
    }
}

//2. write program to enter an integer number of centuries and convert it to years, months, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds, nanoseconds. Use an appropriate data type for every data conversion. Beware of overflows!
namespace ConsoleApp1;
public class CenturyConverter
{
    public void Convert(int century)
    {
        int centuries = century;
        ulong years = (ulong)centuries * 100;
        ulong days = years * 365;
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong milliseconds = seconds * 1000;
        ulong microseconds = milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;

        Console.WriteLine(
            $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanosecond");
    }
}

//1. What happens when you divide an int variable 0?
    // When you divide an int variable by 0, you will get a runtime error, specifically a System.DivideByZeroException.
//2. What happens when you divide a double variable by 0?
    // When you divide a double variable by 0, you will get a result of either positive or negative infinity, depending on the sign of the dividend.
//3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
    // When you overflow an int variable, it will wrap around to the opposite end of its range. For example, if you set an int variable to int.MaxValue + 1, it will wrap around to int.MinValue.
//4. What is the difference between x = y++; and x = ++y;?
    // x = y++; assigns the current value of y to x and then increments y by 1, while x = ++y; increments y by 1 and then assigns the new value of y to x.
//5. What is the difference between break, continue, and return when used inside a loop statement?
    // break is used to exit the loop immediately, continue is used to skip the rest of the loop and go to the next iteration, and return is used to exit the loop and return a value from the method.
//6. What are the three parts of a for statement and which of them are required?
    // The three parts of a for statement are the initialization, condition, and iterator. The initialization and condition are required, while the iterator is optional.
//7. What is the difference between the = and == operators?
    // The = operator is used to assign a value to a variable, while the == operator is used to compare two values for equality.
//8. Does the following statement compile? for ( ; true; ) ;
    // Yes, the statement will compile. The for loop has an empty initialization and iterator, and the condition is set to true, so it will run indefinitely.
//9. What does the underscore _ represent in a switch expression?
    // The underscore _ represents the default case in a switch expression, which is executed when none of the other cases match.
//10. What interface must an object implement to be enumerated over by using the foreach statement?
    // An object must implement the IEnumerable interface to be enumerated over by using the foreach statement.

//1. FizzBuzz: The loop continues indefinitely. we can add a check condition: if (i = 500) break; to stop the loop after 500 iterations.
//2. Print a pyramid
namespace ConsoleApp1;
public class Pyramid
{
    public void PrintPyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

//3. Write a program that generates a random number between 1 and 100 and asks the user to guess it. If the user's guess is higher than the random number, the program should display "Too high", if the user's guess is lower than the random number, the program should display "Too low", and if the user's guess is correct, the program should display "Congratulations!" and exit.
namespace ConsoleApp1;
public class GuessNumber
{
    public void Guess()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int guess = 0;

        while (guess != randomNumber)
        {
            Console.Write("Enter your guess (1-100): ");
            guess = int.Parse(Console.ReadLine());

            if (guess > randomNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Congratulations!");
            }
        }
    }
}

//4. Write a program that defines a variable representing a birthdate and calculates the age of the person in days. Output the date of their next 10000 day anniversary.
namespace ConsoleApp1;
public class AgeCalculator
{
    public void CalculateAge(DateTime birthdate)
    {
        DateTime today = DateTime.Today;
        TimeSpan age = today - birthdate;
        int ageInDays = age.Days;

        Console.WriteLine($"Age in days: {ageInDays}");

        DateTime nextAnniversary = birthdate.AddDays(10000);
        Console.WriteLine($"Next 10000 day anniversary: {nextAnniversary:yyyy-MM-dd}");
    }
}

//5. Write a program that greets the user using the appropriate greeting based on the current time of day. Use only if, not else or switch.
namespace ConsoleApp1;
public class Greeting
{
    public void Greet()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;

        if (hour < 12)
        {
            Console.WriteLine("Good morning!");
        }

        if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good afternoon!");
        }

        if (hour >= 18 && hour < 21)
        {
            Console.WriteLine("Good evening!");
        }
        if (hour >= 21)
        {
            Console.WriteLine("Good night!");
        }
    }
}

//6. Write a program that prints the result of counting up to 24 using four different increments: 1, 2, 3, and 4.
namespace ConsoleApp1;
public class Counting
{
    public void Count()
    {
        for (int i = 0; i <= 24; i++)
        {
            Console.Write(i + ",");
        }

        Console.WriteLine();

        for (int i = 0; i <= 24; i += 2)
        {
            Console.Write(i + ",");
        }

        Console.WriteLine();

        for (int i = 0; i <= 24; i += 3)
        {
            Console.Write(i + ",");
        }

        Console.WriteLine();

        for (int i = 0; i <= 24; i += 4)
        {
            Console.Write(i + ",");
        }

        Console.WriteLine();
    }
}