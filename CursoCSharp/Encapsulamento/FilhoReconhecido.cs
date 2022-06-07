using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade{
        public new void MeusAcessos() {
            Console.WriteLine("FilhoReconhecido...");
            
            Console.WriteLine(InfoPublica); // public
            Console.WriteLine(CorDoOlho); // protected
            Console.WriteLine(NumeroCelular); // internal
            Console.WriteLine(JeitoDeFalar); // protected internal
            Console.WriteLine(SegredoFamilia); // private protected
            //Console.WriteLine(UsaMuitoPhotoshop); // private
        }
    }
}
