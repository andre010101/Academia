using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    internal class Temperatura
    {

        public double celsius = 0;

        public double getCelsius()
        {
            return (((celsius * 9 ) /5 ) + 32); //converte para fahrenheit
        }
        public void setCelsius(double fahrenheit)
        {
            Console.WriteLine("Fahrenhrit:" + fahrenheit);
            celsius = (((fahrenheit - 32) * 5) /9); //coverte para celsisus
            Console.WriteLine("Celsius" + celsius);
        }

    }
}
