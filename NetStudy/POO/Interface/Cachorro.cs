using NetStudy.POO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Interface
{
    // Implementação da classe Cachorro que implementa a interface IAnimal
    public class Cachorro : IAnimal
    {
        public string Nome { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Au au!");
        }
    }

}
