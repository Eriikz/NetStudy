using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.C.Tuplas
{
    public class Tuplas
    {
        /// <summary>
        /// As tuplas em C# são uma estrutura de dados que permite agrupar múltiplos valores de tipos diferentes em um único objeto. As tuplas são usadas para representar coleções de valores heterogêneos em uma única unidade, sem a necessidade de criar uma classe personalizada ou usar uma estrutura de dados mais complexa.
        /// </summary>
        public void Exibir()
        {
            // Exemplo de tupla representando um par (nome, idade)
            var pessoa1 = Tuple.Create("João", 30);
            Console.WriteLine($"Nome: {pessoa1.Item1}, Idade: {pessoa1.Item2}");

            // Exemplo de tupla representando um trio (nome, idade, cidade)
            var pessoa2 = Tuple.Create("Maria", 25, "São Paulo");
            Console.WriteLine($"Nome: {pessoa2.Item1}, Idade: {pessoa2.Item2}, Cidade: {pessoa2.Item3}");

            // Exemplo de tupla com tipos específicos
            Tuple<string, int> pessoa3 = new Tuple<string, int>("Pedro", 35);
            Console.WriteLine($"Nome: {pessoa3.Item1}, Idade: {pessoa3.Item2}");

            // Exemplo de desestruturação de tupla
            var pessoa4 = Tuple.Create("Ana", 28);
            var (nome, idade) = pessoa4;
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }

    }
}
