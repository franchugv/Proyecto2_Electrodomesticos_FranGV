using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Consultar
{
    public static class ControladorConsultar
    {
        public static void ControladorConsultas(List<Electrodomestico> ListaE)
        {
            // RECURSOS
            byte opcion;



            // Controlador

            UIConsultar.MenuConsultar(ListaE);
            opcion = MetodosPrincipales.CaptarByteLista(ListaE);
            MetodosConsultar.MostrarDatos(opcion ,ListaE);
            MetodosPrincipales.Pausa();


        }
    }
}
