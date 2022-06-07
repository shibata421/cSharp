﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {
            // fazer com que um tipo aceite null
            Nullable<int> num1 = null;
            int? num2 = null;
            //int num3 = null; // isto não é possível ser feito

            if (num1.HasValue) {
                Console.WriteLine("Valor de num: {0}", num1);
            } else {
                Console.WriteLine("A variável não possui valor");
            }

            int valor = num1 ?? 1000; // ?? cria um valor padrão
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}