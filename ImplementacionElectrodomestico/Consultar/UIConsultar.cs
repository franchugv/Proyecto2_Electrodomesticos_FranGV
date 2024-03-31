using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Consultar
{
    public static class UIConsultar
    {
        public static void MenuConsultar(List <Electrodomestico> ListaE)
        {
            Console.Clear();

            Console.WriteLine("\n\t\t- Menú Consultar -");
            Console.WriteLine("-------------------------------------------------------------------");

            // Mostrar Nº de opciones
            MetodosPrincipales.MostrarNumLista(ListaE);

            Console.Write("\tElija un Electrodoméstico: ");
        }
    }
}
