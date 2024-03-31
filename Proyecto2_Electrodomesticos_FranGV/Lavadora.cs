using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Electrodomesticos_FranGV
{
    public class Lavadora : Electrodomestico
    {

        // CONSTANTES
        private const int MAX_STOCK = 20;
        private const int CARGA_DEF = 5;



        // MIEMBROS
        private double _carga;

        // CONSTRUCTORES

        public Lavadora(string marca, string modelo) : base(marca, modelo) 
        { 
            _carga = CARGA_DEF;
        }

        public Lavadora(string marca, string modelo, double precio, double peso) : base(marca, modelo, precio, peso) 
        {
            _carga = CARGA_DEF;
        }

        public Lavadora(string marca, string modelo, double precio, double peso, int stock, char consumo, Colores color, double carga) : base(marca, modelo, precio, peso,
            stock, consumo, color)
        {
            Carga = carga;
        }


        // PROPIEDADES
        public double Carga
        {
            get
            {
                return _carga;
            }
            set
            {
                ValidarCarga(value);
                ValidarDouble(value);
                _carga = value;
            }
        }

        // MÉTODOS
        private void ValidarCarga(double carga)
        {
            if (carga < 0) throw new MinimoException();
            if (carga > 45) throw new MaximoException();
        }

        protected override void ValidarStock(int stock)
        {
            if (stock < 0) throw new MinimoException();
            if (stock > MAX_STOCK) throw new MaximoException();
        }


        public override string ToString()
        {
            return base.ToString() + $"Carga: {Carga}";
        }

        protected override double precioFinal()
        {
            // RECURSOS

            double precio = 0;

            // VALIDACIÓN

            if (Carga > 30) precio += 50;
            

            return precio + base.precioFinal();
        }

    }
}
