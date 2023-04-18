using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Factory
{
    public class Run
    {
        public void Exibir()
        {
            FabricaDeProdutos fabrica = new FabricaDeProdutos();

            // Criar produto A
            IProduto produtoA = fabrica.CriarProduto("A");
            produtoA.ExibirInfo(); // Saída: Produto A

            // Criar produto B
            IProduto produtoB = fabrica.CriarProduto("B");
            produtoB.ExibirInfo(); // Saída: Produto B
        }

    }
}
