using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>(); // esse é o Queue com generics

            fila.Enqueue("Fulando");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // vê o primeiro da fila, mas não o tira
            Console.WriteLine(fila.Count); // dá o número de componentes da fila

            Console.WriteLine(fila.Dequeue()); // vê o primeiro e o tira da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // esse é o Queue sem generics. Precisa fazer import de Collections
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
