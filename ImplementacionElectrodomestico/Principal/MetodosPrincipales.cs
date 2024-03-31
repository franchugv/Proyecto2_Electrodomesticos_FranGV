using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Principal
{
    public enum MenuPrincipal : byte { Agregar, Eliminar, Consultar, Modificar, Salir }

    public enum MenuAgregar : byte { Lavadora, Television, Salir }

    public static class MetodosPrincipales
    {


        public static void MostrarError(string mError)
        {
            Console.WriteLine($"ERROR: {mError}");
            Console.WriteLine("Pulse Enter para continuar");
            Console.ReadLine();
        }

        public static byte CaptarOpcion(byte NumElementos)
        {
            // El NumElementos debe ser el Length del Enum
            // RECURSOS

            byte opcion = 0;
            string aux = "";

            // ENTRADA

            aux = Console.ReadLine();

            // VALIDACIÓN

            if (string.IsNullOrEmpty(aux)) throw new CadenaVaciaExpection();

            // Preparación de la cadena, dejarla sin espacios laterales

            aux = aux.Trim();

            // CONVERSIÓN

            opcion = Convert.ToByte(aux);

            // VALIDACIÓN de que no supere el número de elementos

            if (opcion >= NumElementos) throw new MaximoException();



            // SALIDA

            return opcion;

        }

        public static void MostrarNumLista(List <Electrodomestico> ListaE)
        {
            Console.WriteLine($"Nº de Electrodomésticos: ({ListaE.ToArray().Length}\n)");
        }

        public static string CaptarCadena(string Text)
        {
            string cadena = "";

            Console.Write($"Escriba {Text}: ");

            cadena = Console.ReadLine();

            return cadena;
        }

        public static char CaptarCaracter(string Text)
        {
            string aux = "";
            char caracter = '-';

            Console.Write($"Escriba {Text}: ");

            aux = Console.ReadLine();

            caracter = Convert.ToChar(aux);

            return caracter;
        }


        public static double CaptarNumDouble(string Text)
        {
            string aux = "";
            double num = 0;

            Console.Write($"Escriba {Text}: ");

            aux = Console.ReadLine();

            num = Convert.ToDouble(aux);

            return num;
        }

        public static int CaptarNumInt(string Text)
        {
            string aux = "";
            int num = 0;

            Console.Write($"Escriba {Text}: ");

            aux = Console.ReadLine();

            num = Convert.ToInt32(aux);

            return num;
        }

        public static Colores CaptarColores()
        {
            // Recursos

            Colores color;
            Colores opcion;

            opcion = (Colores)MetodosPrincipales.CaptarOpcion((byte)Enum.GetValues<Colores>().Length);

            switch (opcion)
            {
                case Colores.Azul:
                    break;
                case Colores.Rojo:
                    break;
                case Colores.Nego:
                    break;
                case Colores.Blanco:
                    break;
            }

        

        }



    }

}
