using System;

class ejercicio1
{
    static void Main()
    {
        int[] añoA = new int[] { 2012, 2013, 2014, 2015,2016, 2017, 2018, 2019, 2020 }; 
        foreach (int añoB in añoA)
        {
            if (DateTime.IsLeapYear(añoB))
            {
                Console.WriteLine($"{añoB} es año biciesto.");

            }
            else
                Console.WriteLine($"{añoB} no es un biciesto.");
        }

    }

}

