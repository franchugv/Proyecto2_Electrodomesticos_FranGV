using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Eliminar
{
    public static class MetodosEliminar
    {

        public static void EliminarElectrodomestico(List <Electrodomestico> ListaEl, byte opcion)
        {
            // RECURSOS

            bool esCorrecto;

            Console.WriteLine("\n¿Desea Eliminar este Electrodoméstico?\n");
            esCorrecto = MetodosPrincipales.CaptarBool();

            if (esCorrecto)
            {
                ListaEl.Remove(ListaEl[opcion]);
                EliminacionHecha();
            }
        }

        private static void EliminacionHecha()
        {
            Console.Clear();
            Console.WriteLine("\nElectrodoméstico eliminado.");
            MetodosPrincipales.Pausa();
        }

    }
}
