using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // false. Compara referências de memória
            Console.WriteLine(p3 == p2); // true
            
            Console.WriteLine(p1.Equals(p2)); // só se torna verdadeiro após a a sobreescrita do método Equals

        }
    }
}
