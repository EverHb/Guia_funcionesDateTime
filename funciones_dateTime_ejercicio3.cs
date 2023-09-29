using System;

class ejercicio3
{
  static void Main() 
  {
     Console.WriteLine("ingrese su fecha de cumpleaños (MM/DD):");
      string fechaCumpleañosStr = Console.ReadLine();

    if (DateTime.TryParse(fechaCumpleañosStr, out DateTime fechaCumpleaños))
    {
         DateTime fechaActual = DateTime.Today;

      TimeSpan tiempoRestante = fechaCumpleaños - fechaActual;

       if (tiempoRestante.TotalDays < 0)
       {
         fechaCumpleaños = fechaCumpleaños.AddYears(1);
         tiempoRestante = fechaCumpleaños - fechaActual;
       }

        Console.WriteLine($"Su próximo cumpleaños es el {fechaCumpleaños.ToShortDateString()}.");
        Console.WriteLine($"Faltan {tiempoRestante.Days} días para su próximo cumpleaños.");
    }
    else
    {
      Console.WriteLine("Fecha de cumpleaños no válida. Asegúrese de ingresarla en el formato correcto (MM/DD).");
    }
  }
}
