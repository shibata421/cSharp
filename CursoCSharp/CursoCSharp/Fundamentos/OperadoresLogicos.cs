using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            bool trabalhoTerca = false;
            bool trabalhoQuinta = true;
            if(trabalhoTerca && trabalhoQuinta) {
                Console.WriteLine("Compra TV grande");
            }
            if(trabalhoTerca || trabalhoQuinta) {
                Console.WriteLine("Compra sorvete");
            } 
            if (trabalhoTerca ^ trabalhoQuinta) {
                Console.WriteLine("Compra TV menor");
            } 
            if(!(trabalhoTerca || trabalhoQuinta)){
                Console.WriteLine("Mais saudável");
            }
        }
    }
}
