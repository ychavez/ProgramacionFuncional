using System;
using System.Linq;

namespace ProgramacionFuncional
{

    /// <summary>
    /// Objetivo: encontrar el primer caracter no duplicado en la variable "Palabra"
    /// </summary>
    public class _Func
    {
        public static void Run()
        {
            string Palabra = "aassessdds";
            System.Console.WriteLine(PrimerNoRepetidoClassic(Palabra));
            System.Console.WriteLine(GetNoRepetido(Palabra));
        }

        public static Func<string, char> GetNoRepetido = (s) => s.ToCharArray()
                                                                        .GroupBy(x => x)
                                                                        .Where(x => x.Count() == 1)
                                                                        .Select(x => x.Key).FirstOrDefault();

        public static char PrimerNoRepetidoClassic(string palabra)
        {
            int i, j;
            bool isRepeted = false;
            char[] chars = palabra.ToCharArray();
            for (i = 0; i < chars.Length; i++)
            {
                isRepeted = false;
                for (j = 0; j < chars.Length; j++)
                {
                    if ((i != j) && (chars[i] == chars[j]))
                    {
                        isRepeted = true;
                        break;
                    }
                }
                if (isRepeted == false)
                {
                    return chars[i];
                }
            }
            return ' ';
        }

    }
}