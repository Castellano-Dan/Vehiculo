
using System;
using Vehiculos;

public class Program
{
    static void Main(string[] args)
    {
        double price;
        string modelo;
        string temporada;
        int dias;
        int i;



        Console.WriteLine("Digite el precio del vehiculo");
        price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite el modelo:");
        modelo = Console.ReadLine();

        Console.WriteLine("Digite cuántos días reservará el vehiculo:");
        dias = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-Digite la temporada: \n 1.-Invierno \n 2.-Verano \n 3.-Otoño");
        i = Convert.ToInt32(Console.ReadLine());

        Vehiculos.Vehiculo vehiculo = new Vehiculos.Vehiculo(modelo, price, i);

    }
}