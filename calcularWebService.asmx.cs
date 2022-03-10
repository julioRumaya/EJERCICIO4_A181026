using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PRAC3A
{
    /// <summary>
    /// Descripción breve de calcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class calcularWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public float triagulo(float Base, float Altura)
        {
            return Base * Altura / 2;
        }
        [WebMethod]
        public float cuadrado(float Lado1, float Lado2)
        {
            return Lado1 * Lado2;
        }
        [WebMethod]
        public double Circulo(double Radio,double pi = 3.1416)
        {
            return (Radio) * (Radio) * (pi);
        }
    }
}
