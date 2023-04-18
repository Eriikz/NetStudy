using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.Factory
{
    public class ProdutoB : IProduto
    {
        public void ExibirInfo()
        {
            Console.WriteLine("Produto B");
        }
    }

}
