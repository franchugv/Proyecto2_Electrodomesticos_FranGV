using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Eliminar
{
    public static class ControladorEliminar
    {

        public static void ControladorEliminarElectrodomesticos(List<Electrodomestico> ListaE)
        {
            // RECURSOS

            byte opcion;

            UIEliminar.MenuEliminar(ListaE);

            opcion = MetodosPrincipales.CaptarByteLista(ListaE);

            MetodosEliminar.EliminarElectrodomestico(ListaE, opcion);



        }
    }
}
