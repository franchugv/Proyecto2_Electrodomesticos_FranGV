using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Principal
{
    public enum MenuPrincipal : byte { Agregar, Eliminar, Consultar, Modificar, Salir }

    public static class ControladorPrincipal
    {

        public static void ControladorP()
        {
            UIPrincipal.MenuPrincipal();
        }
    }
}
