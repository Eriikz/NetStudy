using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Herança
{
    internal class Carro : Veiculo
    {
        public string modelo { get; set; }
        public string cor { get; set; }

        public override string GetCategoria()
        {
            return "Carro, 5 pessoas";
        }
    }
}
