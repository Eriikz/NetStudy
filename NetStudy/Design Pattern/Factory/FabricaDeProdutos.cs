using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Factory
{

    /// <summary>
    /// Sim, a interface IProduto pode receber uma instância da classe ProdutoA em C#. A interface IProduto define um contrato que as classes ProdutoA, ProdutoB ou qualquer outra classe que implemente essa interface deve seguir.Portanto, uma instância da classe ProdutoA pode ser atribuída a uma variável do tipo IProduto, já que ProdutoA implementa a interface IProduto.
    /// </summary>


    // Classe Factory responsável por criar objetos de produtos
    public class FabricaDeProdutos
    {
        public IProduto CriarProduto(string tipo)
        {
            IProduto produto;
            // Lógica de criação de objetos baseada no parâmetro "tipo"
            if (tipo == "A")
            {
                produto = new ProdutoA();
            }
            else if (tipo == "B")
            {
                produto = new ProdutoB();
            }
            else
            {
                throw new ArgumentException("Tipo de produto inválido");
            }

            return produto;
        }
    }
}
