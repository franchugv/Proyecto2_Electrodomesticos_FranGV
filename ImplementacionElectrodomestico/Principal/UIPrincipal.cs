using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Principal
{
    public static class UIPrincipal
    {

        public static void MenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("\t- Menú principal -");
            Console.WriteLine("0 - Agregar Electrodomestico.\n");
            Console.WriteLine("1 - Eliminar Electrodomestico.\n");
            Console.WriteLine("2 - Consultar Electrodomesticos.\n");
            Console.WriteLine("3 - Modificar Electrodomesticos.\n");
            Console.WriteLine("4 - Salir.\n");

            Console.Write("\tElija una opción: ");

        }

        public static void MenuColor()
        {
            Console.Clear();

            Console.WriteLine("\t- Menú Colores -");
            Console.WriteLine("0 - Azul.\n");
            Console.WriteLine("1 - Rojo.\n");
            Console.WriteLine("2 - Negro.\n");
            Console.WriteLine("3 - Blanco.\n");

            Console.Write("\tElija una opción: ");
        }

    }
}
