using NetStudy.POO.Herança;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetStudy.POO.Herança
{
    public static class Run
    {
        /// <summary>
        /// A herança em C# é um recurso que permite criar uma nova classe com base em uma classe existente, herdando todos os membros e métodos da classe base. Isso ajuda a evitar a duplicação de código e a criar hierarquias de classes mais organizadas.
        /// </summary>
        public static void Heranca()
        {
            Carro fusca = new Carro();
            fusca.modelo = "FS 1300"; 
            fusca.Categoria = "carro";
            fusca.cor = "Preto";

            fusca.Capacidade = "5 pessoas";
            fusca.Categoria = "terrestre";

            string jsonString = JsonSerializer.Serialize(fusca);

            Console.WriteLine(jsonString);
        }
    }
}
