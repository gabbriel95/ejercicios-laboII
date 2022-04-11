using System;
using Biblioteca;

namespace SistemaAutoNavegacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado [] empleados = new Empleado [3];
            empleados[0] = new Empleado();
            empleados[1] = new Empleado();
            empleados[2] = new Empleado();


            for (int i = 0; i < empleados.Length; i++)
            {
                empleados[i].SetNombreEmpleado();
                empleados[i].SetDias();
                Console.WriteLine(empleados[i].GetAcumuladorKm());
            }

            Console.WriteLine($"El maximo conductor de la semana es {Empleado.CalcularMaximoConductorXSemana(empleados)}");
            Console.WriteLine($"El maximo conductor del dia 3 es {Empleado.CalcularMaximoKmXDia(empleados, 3)}");
            Console.WriteLine($"El maximo conductor del dia 5 es {Empleado.CalcularMaximoKmXDia(empleados, 5)}");










        }


    }
}
