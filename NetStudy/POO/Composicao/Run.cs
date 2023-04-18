using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Composicao
{
    public class Run
    {

        /// <summary>
        /// A composição em C# é um recurso que permite criar uma classe composta por outras classes, de modo que a classe composta possa ter acesso aos membros das classes que a compõem. Isso permite a criação de classes mais complexas e modulares.
        /// </summary>

        public Endereco endereco; // Declaração da variável de instância
        public Pessoa pessoa;

        public Run()
        {
            endereco = new Endereco("Rua das marmotas", "123", "Bairro do pipa quadrado", "Cidade do carro", "Estado de pernambuco");
            pessoa = new Pessoa("Erich", 19, endereco);
            // Inicialização da variável no construtor
        }

        public void Exibir()
        {
            Console.WriteLine($"A pessoa é {pessoa.Nome} com {pessoa.Idade} e O endereço é {endereco.Logradouro}, {endereco.Numero}, {endereco.Bairro}, {endereco.Cidade} - {endereco.Estado}.");
        }

    }
}


