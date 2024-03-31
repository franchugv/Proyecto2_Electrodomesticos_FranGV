using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Modificar
{
    public static class UIModificar
    {
        public static void MenuModificar(List<Electrodomestico> ListaE)
        {
            Console.Clear();

            Console.WriteLine("\t\t- Menú Modificación -");
            Console.WriteLine("-------------------------------------------------------------------");
            MetodosPrincipales.MostrarNumLista(ListaE);

            Console.Write("\tElija el Electrodoméstico que desea Modificar: ");
        }
    }
}
