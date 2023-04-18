using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Interface
{
    // Definição da interface
    public interface IAnimal
    {
        string Nome { get; set; }
        void EmitirSom();
    }

}
