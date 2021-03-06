﻿using System;
using System.Globalization;

namespace ExPropostos006
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. EM seguida, calcule e mostre: 

            // A) a área do triangulo retângulo que tem A por base e C altura. 
            // B) a área do círculo de raio C. (pi = 3.14159)
            // C) a área do trapézio que tem A e B por bases e C por altura.
            // D) a área do quadrado que tem lado B.
            // E) a área do retângulo que tem lados A e B

            double PI = 3.14159;

            string[] vet = Console.ReadLine().Split(" ");

            double a = double.Parse(vet[0]);

            double b = double.Parse(vet[1]);

            double c = double.Parse(vet[2]);


            // Respostas 

            // A) 
            // Fórmula A = (b . h) / 2

            double TrianguloRetangulo = (a * c) / 2;

            Console.WriteLine("Triangulo: {0}", TrianguloRetangulo.ToString("F4", CultureInfo.InvariantCulture));

            // B) 
            // Fórmula A = π . r2

            double Circulo = (PI * (Math.Pow(c, 2)));

            Console.WriteLine("Circulo: {0}", Circulo.ToString("F4", CultureInfo.InvariantCulture));

            // C)
            // Fórmula A = ((B + b). h) / 2

            double Trapezio = ((a + b) * c) / 2;

            Console.WriteLine("Trapezio: {0}", Trapezio.ToString("F4", CultureInfo.InvariantCulture));

            // D)
            // Fórmula A = L.L

            double quadrado = Math.Pow(b, 2);

            Console.WriteLine("Quadrado: {0}", quadrado.ToString("F4", CultureInfo.InvariantCulture));

            // E) 
            // Fórmula A = b . h

            double retangulo = a * b;

            Console.WriteLine("Retangulo: {0}", retangulo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
