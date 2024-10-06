using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public double result { get; set; }
        public int temporada { get; set; }
        public int Dias { get; set; }

        public Vehiculo(string Modelo1, double Precio1, int Temporada)
        {
            Modelo = Modelo1;
            Precio = Precio1;
            temporada = Temporada;
            Descuento descuento = new Descuento(Precio, temporada);

            result = descuento.PrecioDescuento;




        }

        internal class Descuento
        {
            public double PrecioDescuento { get; set; }
            public Descuento(double Precio2, int j)
            {
                switch (j)
                {
                    case 1:
                        PrecioDescuento = Precio2 * (1 - 0.15);
                        break;
                    case 2:
                        PrecioDescuento = Precio2 * (1 - 0.25);
                        break;
                    case 3:
                        PrecioDescuento = Precio2 * (1 - 0.50);
                        break;
                }
            }

        }
    }
}

