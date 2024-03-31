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

            Console.WriteLine("\n¿Desea Modificar la Marca?\n");
            esCorrecto = MetodosPrincipales.CaptarBool();

            if (esCorrecto)
            {
                ListaE[opciones].Marca = MetodosPrincipales.CaptarCadena("Escriba la nueva Marca: ");
            }
            if (esCorrecto)
            {
                ListaE[opciones].Modelo = MetodosPrincipales.CaptarCadena("Escriba el nuevo Modelo: ");
            }
            if (esCorrecto)
            {
                ListaE[opciones].PrecioBase = MetodosPrincipales.CaptarNumDouble("Escriba el nuevo Precio: ");
            }
            if (esCorrecto)
            {
                ListaE[opciones].Peso = MetodosPrincipales.CaptarNumDouble("Escriba el nuevo Peso: ");
            }
            if (esCorrecto)
            {
                ListaE[opciones].Comprar(MetodosPrincipales.CaptarNumInt("Incrementar el Stock: "));
            }
            if (esCorrecto)
            {
                ListaE[opciones].Vender(MetodosPrincipales.CaptarNumInt("Decrementar el Stock: "));
            }
            if (esCorrecto)
            {
                ListaE[opciones].Color = MetodosPrincipales.CaptarColores();
            }


        }
    }
}
