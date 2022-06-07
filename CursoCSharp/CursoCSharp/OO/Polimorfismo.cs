﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CursoCSharp.OO {
    public class Comida {
        private double peso;
        public double Peso { 
            get {
                return peso;
            }
            set {
                if(value < 0) {
                    peso = 0;
                } else {
                    peso = value;
                }
            } 
        }

        public Comida (double peso) {
            Peso = peso;
        }
    }
    public class Feijao : Comida {
        public Feijao(double peso) : base (peso) { }
    }

    public class Arroz : Comida {
        public Arroz(double peso) : base(peso) { }
    }

    public class Carne : Comida {
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa {
        public double Peso;

        //public void Comer (Feijao feijao) {
        //    Peso += feijao.Peso;
        //}
        //public void Comer (Arroz arroz) {
        //    Peso += arroz.Peso;
        //}
        //public void Comer (Carne carne) {
        //    Peso += carne.Peso;
        //}
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }
    class Polimorfismo {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao(0.3);

            Arroz ingrediente2 = new Arroz(0.25);

            Carne ingrediente3 = new Carne(0.3);

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}");
        }
    }
}