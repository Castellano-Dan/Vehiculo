using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{

    public static class Reserva
    {

        public static double total { get; set; }


        public static double totalReserva(Vehiculo vehiculo, int dia)
        {

            total = Convert.ToDouble(vehiculo.result * dia);
            return total;
        }


    }
}
