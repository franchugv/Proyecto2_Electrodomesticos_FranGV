using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Consultar
{
    public static class MetodosConsultar
    {

        public static void MostrarDatos(byte opcion, List<Electrodomestico> ListaE)
        {
            Console.Clear();
            Console.WriteLine("\n\tConsulta");
            Console.WriteLine("-------------------------------------------------------------------\n");
            Console.WriteLine($"{ListaE[opcion].ToString()}");
        }

    }
}
