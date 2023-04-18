using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Agregacao
{
    public class Run
    {

        /// <summary>
        /// A agregação em C# é um tipo de associação entre objetos onde um objeto "agrega" outros objetos em sua composição, mas esses objetos agregados também podem existir independentemente do objeto agregador.
        /// </summary>
        /// 
        public Aluno aluno;
        public Curso curso;


        /// <summary>
        /// Nesse exemplo, a classe Curso representa um curso de programação em C# e a classe Aluno representa um aluno que está matriculado nesse curso. A classe Aluno "agrega" a classe Curso, pois um aluno faz parte de um curso, mas esse curso também pode existir sem alunos matriculados nele. Note que a classe Aluno contém uma propriedade Curso que guarda uma referência para um objeto da classe Curso.Essa é a forma como a agregação é implementada em C#.
        /// </summary>
        public Run()
        {
            curso = new Curso("Programação em C#");
            aluno = new Aluno("João", curso);

        }

        public void Exibir()
        {
            Console.WriteLine($"o nome do aluno é {aluno.Nome} e do curso {curso.Nome}");
        }
    }
}
