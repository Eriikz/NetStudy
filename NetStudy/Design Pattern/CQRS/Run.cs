using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.CQRS
{
    public class Run
    {

        public void Exibir()
        {
            var itemService = new ItemService();

            // Exemplo de criação de um novo item
            var criarItemCommand = new CriarItemCommand
            {
                Nome = "Item1",
                Preco = 9.99m
            };
            itemService.CriarItem(criarItemCommand);

            // Exemplo de atualização de um item existente
            var atualizarItemCommand = new AtualizarItemCommand
            {
                Id = 1,
                Nome = "Item2",
                Preco = 19.99m
            };
            itemService.AtualizarItem(atualizarItemCommand);

            // Exemplo de exclusão de um item existente
            var excluirItemCommand = new ExcluirItemCommand
            {
                Id = 1
            };
            itemService.ExcluirItem(excluirItemCommand);

            // Exemplo de consulta de itens
            var consultarItensQuery = new ConsultarItensQuery
            {
                // Configurar filtros e outros

            };
            itemService.ConsultarItens(consultarItensQuery);
        }
    }
}