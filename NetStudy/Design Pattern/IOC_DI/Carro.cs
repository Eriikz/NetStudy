using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.Design_Pattern.IOC_DI
{
    // Classe Carro com injeção de dependência no construtor
    public class Carro
    {
        private readonly IMotor _motor;

        // Construtor que recebe uma instância de IMotor como parâmetro
        public Carro(IMotor motor)
        {
            _motor = motor;
        }

        public void LigarCarro()
        {
            _motor.Ligar();
        }

        public void DesligarCarro()
        {
            _motor.Desligar();
        }
    }
}
