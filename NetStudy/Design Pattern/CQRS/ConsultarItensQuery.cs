using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.CQRS
{
    // Classe para representar uma consulta de itens
    public class ConsultarItensQuery
    {
        public string Nome { get; set; } // Filtro por nome do item
        public decimal PrecoMinimo { get; set; } // Filtro por preço mínimo do item
        public decimal PrecoMaximo { get; set; } // Filtro por preço máximo do item
                                                 // Outras propriedades para configurar a consulta (exemplo: ordenação, paginação, etc.)
    }

}
