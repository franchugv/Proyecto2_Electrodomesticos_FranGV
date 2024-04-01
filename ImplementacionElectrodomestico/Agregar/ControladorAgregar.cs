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

            string mError = "";
            bool esValido;
            MenuElectrodomesticos opcion = MenuElectrodomesticos.Salir;

            // Menu

            do
            {
                esValido = true;
                try
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

                }
                catch(Exception Error)
                {
                    esValido = false;
                    mError = Error.Message;
                }
                finally
                {
                    if (!esValido) MetodosPrincipales.MostrarError(mError);
                }

            } while (opcion != MenuElectrodomesticos.Salir || !esValido);





        }
    }
}
