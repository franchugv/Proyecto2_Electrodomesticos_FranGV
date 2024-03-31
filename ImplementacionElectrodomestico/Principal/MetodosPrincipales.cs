using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Principal
{
    public static class MetodosPrincipales
    {
        public static void MenuController()
        {
            byte opcion = 0;
            bool esValido = true;
            string MensajeError = "";



            do
            {
                try
                {
                    esValido = true;


                    switch (opcion)
                    {
                        case (byte)MenuPrincipal.Agregar:

                            break;
                        case (byte)MenuPrincipal.Eliminar:

                            break;
                        case (byte)MenuPrincipal.Consultar:

                            break;
                        case (byte)MenuPrincipal.Modificar:

                            break;
                        case (byte)MenuPrincipal.Salir:

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
                    if (!esValido) MostrarError(MensajeError);
                }

            } while (!esValido || opcion != (byte)MenuPrincipal.Salir);
        } 

        public static void MostrarError(string mError)
        {
            Console.WriteLine($"ERROR: {mError}");
            Console.WriteLine("Pulse Enter para continuar");
            Console.ReadLine();
        }

    }
}
