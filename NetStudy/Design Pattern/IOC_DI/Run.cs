using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace NetStudy.Design_Pattern.IOC_DI
{
    public class Run
    {

        public Run()
        {
          //  criar um contêiner do unity
           var container = new UnityContainer();

            // registrar as implementações das interfaces no contêiner
            container.RegisterType<IMotor, Motor>();

            // resolver a dependência de cliente
            var motor = container.Resolve<Motor>();

            //executar
            motor.Ligar();

        }

        public void Exibir()
        {

        }
    }
}
