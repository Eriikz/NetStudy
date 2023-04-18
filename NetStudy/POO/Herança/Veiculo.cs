using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Herança
{
    internal class Veiculo
    {
        public string Categoria { get; set; }
        public string Capacidade { get; set; }

        public virtual string GetCategoria()
        {
            return "Veiculo";
        }
    }
}
