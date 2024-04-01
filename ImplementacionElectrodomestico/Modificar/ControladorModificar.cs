using ImplementacionElectrodomestico.Principal;
using Proyecto2_Electrodomesticos_FranGV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionElectrodomestico.Modificar
{
    public static class ControladorModificar
    {
        public static void ControladorModificarElectrodomestico(List<Electrodomestico> ListaE)
        {
            // RECURSOS
            Propiedades opcion = Propiedades.Marca;
            byte NumElecrodomestico = 0;
            bool esCorrecto;
            string MensajeError = "";


            // CONTROLLER

            do
            {
                UIModificar.MenuModificar(ListaE);

                opcion = (Propiedades)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<Propiedades>().Length);


                if (opcion != Propiedades.Salir) 
                { 
                UIModificar.MenuModificarOpcion();
                NumElecrodomestico = MetodosPrincipales.CaptarByteLista(ListaE);
                }

                esCorrecto = true; // Reset

                try { 

                switch (opcion)
                {
                    case Propiedades.Salir:
                        break;
                    case Propiedades.Marca:
                        ListaE[NumElecrodomestico].Marca = MetodosPrincipales.CaptarCadena("la nueva Marca");
                        break;
                    case Propiedades.Modelo:
                        ListaE[NumElecrodomestico].Modelo = MetodosPrincipales.CaptarCadena("el nuevo Modelo");
                        break;
                    case Propiedades.Precio:
                        ListaE[NumElecrodomestico].PrecioBase = MetodosPrincipales.CaptarNumDouble("el nuevo Precio");
                        break;
                    case Propiedades.Color:
                        ListaE[NumElecrodomestico].Color = MetodosPrincipales.CaptarColores();
                        break;
                    case Propiedades.Consumo:
                        ListaE[NumElecrodomestico].ConsumoEnergetico = MetodosPrincipales.CaptarCaracter("el Consumo Energético");
                        break;
                    case Propiedades.Peso:
                        ListaE[NumElecrodomestico].Peso = MetodosPrincipales.CaptarNumDouble("el nuevo Peso");
                        break;
                    case Propiedades.IcrementoStock:
                        ListaE[NumElecrodomestico].Comprar(MetodosPrincipales.CaptarNumInt("el Incremento del Stock"));
                        break;
                    case Propiedades.DecrementoStock:
                        ListaE[NumElecrodomestico].Vender(MetodosPrincipales.CaptarNumInt("el Decremento del Stock: "));
                        break;
                    case Propiedades.Carga: 
                        if (ListaE is Lavadora)
                        {
                            Lavadora LavadoraX = (Lavadora)ListaE[NumElecrodomestico];
                            LavadoraX.Carga = MetodosPrincipales.CaptarNumDouble("la Caga");
                        }
                        break;
                    case Propiedades.Resolucion:
                        if (ListaE is Television)
                        {
                            Television TelevisionX = (Television)ListaE[NumElecrodomestico];
                            TelevisionX.Resolucion = MetodosPrincipales.CaptarNumInt("la Resolución");
                        }
                        break;
                    case Propiedades.TDT:
                        if (ListaE is Television)
                        {
                            Television TelevisionX = (Television)ListaE[NumElecrodomestico];
                            TelevisionX.TDT = MetodosPrincipales.CaptarBool();
                        }
                        break;
                }
                    }

                catch(Exception Error)
                {
                    esCorrecto = false;
                    MensajeError = Error.Message;
                }
                finally
                {
                    if (!esCorrecto) MetodosPrincipales.MostrarError(MensajeError);
                }

            } while (opcion != Propiedades.Salir || !esCorrecto);





        }
    }
}
