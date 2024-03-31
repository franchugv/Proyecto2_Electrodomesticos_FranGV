using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Modificar
{
    public static class MetodosModificar
    {
        public static void ModificarDatos(List<Electrodomestico> ListaE, byte opciones)
        {
            // RECURSOS
            bool esCorrecto;

            esCorrecto = Eleccion("¿Desea Modificar la Marca?");
            if (esCorrecto)
            {
                ListaE[opciones].Marca = MetodosPrincipales.CaptarCadena("la nueva Marca");
            }

            esCorrecto = Eleccion("¿Desea Modificar el Modelo?");
            if (esCorrecto)
            {
                ListaE[opciones].Modelo = MetodosPrincipales.CaptarCadena("el nuevo Modelo");
            }

            esCorrecto = Eleccion("¿Desea Modificar el Precio?");
            if (esCorrecto)
            {
                ListaE[opciones].PrecioBase = MetodosPrincipales.CaptarNumDouble("el nuevo Precio");
            }

            esCorrecto = Eleccion("¿Desea Modificar el peso?");
            if (esCorrecto)
            {
                ListaE[opciones].Peso = MetodosPrincipales.CaptarNumDouble("el nuevo Peso");
            }

            esCorrecto = Eleccion("¿Desea incrementar el Stock?");
            if (esCorrecto)
            {
                ListaE[opciones].Comprar(MetodosPrincipales.CaptarNumInt("el Incremento del Stock"));
            }

            esCorrecto = Eleccion("¿Desea decrementar el Stock?");
            if (esCorrecto)
            {
                ListaE[opciones].Vender(MetodosPrincipales.CaptarNumInt("el Decremento del Stock: "));
            }

            esCorrecto = Eleccion("¿Desea Modificar el Color?");
            if (esCorrecto)
            {
                ListaE[opciones].Color = MetodosPrincipales.CaptarColores();
            }


        }

        private static bool Eleccion(string text)
        {
            bool esCorrecto;
            Console.Clear();
            Console.WriteLine($"\n{text}\n");
            esCorrecto = MetodosPrincipales.CaptarBool();
            return esCorrecto;
        }
    }
}
