using System;

namespace NumeroArmstrong
{
    public static class ValidarNumeroArmstrong
    {
        public static bool IsArmstrong(this int numero)
        {
            var expoente = numero.ToString().Length;

            double resultado = 0;

            for (int i = 1; i <= expoente; i++)
            {
                var auxiliar = double.Parse(numero.ToString().Substring(i - 1,1));

                resultado += Math.Pow(auxiliar, expoente);
            }

            int aux = (int) resultado;

            if (aux == numero)
                return true;

            return false;
        }
    }
}
