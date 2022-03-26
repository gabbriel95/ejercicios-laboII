using System;

namespace LogicaNegocio
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta) {

            bool validacion = false;
            if (respuesta == "S" || respuesta == "s") {
            
                validacion = true; 
            }

            return validacion;
        }
    }
}
