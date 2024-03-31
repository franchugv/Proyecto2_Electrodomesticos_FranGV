using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Agregar
{
    public static class MetodosAgregar
    {
        public static void AgregarLavadora(List<Electrodomestico> ListaE)
        {
            // RECURSOS

            string marca;
            string modelo;
            double precio;
            double peso;
            int stock;
            char consumo;
            Colores color = Colores.Blanco; 
            double carga;


            marca = MetodosPrincipales.CaptarCadena("la Marca");
            modelo = MetodosPrincipales.CaptarCadena("el Modelo");
            precio = MetodosPrincipales.CaptarNumDouble("el precio");
            peso = MetodosPrincipales.CaptarNumDouble("el peso");
            stock = MetodosPrincipales.CaptarNumInt("el stock");
            consumo = MetodosPrincipales.CaptarCaracter("el consumo");
            carga = MetodosPrincipales.CaptarNumDouble("la carga");



            ListaE.Add(new Lavadora(precio, peso, marca, modelo, stock, consumo, color, carga));




        }

        public static void AgregarTelevision(List<Electrodomestico> ListaE)
        {
            // RECURSOS

            string marca;
            string modelo;
            double precio;
            double peso;

            marca = MetodosPrincipales.CaptarCadena("la Marca");
            modelo = MetodosPrincipales.CaptarCadena("el Modelo");
            precio = MetodosPrincipales.CaptarNumDouble("el precio");
            peso = MetodosPrincipales.CaptarNumDouble("el peso");


            ListaE.Add(new Television(marca, modelo, precio, peso));

        }
    }
}