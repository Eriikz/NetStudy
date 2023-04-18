using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.IOC_DI
{
    // Implementação do motor
    public class Motor : IMotor
    {
        public void Ligar()
        {
            Console.WriteLine("Motor ligado.");
        }

        public void Desligar()
        {
            Console.WriteLine("Motor desligado.");
        }
    }
}
