﻿using System;

namespace LogicaNegocio
{
    public static class Rangos
    {
        public static bool Validar(int valor, int min, int max) {

            bool valido = false;

            if (valor >= min && valor <= max) {

                valido = true;
            }
            return valido;
        }
    }
}
