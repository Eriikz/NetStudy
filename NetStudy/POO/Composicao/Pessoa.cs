using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Composicao
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e moro na rua {Endereco.Logradouro}, {Endereco.Numero}, no bairro {Endereco.Bairro}, na cidade de {Endereco.Cidade}, estado de {Endereco.Estado}.");
        }
    }
}
