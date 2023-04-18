using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Agregacao
{
    // Definição da classe "Aluno"
    public class Aluno
    {
        public string Nome { get; set; }
        public Curso Curso { get; set; }

        public Aluno(string nome, Curso curso)
        {
            Nome = nome;
            Curso = curso;
        }
    }
}
