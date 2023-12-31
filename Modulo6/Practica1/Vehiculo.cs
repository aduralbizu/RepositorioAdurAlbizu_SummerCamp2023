﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Vehiculo
    {

        public DateTime AñoCompra { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
    

        public Vehiculo(DateTime añocompra, string marca, string modelo,string color) {
            AñoCompra = añocompra;
            Marca = marca;
            Modelo = modelo;
            Color = color;
        } //Constructor

        public Vehiculo(DateTime añocompra, string color)
        {
            AñoCompra = añocompra;
            Color = color;
        }
        public Vehiculo( string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public void imprimirCoche()
        {
            if (AñoCompra!= new DateTime(0001,01,01)) Console.WriteLine("Año de compra: " + AñoCompra);
            if (Marca!=null) Console.WriteLine("Marca: " + Marca);
            if (Modelo!=null) Console.WriteLine("Modelo: " + Modelo);
            if (Color!=null) Console.WriteLine("Color: " + Color);
            Console.WriteLine();
        }


    }
}
