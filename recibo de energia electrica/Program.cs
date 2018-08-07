/* Nombre del Autor: Mauricio Mejia Estevez
 Fecha: 05 de Octubre de 2017
 Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recibo_de_energia_electrica
{
    class Recibo //Clase Recibo
    {
        static void Main(string[] args)  //Método principal Main, se llama  a los métodos creados en el orden correcto.
        {
            Recibo recibo = new Recibo();       //Declaración y creación del objeto
            recibo.Inicializador();             //Llamada al método Inicializador
            recibo.Calculos();                  //Llamada al método Calculos
            recibo.Imprimir();                  //Llamada al método Imprimir

        }
        //Propiedades o atributos
        private decimal consumoAnterior;
        private decimal consumoActual;
        private decimal consumoTotal;
        private decimal subtotal;
        private decimal descuento;
        private decimal valorPagar;
        private int estrato;

        public void Inicializador() //Método Inicializador, para cargar los datos consumo anterior, consumo actual y estrato
        {

            Console.WriteLine("***     Calculador de valores recibos de energía eléctrica    ***\n");
            Console.Write("Consumo de la lectura anterior : ");
            consumoAnterior = decimal.Parse(Console.ReadLine());
            Console.Write("Consumo de la lectura actual : ");
            consumoActual = decimal.Parse(Console.ReadLine());
            do
            {
                Console.Write("Ingrese el estrato [1 = Bajo, 2 = Medio, 3= Alto] : ");
                estrato = int.Parse(Console.ReadLine());
            } while (estrato < 1 || estrato > 3);


        }

        private void Calculos() //Método Calculos, realiza las operaciones correspondientes
        {
            byte kw = 110;

            consumoTotal = (consumoActual - consumoAnterior);

            if (estrato == 1)
            {
                subtotal = consumoTotal * kw;
                descuento = (subtotal * 10) / 100;
                valorPagar = subtotal - descuento;
            }
            if (estrato == 2)
            {
                subtotal = consumoTotal * kw;
                descuento = (subtotal * 6) / 100;
                valorPagar = subtotal - descuento;
            }
            if (estrato == 3)
            {
                subtotal = consumoTotal * kw;
                descuento = (subtotal * 5) / 100;
                valorPagar = subtotal - descuento;
            }

        }

        public void Imprimir() //Método imprimir, para mostrar en pantalla los resultados
        {
            Console.WriteLine("\n***   Resultados   ***");
            Console.WriteLine("\nEl consumo de la lectura anterior fue " + consumoAnterior + " kW");
            Console.WriteLine("El consumo de la lectura actual es " + consumoActual + " kW");
            Console.WriteLine("El consumo total fue " + consumoTotal + " kW");
            Console.WriteLine("El valor subtotal es  $ " + subtotal);
            Console.WriteLine("El descuento aplicar es $ " + descuento);
            Console.WriteLine("El valor total a pagar es $ " + valorPagar);
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();

        }

    }

}
