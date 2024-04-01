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
            Console.WriteLine("\t0 - Salir.\n");
            Console.WriteLine("\t1 - Marca.");
            Console.WriteLine("\t2 - Modelo.");
            Console.WriteLine("\t3 - Precio Base.");
            Console.WriteLine("\t4 - Color.");
            Console.WriteLine("\t5 - Consumo.");
            Console.WriteLine("\t6 - Peso.");
            Console.WriteLine("\t7 - Incrementar Stock.");
            Console.WriteLine("\t8 - Decrementar Stock.");
            Console.WriteLine("\t9 - Carga.");
            Console.WriteLine("\t10 - Resolución.");
            Console.WriteLine("\t11 - TDT.\n");


            MetodosPrincipales.MostrarNumLista(ListaE);

            Console.Write("\tElija lo que desea Modificar: ");
        }

        public static void MenuModificarOpcion()
        {
            Console.Write("\n\n\tEspecifique el electrodoméstico que desea modificar: ");
        }
    }
}
