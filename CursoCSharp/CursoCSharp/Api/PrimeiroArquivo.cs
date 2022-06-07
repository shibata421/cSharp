using System;
using System.IO;

namespace CursoCSharp.Api {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            // o @ faz com que o c# interprete a string de forma literal, sem interpretar \t ou \n por exemplo
            // ~ significa a pasta home, a pasta que o usuário está logado no sistema
            
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    // o using aqui abre o que é necessário acessar do SO para executar este bloco e o fechará depois da execução
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
