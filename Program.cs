using Ejercicios_de_busqueda_Unidad_2.Clases;
using System;

namespace Ejercicios_de_busqueda_Unidad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusquedaLineal busqueda = new BusquedaLineal();
            //lineal
            //busqueda.listaEnteros();
            //busqueda.BuscarCadena();
            //busqueda.NumeroPar();
            //busqueda.TodosNumerosPares();


            //binario
            BusquedaBinaria busque = new BusquedaBinaria();
            //busque.BuscarFormaBinario();
            //busque.BuscarCadenaBinaria();
            busque.BuscarPrimerParBini();
        }
    }
}