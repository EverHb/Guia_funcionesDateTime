using System;

class ejercicio2
{
    static void Main()
    {
        decimal Prestamo = 3000;
        int plazoMeses = 6;
        decimal tasaInteresMensual = 0.05m; 

        decimal cuotaMensual = Prestamo * (tasaInteresMensual * (decimal)Math.Pow(1 + (double)tasaInteresMensual, plazoMeses)) / ((decimal)Math.Pow(1 + (double)tasaInteresMensual, plazoMeses) - 1);

        DateTime fechaInicio = DateTime.Today;

        Console.WriteLine("Fecha de Pago \t Cuota a Pagar");
        for (int i = 0; i < plazoMeses; i++)
        {
            DateTime fechaPago = fechaInicio.AddMonths(i + 1);
            Console.WriteLine($"{fechaPago.ToString("dd-MM-yyyy")} \t {Math.Round(cuotaMensual, 2)}");
        }
    }
}

