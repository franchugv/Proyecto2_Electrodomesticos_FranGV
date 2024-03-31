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
            Colores color; 
            double carga;


            CaptarDatosLavadora(out marca, out modelo, out precio, out peso, out stock, out consumo, out color, out carga);




            ListaE.Add(new Lavadora(marca, modelo, precio, peso, stock, consumo, color, carga));




        }

        public static void AgregarTelevision(List<Electrodomestico> ListaE)
        {
            // RECURSOS
            string marca;
            string modelo;
            double precio;
            double peso;
            int stock;
            char consumo;
            Colores color;
            double carga;
            int resolucion = 0;
            bool tdt = true;

            CaptarDatosTV(out marca, out modelo, out precio, out peso, out stock, out consumo, out color, out resolucion, out tdt);

            ListaE.Add(new Television(marca, modelo, precio, peso, stock, consumo, color, resolucion, tdt));

        }

        public static void CaptarDatosLavadora(out string marca, out string modelo, out double precio, out double peso, out int stock, out char consumo, out Colores color, out double carga)
        {
            marca = MetodosPrincipales.CaptarCadena("la Marca");
            modelo = MetodosPrincipales.CaptarCadena("el Modelo");
            precio = MetodosPrincipales.CaptarNumDouble("el precio");
            peso = MetodosPrincipales.CaptarNumDouble("el peso");
            stock = MetodosPrincipales.CaptarNumInt("el stock");
            consumo = MetodosPrincipales.CaptarCaracter("el consumo");
            carga = MetodosPrincipales.CaptarNumDouble("la carga");
            color = MetodosPrincipales.CaptarColores();
        }

        public static void CaptarDatosTV(out string marca, out string modelo, out double precio, out double peso, out int stock, out char consumo, out Colores color, out int res, out bool tdt)
        {
            marca = MetodosPrincipales.CaptarCadena("la Marca");
            modelo = MetodosPrincipales.CaptarCadena("el Modelo");
            precio = MetodosPrincipales.CaptarNumDouble("el precio");
            peso = MetodosPrincipales.CaptarNumDouble("el peso");
            stock = MetodosPrincipales.CaptarNumInt("el stock");
            consumo = MetodosPrincipales.CaptarCaracter("el consumo (A-W)");
            color = MetodosPrincipales.CaptarColores();

            res = MetodosPrincipales.CaptarNumInt("la resolución");
            tdt = MetodosPrincipales.CaptarBool();

        }

    }
}