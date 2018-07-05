Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Text;

class Program{
    public static void Main(){

        double calif1 = 0.0;
        double calif2 = 0.0;
        double calif3 = 0.0;
        double promedio = 0.0;
        double diferencia = 0.0;
        string dato = "";

        Console.WriteLine("Nota 1");    
        dato = Console.ReadLine();
        calif1 = Convert.ToDouble(dato);

        Console.WriteLine("Nota 2");
        dato = Console.ReadLine();
        calif2 = Convert.ToDouble(dato);

        Console.WriteLine("Nota 3");
        dato = Console.ReadLine();
        calif3 = Convert.ToDouble(dato);

        promedio = (calif1 + calif2 + calif3) / 3.0;

        diferencia = promedio -calif1;
        Console.WriteLine("Nota 1:{0}, promedio {1}, diferencia {2}", calif1,promedio,diferencia);

        diferencia = promedio -calif2;
        Console.WriteLine("Nota 2:{0}, promedio {1}, diferencia {2}", calif2,promedio,diferencia);

        diferencia = promedio -calif3;
        Console.WriteLine("Nota 3:{0}, promedio {1}, diferencia {2}", calif3,promedio,diferencia);
    }
}