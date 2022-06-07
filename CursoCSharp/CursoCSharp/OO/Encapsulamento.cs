using System;
using Encapsulamento;


namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica); // public
            Console.WriteLine(CorDoOlho); // protected
            //Console.WriteLine(NumeroCelular); // internal
            Console.WriteLine(JeitoDeFalar); // protected internal
            //Console.WriteLine(SegredoFamilia); // private protected
            //Console.WriteLine(UsaMuitoPhotoshop); // private
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica); // public
            //Console.WriteLine(amiga.CorDoOlho); // protected
            //Console.WriteLine(amiga.NumeroCelular); // internal
            //Console.WriteLine(amiga.JeitoDeFalar); // protected internal
            //Console.WriteLine(amiga.SegredoFamilia); // private protected
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); // private
        }
    }

    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
