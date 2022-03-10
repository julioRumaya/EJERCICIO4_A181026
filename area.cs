using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRAC3A
{
    public class area
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float triangulo()
        {
            return Base * Altura / 2;
        }
        public float Lado1 { get; set; }
        public float Lado2 { get; set; }
        public float cuadrado()
        {
            return Lado1 * Lado2;
        }
        public double Radio { get; set; }
        public double pi = 3.1416;
        public double circulo()
        {
            return (Radio)*(Radio)*(pi);
        }
    }
}