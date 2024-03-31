using ImplementacionElectrodomestico.Agregar;
using ImplementacionElectrodomestico.Consultar;
using ImplementacionElectrodomestico.Eliminar;
using Proyecto2_Electrodomesticos_FranGV;

namespace ImplementacionElectrodomestico.Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RECURSOS

            List<Electrodomestico> ListaElectrodomesticos = new List<Electrodomestico>();
            MenuPrincipal opcion = MenuPrincipal.Salir;
            bool esValido;
            string MensajeError = "";



            do
            {

                // RESET

                esValido = true;

                UIPrincipal.MenuPrincipal();
                // Captar opción

                try
                {
                    opcion = (MenuPrincipal)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<MenuPrincipal>().Length);


                    switch (opcion)
                    {
                        case MenuPrincipal.Salir:

                            break;
                        case MenuPrincipal.Agregar:
                            ControladorAgregar.ControladorA(ListaElectrodomesticos);

                            break;
                        case MenuPrincipal.Eliminar:
                            ControladorEliminar.ControladorEliminarElectrodomesticos(ListaElectrodomesticos);

                            break;
                        case MenuPrincipal.Consultar:
                            ControladorConsultar.ControladorConsultas(ListaElectrodomesticos);

                            break;
                        case MenuPrincipal.Modificar:

                            break;
                    }
                }


                catch (ArgumentException error)
                {
                    esValido = false;
                    MensajeError = "No ha introducido ninguna opción";
                }
                catch (OverflowException error)
                {
                    esValido = false;
                    MensajeError = "La opción seleccionada no está entre las propuestas";
                }
                catch (FormatException error)
                {
                    esValido = false;
                    MensajeError = "No ha introducido un valor numérico";
                }
                catch (Exception error)
                {
                    esValido = false;
                    MensajeError = error.Message;
                }
                finally
                {
                    if (!esValido) MetodosPrincipales.MostrarError(MensajeError);
                }

            } while (opcion != MenuPrincipal.Salir || !esValido);
        }
    }
}
