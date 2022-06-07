using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            // cria uma variável com tipagem fraca e dinâmica
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            // cria um objeto que pode acrescentar atributos dinamicamente como em JS
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine(aluno.nome);
            Console.WriteLine(aluno.nota);
            Console.WriteLine(aluno.idade);
        }
    }
}
