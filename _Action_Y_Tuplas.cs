using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacionFuncional
{

    /// <summary>
    /// Crear una funcion que retorne una tupla de delegados para realizar un Crud
    /// </summary>
    public class _Action_Y_Tuplas
    {
        public static void Run()
        {
            var personas = Personas();
            personas.Agregar("Yael");
            personas.Agregar("Pedro");
            personas.Agregar("Juan");
            personas.Agregar("Jose");

            personas.Eliminar("Yael");
            System.Console.WriteLine($" el total de cuenta de datos es {personas.Cuenta()}");
            personas.Consultar();


        }

        public static (Action<string> Agregar, Action<string> Eliminar, Action Consultar, Func<int> Cuenta) Personas()
        {
            List<string> datos = new List<string>();

            Action consultar = () => datos.ForEach(x => System.Console.WriteLine(x));

            Action<string> agregar = (s => datos.Add(s));

            Action<string> eliminar = x => datos.Remove(x);

            Func<int> cuenta = () => datos.Count();

            return 
            (
              agregar,
              eliminar,
              consultar,
              cuenta
            );

        }



    }
}