using System;

namespace ProgramacionFuncional
{

    /// <summary>
    /// Objetivo Evaluar si el numero en la variable Numero es mayor que 10
    /// </summary>
    public class _Predicate
    {

        public static void Run()
        {
            int Numero = 10;

            Predicate<int> EvaluarNumero = x => x == 10;

            System.Console.WriteLine(EvaluarNumero(Numero));
        

        }
    }
}