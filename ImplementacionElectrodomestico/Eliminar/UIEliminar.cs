using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Eliminar
{
    public static class UIEliminar
    {
        public static void MenuEliminar(List<Electrodomestico> ListaEl)
        {
            Console.Clear();

            Console.WriteLine("\n\t\t- Menú Eliminar -");
            Console.WriteLine("-------------------------------------------------------------------\n");           

            MetodosPrincipales.MostrarNumLista(ListaEl);
            Console.Write("\tElija una cuenta a Eliminar: ");

        }
    }
}
