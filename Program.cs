using System;

namespace console_demo
{
  class Program
  {
    static void Main(string[] args)
    {
      string choice = args.Length > 0 ? args[0] : "";
      switch (choice)
      {
        case "numbers": Numbers(); break;
        case "numbers-precision": NumbersExploreIntegerPrecision(); break;
        case "numbers-double-type": NumbersDoubleType(); break;
        case "numbers-decimal-type": NumbersDecimalType(); break;
        case "branches-and-loops": BranchesAndLoops.BranchesAndLoopsMain(); break;
        default: HelloWorld(); break;
      }
    }

    static void HelloWorld()
    {
      Console.WriteLine("Hello World!");

      string aFriend = "Bill";
      Console.WriteLine(aFriend);

      Console.WriteLine("Hello " + aFriend);
      Console.WriteLine($"Hello {aFriend}");

      string firstFriend = "Maria";
      string secondFriend = "Sage";
      Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

      Console.WriteLine($"The name {firstFriend} had {firstFriend.Length} letters.");
      Console.WriteLine($"The name {secondFriend} had {secondFriend.Length} letters.");

      // Do more with strings
      string greeting = "     Hello World!      ";
      Console.WriteLine($"[{greeting}]");
      Console.WriteLine($"[{greeting.TrimStart()}]");
      Console.WriteLine($"[{greeting.TrimEnd()}]");
      Console.WriteLine($"[{greeting.Trim()}]");

      string sayHello = "Hello World";
      Console.WriteLine(sayHello);
      Console.WriteLine(sayHello.Replace("Hello", "Greetings"));
      Console.WriteLine(sayHello.ToUpper());
      Console.WriteLine(sayHello.ToLower());

      // Search strings
      string songLyrics = "You say goodbye, and I say hello";
      Console.WriteLine(songLyrics.Contains("goodbye"));
      Console.WriteLine(songLyrics.Contains("greetings"));

      // Search strings exercise
      Console.WriteLine(songLyrics.StartsWith("You"));
      Console.WriteLine(songLyrics.StartsWith("goodbye"));
      Console.WriteLine(songLyrics.EndsWith("hello"));
      Console.WriteLine(songLyrics.EndsWith("goodbye"));
    }

    static void Numbers()
    {
      int a = 18;
      int b = 6;
      int c = a + b;
      Console.WriteLine(c);

      c = a - b;
      Console.WriteLine(c);

      c = a * b;
      Console.WriteLine(c);

      c = a / b;
      Console.WriteLine(c);

      // Multiplication before addition
      a = 5;
      b = 4;
      c = 2;
      Console.WriteLine(a + b * c);

      // Force order of operations
      Console.WriteLine((a + b) * c);

      Console.WriteLine((a + b) - 6 * c + (12 * 4) / 3 + 12);

      // Integer division produces an integer
      a = 7;
      b = 4;
      c = 3;
      Console.WriteLine((a + b) / c);
    }

    static void NumbersExploreIntegerPrecision()
    {
      int a = 7;
      int b = 4;
      int c = 3;
      int d = (a + b) / c;
      int e = (a + b) % c;
      Console.WriteLine($"Quotient: {d}");
      Console.WriteLine($"Remainder: {e}");

      int max = int.MaxValue;
      int min = int.MinValue;
      Console.WriteLine($"The range of integers is {min} to {max}");

      int what = max + 3;
      Console.WriteLine($"An example of overflow: {what}");
    }

    static void NumbersDoubleType()
    {
      double a = 5;
      double b = 4;
      double c = 2;
      double d = (a + b) / c;
      Console.WriteLine(d);

      a = 19;
      b = 23;
      c = 8;
      d = (a + b) / c;
      Console.WriteLine(d);

      double max = double.MaxValue;
      double min = double.MinValue;
      Console.WriteLine($"The range of double is {min} to {max}");

      double third = 1.0 / 3.0;
      Console.WriteLine(third);
    }

    static void NumbersDecimalType()
    {
       decimal min = decimal.MinValue;
       decimal max = decimal.MaxValue;
       Console.WriteLine($"The decimal range is from {min} to {max}");

       double a = 1.0;
       double b = 3.0;
       Console.WriteLine(a / b);

       decimal c = 1.0M;
       decimal d = 3.0M;
       Console.WriteLine(c / d);

       Console.WriteLine(Math.PI*2.5*2.5);
    }
  }
}
