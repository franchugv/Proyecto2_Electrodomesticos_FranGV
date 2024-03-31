using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Modificar
{
    public static class ControladorModificar
    {
        public static void ControladorModificarElectrodomestico(List<Electrodomestico> ListaE)
        {
            // RECURSOS
            byte opcion;

            UIModificar.MenuModificar(ListaE);

            opcion = MetodosPrincipales.CaptarByteLista(ListaE);

            MetodosModificar.ModificarDatos(ListaE, opcion);
        }
    }
}
