using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public static class Extension
    {
        public static void MostrarInfo(Vehiculo vehiculo, int dias)
        {

            Console.WriteLine($"Modelo: {vehiculo.Modelo}");
            Console.WriteLine($"Precio: {vehiculo.Precio}");
            Console.WriteLine($"Precio con descuento: {vehiculo.result}");
            Console.WriteLine($"Precio de Reserva: {Reserva.totalReserva(vehiculo, dias)}");
        }
    }
}
