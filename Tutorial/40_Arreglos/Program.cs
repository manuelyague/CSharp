using System;

namespace _40_Arreglos
{
    class Program
    {
        private static void Main(string[] args)
        {
			//casoSinArreglo();
			casoConArreglo();
            
        }

		private static void casoConArreglo()
		{
			double[] calif = new double[3];

			double promedio = 0.0;
			double sumatoria = 0.0;
			double diferencia = 0.0;
			int n = 0;
			string dato = "";
			int cantCalif = 0;

			Console.WriteLine("Calificaciones a ingresar:");
			cantCalif = Convert.ToInt32(Console.ReadLine());
            
			for (n = 0; n < cantCalif; n++)
			{
				Console.WriteLine("Ingresar calificación");
				dato = Console.ReadLine();
				calif[n] = Convert.ToDouble(dato);
			}

			for (n = 0; n < cantCalif; n++)
			{
				sumatoria += calif[n];
			}

			promedio =  sumatoria / cantCalif;

			for (n = 0; n < cantCalif; n++)
			{
				diferencia = promedio - calif[n];
				Console.WriteLine("{0}, {1}, {2}", calif[n], promedio, promedio);
			}


		}

		private static void casoSinArreglo()
		{
			
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

            diferencia = promedio - calif1;
            Console.WriteLine("Nota 1:{0}, promedio {1}, diferencia {2}", calif1, promedio, diferencia);

            diferencia = promedio - calif2;
            Console.WriteLine("Nota 2:{0}, promedio {1}, diferencia {2}", calif2, promedio, diferencia);

            diferencia = promedio - calif3;
            Console.WriteLine("Nota 3:{0}, promedio {1}, diferencia {2}", calif3, promedio, diferencia);
		}
    }
}
