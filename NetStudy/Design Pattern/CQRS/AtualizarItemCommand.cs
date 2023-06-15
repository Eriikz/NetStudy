using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.CQRS
{
    // Classe para representar um comando de atualização de um item existente
    public class AtualizarItemCommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
