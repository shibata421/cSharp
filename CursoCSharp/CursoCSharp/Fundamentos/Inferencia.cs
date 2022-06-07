using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Leonardo"; // C# infere que nome é String nesse caso
            //nome = 123;
            Console.WriteLine(nome);

            //var idade; // se usar var, tem que atribuir valor na mesma linha
             var idade = 12;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);

        }
    }
}
