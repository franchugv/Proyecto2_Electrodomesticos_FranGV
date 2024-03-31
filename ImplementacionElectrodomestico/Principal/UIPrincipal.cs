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

            Console.WriteLine("\n\t\t- Menú principal -");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\t0 - Salir.\n");
            Console.WriteLine("\t1 - Agregar Electrodomésticos.");
            Console.WriteLine("\t2 - Eliminar Electrodomésticos.");
            Console.WriteLine("\t3 - Consultar Electrodomésticos.");
            Console.WriteLine("\t4 - Modificar Electrodomésticos.");

            Console.Write("\tElija una opción: ");

        }

        public static void MenuColor()
        {
            Console.Clear();

            Console.WriteLine("\t\t- Menú Colores -");

            Console.WriteLine("\t0 - Blanco.");
            Console.WriteLine("\t1 - Negro.");
            Console.WriteLine("\t2 - Azul.");
            Console.WriteLine("\t3 - Rojo.");
            Console.WriteLine("\t4 - Gris.");

            Console.Write("\tElija una opción: ");
        }

        public static void MenuBool() 
        {

            Console.WriteLine("\t\t- Menú Elección -");
            Console.WriteLine("\t0 - SI.");
            Console.WriteLine("\t1 - No.\n");

            Console.Write("\tElija una opción: ");
        }

    }
}
