using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecaoStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // tira o primeiro da pilha e o retira do grupo

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // mostra o primeiro, mas não o tira do grupo
            Console.WriteLine(pilha.Count);
        }
    }
}
