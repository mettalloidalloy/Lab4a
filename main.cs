using System;
using System.Linq;

class MainClass 
{
    public static void Main (string[] args) 
    {
        double[] celsius = new double[7];
        double[] fahrenheit = new double[7];
        int i = 0;
        double sum = 0;
        double average;
        while (i < 7) 
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double cTemp = Convert.ToDouble(Console.ReadLine());
            celsius[i] = cTemp;
            double fTemp = (cTemp * 9 / 5) + 32;
            fahrenheit[i] = fTemp;
            i++;
        }
        Array.Sort(fahrenheit);
        Array.Reverse(fahrenheit);
        foreach (double fTemp in fahrenheit) 
        {
            Console.WriteLine(fTemp);
            sum += fTemp;
        }
        average = sum / fahrenheit.Length;
        Console.WriteLine("Average weekly temperature in Fahrenheit is " + average + " degrees");
    }
}