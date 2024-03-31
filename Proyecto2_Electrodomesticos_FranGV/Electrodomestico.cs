namespace Proyecto2_Electrodomesticos_FranGV
{
    public enum Colores : byte { Blanco, Negro, Rojo, Azul, Gris }

    public class Electrodomestico
    {

        // CONSTANTES

        // Valores por defecto
        private const Colores COLOR_DEF = Colores.Blanco;
        private const int STOCK_DEF = 0;
        private const char CONSUMO_DEF = 'F';
        private const double PRECIO_DEF = 100;
        private const double PESO_DEF = 5;

        // Otros

        private const int STOCK_MAX = 50;



        // MIEMBROS

        protected string _marca;
        protected string _modelo;
        protected double _precioBase;
        protected double _peso;
        protected int _stock;
        protected char _consumoEnergetico;
        protected Colores _color;

        // CONSTRUCTORES

        public Electrodomestico(string marca, string modelo) 
        { 
            Marca = marca;
            Modelo = modelo;
            _precioBase = PRECIO_DEF;
            _peso = PESO_DEF;
            _stock = STOCK_DEF;
            _consumoEnergetico = CONSUMO_DEF;
            _color = COLOR_DEF;
        }

        public Electrodomestico(string marca, string modelo ,double precio, double peso) :this(marca, modelo)
        {
            PrecioBase = precio;
            Peso = peso;    
        }

        public Electrodomestico(string marca, string modelo, double precio, double peso, int stock, char consumo, Colores color) :this(marca, modelo, precio, peso) 
        {
            Stock = stock;
            ConsumoEnergetico = consumo;
            Color = color;
        }

        // PROPIEDADES

        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = ValidarMarca(value);
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = ValidarModelo(value);
            }
        }

        public double PrecioBase
        {
            get
            {
                return _precioBase;
            }
            set
            {
                ValidarDouble(value);
                _precioBase = value;
            }
        }

        public double Peso
        {
            get
            {
                return _peso;
            }
            set
            {
                ValidarDouble(value);
                _peso = value;
            }
        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                ValidarStock(value);
                _stock = value;
            }
        }

        public char ConsumoEnergetico
        {
            get
            {
                return _consumoEnergetico;
            }
            set
            {
                _consumoEnergetico = ValidarCaracterConsumo(value);
            }
        }

        public Colores Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public double PrecioFinal
        {
            get
            {
                return precioFinal();
            }
        }

        // MÉTODOS



        // VALIDACIÓN

        private static string ValidarMarca(string cadena)
        {
            // Preparación de la cadena

            cadena = cadena.Trim();

            // Validación

            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaExpection();

            foreach (char caracter in cadena)
            {
                if (!char.IsLetter(caracter)) throw new FormatoIncorrectoException();
            }

            return cadena;
        }

        private static string ValidarModelo(string cadena)
        {
            // Preparación de la cadena

            cadena = cadena.Trim();

            // Validación

            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaExpection();

            foreach (char caracter in cadena)
            {
                if (!char.IsLetterOrDigit(caracter)) throw new FormatoIncorrectoException();
            }

            return cadena;
        }

        private static char ValidarCaracterConsumo(char caracter)
        {
            // PREPARACIÓN A MAYUSCULAS

            caracter = char.ToUpper(caracter);

            // VALIDACIÓN

            // Validar que solo sea letras
            if (!char.IsLetter(caracter)) throw new FormatoIncorrectoException();

            // Validar que no sea cadena vacía
            if (string.IsNullOrEmpty(caracter.ToString())) throw new CadenaVaciaExpection();

            // Devolver caracter mayusculas
            return caracter;
        }

        protected static void ValidarDouble(double numero)
        {
            // Validar que no sea negativo

            if (numero < 0) throw new MinimoException();
        }

        // Virtual
        protected virtual void ValidarStock(int stock)
        {
            if (stock < 0) throw new MinimoException();
            if (stock > STOCK_MAX) throw new MaximoException();
        }


        // FUNCIONES

        public void Comprar(int NumUnidades)
        {
            // Incremento del stock
            Stock += NumUnidades;
        }

        public void Vender(int NumUnidades)
        {
            // Decremento del stock

            Stock -= NumUnidades;
        }

        public override string ToString()
        {
            string cadena;

            cadena = $"Marca: {Marca}\n";
            cadena += $"Modelo: {Modelo}\n";
            cadena += $"Precio Base: {PrecioBase}\n";
            cadena += $"Peso: {Peso}\n";
            cadena += $"Stock: {Stock}\n";
            cadena += $"Consumo Energético: {ConsumoEnergetico}\n";
            cadena += $"Color: {Color}\n";









            return cadena;
        }

        protected virtual double precioFinal()
        {
            // CONSTANTES

            const char CONSUMO_LISTA1 = 'A';
            const char CONSUMO_LISTA2 = 'B';
            const char CONSUMO_LISTA3 = 'C';
            const char CONSUMO_LISTA4 = 'D';
            const char CONSUMO_LISTA5 = 'E';
            const char CONSUMO_LISTA6 = 'F';

            // RECURSOS

            double resultado = PrecioBase;

            // VALIDACIÓN

            if (ConsumoEnergetico == CONSUMO_LISTA1) resultado += 100;
            if (ConsumoEnergetico == CONSUMO_LISTA2) resultado += 80;
            if (ConsumoEnergetico == CONSUMO_LISTA3) resultado += 60;
            if (ConsumoEnergetico == CONSUMO_LISTA4) resultado += 50;
            if (ConsumoEnergetico == CONSUMO_LISTA5) resultado += 30;
            if (ConsumoEnergetico == CONSUMO_LISTA6) resultado += 10;


            if (Peso < 19) resultado += 10;
            if (Peso >= 20) resultado += 50;
            if (Peso >= 50) resultado += 80;
            if (Peso > 80) resultado += 100;



            return resultado;






        }

    }

    // EXCEPCIONES PERSONALIZADAS

    public class FormatoIncorrectoException : Exception
    {
        public FormatoIncorrectoException() : base("Formato incorrecto") { }
        public FormatoIncorrectoException(string mensaje) : base(mensaje) { }
    }

    public class CadenaVaciaExpection : Exception
    {
        public CadenaVaciaExpection() : base("Cadena vacía") { }
        public CadenaVaciaExpection(string mensaje) : base(mensaje) { }
    }

    public class MaximoException : Exception
    {
        public MaximoException() : base("Supera el maximo permitido") { }
        public MaximoException(string mensaje) : base(mensaje) { }
    }

    public class MinimoException : Exception
    {
        public MinimoException() : base("Es inferior al rango permitido") { }
        public MinimoException(string mensaje) : base(mensaje) { }
    }





}
