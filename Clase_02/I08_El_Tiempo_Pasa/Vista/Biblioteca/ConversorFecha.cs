using System;

namespace Biblioteca
{
    public class ConversorFecha
    {
        public static double ConvierteFechaADia(DateTime fechaNacimiento)
        {
            double totalDias;
            TimeSpan diferencia = DateTime.Now - fechaNacimiento;
            totalDias =  diferencia.TotalDays;

            return totalDias;
        }
    }
}
