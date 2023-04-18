using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Factory
{
    // Implementações concretas dos produtos
    public class ProdutoA : IProduto
    {
        public void ExibirInfo()
        {
            Console.WriteLine("Produto A");
        }
    }
}
