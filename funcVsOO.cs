using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProgramacionFuncional
{
    public class funcVsOO
    {
        /// <summary>
        /// Objetivo encontrar si el registro existe en la lista de strings
        /// </summary>
        public static void Test()
        {
            var nombres = new List<string>() { "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Yael" };


            var cronometro = Stopwatch.StartNew();
            cronometro.Start();
            System.Console.WriteLine(EncontrarNombre(nombres, "Yael"));
            cronometro.Stop();
            System.Console.WriteLine(cronometro.Elapsed);

            cronometro.Restart();
            System.Console.WriteLine(EncontrarNombreFunc(nombres, "Yael"));
            cronometro.Stop();
            System.Console.WriteLine(cronometro.Elapsed);
           
           
            Func<List<string>, bool> funcionBasica = x => x.Any(y => y == "Yael");
            System.Console.WriteLine(EncontrarNombreDelegate(nombres,funcionBasica));


        }

        public static bool EncontrarNombre(List<string> nombres, string nombreBuscado)
        {
            foreach (var nombre in nombres)
            {
                if (nombre == nombreBuscado)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool EncontrarNombreDelegate(List<string> nombres, Func<List<string>, bool> evaluacion)
         => evaluacion(nombres);



        static Func<List<string>, string, bool> EncontrarNombreFunc = (x, y) => x.Any(s => s == y);

    }
}