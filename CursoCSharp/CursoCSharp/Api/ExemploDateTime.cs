using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            var hoje = DateTime.Today; // trás a data sem as horas
            Console.WriteLine(hoje);

            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine(diaAtual.Hour);
            Console.WriteLine(diaAtual.Minute);
            Console.WriteLine(diaAtual.Second);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);
            
            Console.WriteLine(diaAtual.ToString("dd")); // apenas o dia
            Console.WriteLine(diaAtual.ToString("d")); // dia/mes/ano
            Console.WriteLine(diaAtual.ToString("D")); // data completa
            Console.WriteLine(diaAtual.ToString("g")); // data + hora + minuto
            Console.WriteLine(diaAtual.ToString("G")); // data + hora + segundo
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
