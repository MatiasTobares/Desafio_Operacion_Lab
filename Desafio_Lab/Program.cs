using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Lab
{
    class OPERACION
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0;
            int r = 0;

            //Se cargan los dos valores
            Console.WriteLine("¡Ingrese los valores!");
            Console.WriteLine("Primer valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());


            //Se hace llamado de los Métodos estáticos de la clase Calculos.cs
            r = Calculos.suma(valor1, valor2);
            Console.WriteLine("La suma es {0}", r);

            r = Calculos.resta(valor1, valor2);
            Console.WriteLine("La resta es {0}", r);

            Console.ReadKey();
        }
    }
}

/*
-----Grupo N° 8-----
Matias Tobares N° 113001
Maximiliano Sosa N°113079

DESAFÍO: todos los grupo de acción deberán implementar una clase llamada "Operación" y definir dos métodos estáticos que permitan sumar y restar dos valores enteros
(ingresados por teclado).*/
