using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Agregar
{

    public static class ControladorAgregar
    {

        public static void ControladorA(List <Electrodomestico> ListaE)
        {

            // RECURSOS

            bool esValido;
            MenuAgregar opcion = MenuAgregar.Salir;

            // Menu

            do
            {
                UIAgregar.MenuAgregar();
                // RESET

                esValido = true;

                opcion = (MenuAgregar)MetodosPrincipales.CaptarOpcion((byte)Enum.GetValues<MenuAgregar>().Length);

                switch (opcion)
                {
                    case MenuAgregar.Lavadora:
                        MetodosAgregar.AgregarLavadora(ListaE);
                        break;
                    case MenuAgregar.Television:
                        MetodosAgregar.AgregarTelevision(ListaE);
                        break;
                    case MenuAgregar.Salir:
                        break;
                }

            } while (!esValido || opcion != MenuAgregar.Salir);

            UIAgregar.MenuAgregar();




        }
    }
}
