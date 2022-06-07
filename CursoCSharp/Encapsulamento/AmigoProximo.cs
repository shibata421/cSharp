using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class AmigoProximo {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica); // public
            //Console.WriteLine(amiga.CorDoOlho); // protected
            Console.WriteLine(amiga.NumeroCelular); // internal
            Console.WriteLine(amiga.JeitoDeFalar); // protected internal
            //Console.WriteLine(amiga.SegredoFamilia); // private protected
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); // private
        }
    }
}
