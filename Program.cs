/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement_with_Patterns
{
    class Program
    {
        static void Main()
        {
            // From C#7, you can also switch on types:
            TellMeTheType(12);
            TellMeTheType("hello");
            TellMeTheType(true);

            // You can predicate a case with the when keyword:
            switch (x)
            {
                case bool b when b == true: // Fires only when b is true
                    Console.WriteLine("True!");
                    break;
                case bool b:
                    Console.WriteLine("False!");
                    break;
            }
            /* The order of the case clauses can matter when switching on
             type (unlike switching on constants). This example would give 
             a different result if we reversed the two cases (in fact, it
             would not even compile, because the compiler would determine
             that the second case is unreachable). An exception to this
             rule is the default clause, which is always executed last,
             regardless of where it appears. */
            /* You can stack multiple case clauses. The Console.WriteLine
             int the following code will execute for any floating-point
             type greater than 1000:  */
            /* In this example, the compiler lets us consume the pattern
             variables f, d, and m ONLY in the when clauses. When we call
             Console.WriteLine, it's unknown as to which one of those three
             variables will be assigned, so the compiler puts all of them
             out of scope. */
            switch (x)
            {
                case float f when f > 1000:
                case double d when d > 1000:
                case decimal m when m > 1000:
                    Console.WriteLine("We can refer to x here but not f or d or m");
            }
            /* You can mix and match constants and patterns in the same switch
             statement. And you can also switch on the null value: */
            switch (x)
            {
                case null:
                    Console.WriteLine("Nothing here");
                    break;
            }
        }
        static void TellMeTheType(object x) //Object allows any type
        {
            switch (x)
            {
                /* Each case clause specifies a type upon which to match, and
                 a variable upon which to assign the typed value if the match
                 succeeds (see the "pattern" variable). Unlike with constants,
                 there's no restriction on what types you can use. */
                case int i:
                    Console.WriteLine("It's an int!");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string!");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }
    }
}
