using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 15,2
            Console.WriteLine(valor.ToString("C")); // R$ 15,18 (Currency)
            Console.WriteLine(valor.ToString("P")); // 1.517,50% (Percentual)
            Console.WriteLine(valor.ToString("#.##")); // 15,18 

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); // Currency sem casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // coloca zeros à esquerda até que o número tenho 10 digitos
        }
    }
}
