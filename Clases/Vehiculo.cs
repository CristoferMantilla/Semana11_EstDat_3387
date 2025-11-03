using System;

namespace Clases
{
    public class Vehiculo
    {
        public int Placa;
        public string Modelo;
        public int Anio;
        public string Marca;

        public Vehiculo()
        {
            Random r = new Random();
            Placa = r.Next(100000, 999999);
        }

        public Vehiculo(string modelo, int anio, string marca)
        {
            Random r= new Random();
            Placa = r.Next(100000,999999);
            Modelo = modelo;
            Anio = anio;
            Marca = marca;
        }
        public override string ToString()
        {
            return $"Placa: {Placa} \nMarca: {Marca} \nModelo: {Modelo} \nAño: {Anio}";
        }
    }
}