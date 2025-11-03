using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol ab= new Arbol();

            ab.Insertar(new Vehiculo("Yaris",2023,"Toyota"));
            Console.ReadKey();
            ab.Insertar(new Vehiculo("Elantra", 2016, "Hyundai"));
            Console.ReadKey();
            ab.Insertar(new Vehiculo("Mazda 3", 2020, "Mazda"));
            Console.ReadKey();
            ab.Insertar(new Vehiculo("Lancer", 2000, "Mitsubishi"));

            //ab.InOrden();
            Console.Write("Ingrese una placa a buscar: ");
            int placa=int.Parse(Console.ReadLine());
            ab.Buscar(placa);
        }
    }
}
