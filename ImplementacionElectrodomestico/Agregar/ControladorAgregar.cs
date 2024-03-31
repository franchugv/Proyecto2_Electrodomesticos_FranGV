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


                opcion = (MenuAgregar)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<MenuAgregar>().Length);

                switch (opcion)
                {
                    case MenuAgregar.Salir:
                        break;
                    case MenuAgregar.Lavadora:
                        MetodosAgregar.AgregarLavadora(ListaE);
                        break;
                    case MenuAgregar.Television:
                        MetodosAgregar.AgregarTelevision(ListaE);
                        break;

                }

            } while (opcion != MenuAgregar.Salir);





        }
    }
}
