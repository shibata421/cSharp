using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair (int a, int b) {
            return a - b;
        }

        public int Multiplicar (int a, int b) {
            return a * b;
        }

    }

    public class CalculadoraCadeia {
        int Memoria;

        public CalculadoraCadeia Somar (int a) {
            Memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar (int a) {
            Memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar () {
            Memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(Memoria);
            return this;
        }

        public int Resultado () {
            return Memoria;
        }

    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
