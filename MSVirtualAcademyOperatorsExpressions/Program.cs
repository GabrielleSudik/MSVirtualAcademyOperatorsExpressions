using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //statements are the lines of code/thought.
            //expressions are the parts of the statement
            //operators are the parts of expressions

            int x; //int is an operator -- it's what's happening.
            //the ; is an operator -- it ends the statement
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);

            Console.ReadLine(); //() is an operator -- it calls a method

            Console.WriteLine("What's your name?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}.");

            Console.ReadLine();

            int a, b, c, d; //don't forget you can declare multiple variables on one line

            a = 2 * 3; //the * is the operator

            b = 5 - 3; //the - is the operator

            //these are conditional operators:

            if ( a == b)
            {
                //the == is an operator. 
                //ditto && and || etc...
            }

            //don't forget in-line conditional operator:

            c = 2;
            string message = (c == 1) ? "hi" : "bye";

            //hmm, can you do that with Methods?
            //or if you have only one choice, like "quit" maybe?
        }
    }
}
