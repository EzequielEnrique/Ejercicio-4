using System;

namespace Ejercicio_4_del_tp
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta, paga;
            respuesta = "si";
            paga = "contado";
            paga = "cuentacorriente";
            double precio, calculo, total, acu, acumulador, acumulador2, acu2, monto, totaltotal;
            int c, c2, c3;
            c = 0;
            c2 = 0;
            c3 = 0;
            acu = 0;
            acu2 = 0;
            acumulador = 0;
            acumulador2 = 0;


            Console.WriteLine("¿Quiere realizar una operación?");
            respuesta = string.Format(Console.ReadLine());
            while(respuesta == "si")
            {
                c = c + 1;
                Console.WriteLine("Ingresar el valor de la venta");
                precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Lo paga a: contado o cuentacorriente");
                paga = string.Format(Console.ReadLine());
                if(paga == "contado")
                {
                    c2 = c2 + 1;
                    calculo = (precio * 5)/100;
                    total = precio - calculo;
                    acumulador = acumulador + total;
                    acu = acu + calculo;
                    Console.WriteLine("¿Quiere repetir la operación?");
                    respuesta = Console.ReadLine();
                }
                if(paga == "cuentacorriente")
                {
                    c3 = c3 + 1;
                    calculo = (precio * 15)/100;
                    total = precio + calculo;
                    acumulador2 = acumulador2 + total;
                    acu2 = acu2 + calculo;
                    Console.WriteLine("¿Quiere repetir la operación?");
                    respuesta = Console.ReadLine();
                }
            }
            totaltotal = acumulador + acumulador2;
            if(totaltotal > 3000)
            {
                calculo = (totaltotal * 2)/100;
                monto = totaltotal - calculo;
                Console.WriteLine("El total de veces que se repitió la operación:"+ c);
                Console.WriteLine("El total de ventas al Contado:"+ c2);
                Console.WriteLine("El total de ventas en Cuenta Corriente:"+ c3);
                Console.WriteLine("El total por recargo:"+ acu2);
                Console.WriteLine("El total por descuento:"+ acu);
                Console.WriteLine("El total de las ventas es:"+ monto);
            }else
            {
                Console.WriteLine("El total de veces que se repitió la operación:"+ c);
                Console.WriteLine("El total de ventas al Contado:"+ c2);
                Console.WriteLine("El total de ventas en Cuenta Corriente:"+ c3);
                Console.WriteLine("El total por recargo:"+ acu2);
                Console.WriteLine("El total por descuento:"+ acu);
                Console.WriteLine("El total de las ventas es:"+ totaltotal);
            }
        }   
    }
}
