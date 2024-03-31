using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Principal
{
    #region Enum
    public enum MenuPrincipal : byte { Salir ,Agregar, Eliminar, Consultar, Modificar }

    public enum MenuElectrodomesticos : byte { Salir, Lavadora, Television  }

    public enum MenuBool : byte { Si, No }

    #endregion

    public static class MetodosPrincipales
    {


        public static void MostrarError(string mError)
        {
            Console.WriteLine($"ERROR: {mError}");
            Console.WriteLine("Pulse Enter para continuar");
            Console.ReadLine();
        }


        public static void MostrarNumLista(List <Electrodomestico> ListaE)
        {
            Console.WriteLine($"Nº de Electrodomésticos: ({ListaE.ToArray().Length})\n");
        }

        public static void Pausa()
        {
            Console.Write("\nPulse Enter para continuar...");
            Console.ReadLine();
            Console.Clear();    
        }


        #region Captar Datos

        public static byte CaptarOpcionEnum(byte NumElementos)
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

        public static string CaptarCadena(string Text)
        {
            string cadena = "";

            Console.Write($"\nEscriba {Text}: ");

            cadena = Console.ReadLine();

            return cadena;
        }

        public static char CaptarCaracter(string Text)
        {
            string aux = "";
            char caracter = '-';

            Console.Write($"\nEscriba {Text}: ");

            aux = Console.ReadLine();

            caracter = Convert.ToChar(aux);

            return caracter;
        }

        public static double CaptarNumDouble(string Text)
        {
            string aux = "";
            double num = 0;

            Console.Write($"\nEscriba {Text}: ");

            aux = Console.ReadLine();

            num = Convert.ToDouble(aux);

            return num;
        }

        public static int CaptarNumInt(string Text)
        {
            string aux = "";
            int num = 0;

            Console.Write($"\nEscriba {Text}: ");

            aux = Console.ReadLine();

            num = Convert.ToInt32(aux);

            return num;
        }

        public static Colores CaptarColores()
        {
            // Recursos

            Colores color = Colores.Blanco;
            Colores opcion;

            UIPrincipal.MenuColor();
            opcion = (Colores)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<Colores>().Length);

            switch (opcion)
            {
                case Colores.Blanco:
                    color = Colores.Blanco;
                    break;
                case Colores.Negro:
                    color = Colores.Negro;
                    break;
                case Colores.Azul:
                    color = Colores.Azul;
                    break;
                case Colores.Rojo:
                    color = Colores.Rojo;
                    break;
                case Colores.Gris:
                    color = Colores.Gris;
                    break;


            }

            // SALIDA

            return color;
        

        }

        public static bool CaptarBool()
        {
            // RECURSOS

            bool esCorrecto = true;
            MenuBool opcion = MenuBool.Si;

            UIPrincipal.MenuBool();

            // CAPTAR OPCION
            opcion = (MenuBool)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<MenuBool>().Length);

            switch (opcion)
            {
                case MenuBool.Si:
                    esCorrecto = true;
                    break;
                case MenuBool.No:
                    esCorrecto = false;
                    break;
            }

            return esCorrecto;

        }

        public static byte CaptarByteLista(List<Electrodomestico> ListaE)
        {
            // RECURSOS
            byte opcion = 0;
            string aux = "";

            // ENTRADA
            aux = Console.ReadLine();
            // Validar que no sea cadena vacía
            if (string.IsNullOrEmpty(aux)) throw new CadenaVaciaExpection();

            // CONVERSIÓN
            opcion = Convert.ToByte(aux);

            // Validar que no sea mayor que la lista

            if (opcion > ListaE.ToArray().Length) throw new MaximoException();

            // SALIDA
            return (byte)(opcion - 1);
        }


        #endregion


    }

}
