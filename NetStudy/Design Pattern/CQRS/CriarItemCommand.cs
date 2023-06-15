using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.CQRS
{
    // Classe para representar um comando de criação de um novo item
    public class CriarItemCommand
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
