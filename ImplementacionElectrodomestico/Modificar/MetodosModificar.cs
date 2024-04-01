using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Modificar
{
    public static class MetodosModificar
    {

        private static bool Eleccion(string text)
        {
            bool esCorrecto;
            Console.Clear();
            Console.WriteLine($"\n{text}\n");
            esCorrecto = MetodosPrincipales.CaptarBool();
            return esCorrecto;
        }
    }
}
