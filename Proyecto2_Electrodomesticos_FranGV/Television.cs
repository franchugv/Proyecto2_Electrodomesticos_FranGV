using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Electrodomesticos_FranGV
{
    public class Television : Electrodomestico
    {

        // CONSTANTES
        private const int RESOLUCION_DEF = 20;
        private const bool TDT_DEF = false;
        
        private const double STOCK_MAX = 100;
        private const int RES_MAX = 120; 


        // MIEMBROS

        private int _resolucion;
        private bool _tdt;

        // CONSTRUCTORES

        public Television(string marca, string modelo) : base(marca, modelo) 
        { 
            _resolucion = RESOLUCION_DEF;
            _tdt = TDT_DEF;
        }

        public Television(string marca, string modelo, double precio, double peso) : base(marca, modelo, precio, peso) 
        {
            _resolucion = RESOLUCION_DEF;
            _tdt = TDT_DEF;
        }

        public Television(string marca, string modelo, double precio, double peso, int stock, char consumo, Colores color, int res, bool tdt) : base(marca, modelo, precio, peso,
            stock, consumo, color)
        {
            Resolucion = res;
            TDT = tdt;
        }

        // PROPIEDADES

        public int Resolucion
        {
            get
            {
                return _resolucion;
            }
            set
            {
                ValidarPulgadas(value);
                _resolucion = value;    
            }
        }

        public bool TDT
        {
            get
            {
                return _tdt;
            }
            set
            {
                _tdt = value;
            }
        }

        // MÉTODOS

        protected override void ValidarStock(int stock)
        {
            if (Stock > STOCK_MAX) throw new MaximoException();
        }

        private void ValidarPulgadas(int pulgadas)
        {
            if(pulgadas > RES_MAX) throw new MaximoException();
        }

        public override string ToString()
        {
            return base.ToString() + $"Resolución: {Resolucion}\nTDT: {TDT}";
        }

        protected override double precioFinal()
        {
            // RECURSOS

            double resultado = 0;

            if (Resolucion > 40) resultado *= 1.30;
            if (TDT == true) resultado += 50;


            return base.precioFinal()+ resultado;
        }

    }
}
