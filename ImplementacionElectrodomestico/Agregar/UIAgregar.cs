using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Agregar
{
    public static class UIAgregar
    {

        public static void MenuAgregar()
        {

            Console.Clear();
            Console.WriteLine("\n\t\t- Añadir Electrodomésticos -");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\t0 - Salir.\n");
            Console.WriteLine("\t1 - Lavadora.");
            Console.WriteLine("\t2 - Televisión.\n");



            Console.Write("\tElija una opción: ");
        }



    }
}
