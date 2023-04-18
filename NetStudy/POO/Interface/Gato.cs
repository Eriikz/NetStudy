using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Interface
{
    // Implementação da classe Gato que implementa a interface IAnimal
    public class Gato : IAnimal
    {
        public string Nome { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
