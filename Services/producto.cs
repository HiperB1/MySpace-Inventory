using System;
using System.Collections.Generic;
using System.Text;

namespace MySpace_Inventory.Services
{

    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Value { get; set; }
        public double Hours { get; set; }
        
        public Product(string name, int stock, int value, double hours)//Este es el constructor de la clase
        {

            if(value < 0)
            {
                throw new ArgumentException("value debe ser mayor a 0"); //Esto es un tipo de error que es generar un error de codigo nuevo personalizado asi como cuando declaramos mal una variable
            }
            if(stock < 0)
            {
                throw new ArgumentException("El stock debe ser mayor a 0");
            }
            if(hours <= 0)
            {
                throw new ArgumentException("Las horas deben ser mayores a 0");
            }

            Name = name;
            Stock = stock;
            Value = value;
            Hours = hours;


        }


    }

}
