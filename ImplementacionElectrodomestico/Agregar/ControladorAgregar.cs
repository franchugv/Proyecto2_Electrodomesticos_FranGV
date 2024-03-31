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
            MenuElectrodomesticos opcion = MenuElectrodomesticos.Salir;

            // Menu

            do
            {
                UIAgregar.MenuAgregar();
                // RESET


                opcion = (MenuElectrodomesticos)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<MenuElectrodomesticos>().Length);

                switch (opcion)
                {
                    case MenuElectrodomesticos.Salir:
                        break;
                    case MenuElectrodomesticos.Lavadora:
                        MetodosAgregar.AgregarLavadora(ListaE);
                        break;
                    case MenuElectrodomesticos.Television:
                        MetodosAgregar.AgregarTelevision(ListaE);
                        break;

                }

            } while (opcion != MenuElectrodomesticos.Salir);





        }
    }
}
