using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.CQRS
{
    // Classe para representar um comando de exclusão de um item existente
    public class ExcluirItemCommand
    {
        public int Id { get; set; }
    }
}
