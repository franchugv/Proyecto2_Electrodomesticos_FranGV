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
            Console.WriteLine("\t- Añadir Electrodomésticos -");
            Console.WriteLine("0 - Lavadora.\n");
            Console.WriteLine("1 - Televisión.\n");
            Console.WriteLine("2 - Salir.\n");

            Console.Write("\tElija una opción: ");
        }

    }
}
