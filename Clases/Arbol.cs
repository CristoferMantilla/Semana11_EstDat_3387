using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public Nodo raiz_principal = null;

        private void insertar(ref Nodo raiz, Vehiculo d)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = d;

                raiz = nuevo;
                Console.WriteLine($"Vehiculo con placa nr {d.Placa} registrado correctamente!");
            } else
            {
                if (d.Placa < raiz.dato.Placa)
                {
                    insertar(ref raiz.izq, d);
                }
                else if (d.Placa > raiz.dato.Placa)
                {
                    insertar(ref raiz.der, d);
                } else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }
        public void Insertar(Vehiculo d)
        {
            insertar(ref raiz_principal, d);
        }

        private void dibujar(Nodo raiz, int nivel)
        {
            //D-R-I
            if (raiz!=null)
            {
                dibujar(raiz.der, nivel + 1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(raiz.dato);
                dibujar(raiz.izq, nivel + 1);
            }
        }
        public void Dibujar()
        {
            dibujar(raiz_principal,0);
        }
        private void inOrden(Nodo raiz)
        {
            if (raiz!=null)
            {
                inOrden(raiz.izq);
                Console.WriteLine(raiz.dato);
                Console.WriteLine("----------------------------------");
                inOrden(raiz.der);
            }
        }
        public void InOrden()
        {
            inOrden(raiz_principal);
        }

        private void buscar(Nodo raiz, int placa)
        {
            if (raiz == null)
            {
                Console.WriteLine("Vehiculo no existe en los registros");
            }
            else
            {
                if (placa < raiz.dato.Placa)
                {
                    buscar(raiz.izq, placa);
                }
                else if (placa > raiz.dato.Placa)
                {
                    buscar(raiz.der, placa);
                }
                else
                {
                    Console.WriteLine("Vehiculo encontrado");
                    Console.WriteLine(raiz.dato);
                }
            }
        }
        public void Buscar(int d)
        {
            buscar(raiz_principal, d);
        }
        private void eliminar(ref Nodo raiz, int placa)
        {
            if (raiz == null)
            {
                Console.WriteLine("Vehiculo no existe en los registros");
            }
            else
            {
                if (placa < raiz.dato.Placa)
                {
                    eliminar(ref raiz.izq, placa);
                }
                else if (placa > raiz.dato.Placa)
                {
                    eliminar(ref raiz.der, placa);
                }
                else
                {
                    if (raiz.izq==null && raiz.der==null)
                    {
                        raiz = null;
                    } else
                    {
                        //des. izq
                        if (raiz.izq!=null)
                        {
                            Nodo temp = BuscarMayor(raiz.izq);

                            Vehiculo aux = temp.dato;
                            temp.dato = raiz.dato;
                            raiz.dato = aux;

                            eliminar(ref raiz.izq, placa);
                        }
                        else
                        {
                            //des. der
                            Nodo temp = BuscarMenor(raiz.der);

                            Vehiculo aux = temp.dato;
                            temp.dato = raiz.dato;
                            raiz.dato = aux;

                            eliminar(ref raiz.der, placa);
                        }
                    }
                }
            }
        }
        public void Eliminar(int d)
        {
            eliminar(ref raiz_principal, d);
        }
        private Nodo BuscarMenor(Nodo raiz)
        {
            if(raiz.izq!=null) {

                return BuscarMenor(raiz.izq);
            } else
            {
                return raiz;
            }
        }
        private Nodo BuscarMayor(Nodo raiz)
        {
            if (raiz.der != null)
            {

                return BuscarMayor(raiz.der);
            }
            else
            {
                return raiz;
            }
        }
    }
}
