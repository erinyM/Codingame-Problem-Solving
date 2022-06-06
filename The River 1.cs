using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class The River
{
    static void Main(string[] args)
    {
        //Read inputs.
        long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());

        //Find meeting point.
        while (r1 != r2)
        {
            if (r1 < r2)
            {
                r1 = GetNextRiverNumber(r1);
            }
            else
            {
                r2 = GetNextRiverNumber(r2);
            }
        }

        //Output meeting point.
        Console.WriteLine(r1);
    }
    
    //Calculates the a following river number (e.g 7 -> 14, 14 -> 19, etc).
    private static long GetNextRiverNumber(long riverNumber)
    {
        long nextRiverNumber = riverNumber;
        
        while (riverNumber > 0)
        {
            nextRiverNumber += riverNumber % 10;
            riverNumber -= riverNumber % 10;
            riverNumber /= 10;
        }
        
        return nextRiverNumber;
    }
    }
