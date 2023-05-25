using System;
using System.Drawing;

namespace Ejercicio_1._5.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(@"Elegí la unidad que querés convertir:
                              1. Kilómetros a millas.
                              2. Kilómetros a yardas.");
                int unidadAConvertir = int.Parse(Console.ReadLine());

                if (unidadAConvertir == 1 || unidadAConvertir == 2)
                {
                    Console.Write("Ahora ingresá el valor en km que querés convertir:");
                    int valor = int.Parse(Console.ReadLine());

                    if (valor>0 && valor<=int.MaxValue)
                    {
                        if (unidadAConvertir == 1)
                        {
                            double resultado = KilometrosMillas(valor);
                            Console.WriteLine($"El resultado es: {resultado} millas.");
                        }
                        else 
                        {
                            double resultado = KilometrosYardas(valor);
                            Console.WriteLine($"El resultado es: {resultado} yardas.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Los kilómetros ingresados no pueden ser negativos");
                    }
                }

                else
                {
                    Console.WriteLine("Error: tenés que ingresar  1 o 2");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Número mal ingresado");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Valor fuera del rango permitido");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static double KilometrosMillas(double valor)
        {
            return valor * (0.621371192);
        }

        private static double KilometrosYardas(double valor)
        {
            return valor * (1093.6133);
        }

        
    }
}