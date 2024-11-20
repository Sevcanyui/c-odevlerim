using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int mynum, remainder, res = 0;
        Console.Write("sayınızı giriniz: ");
        mynum = int.Parse(Console.ReadLine());
        for (int m = mynum; m > 0; m = m / 10)
        {
            remainder = m % 10;
            res = res + remainder * remainder * remainder;
        }
        if (res == mynum)
        {
            Console.Write("girdiğiniz sayı armstrong sayısıdır.");
        }
        else
            Console.Write("girdiğiniz sayı armstrong sayısı değildir");
        Console.ReadLine();
    }
}