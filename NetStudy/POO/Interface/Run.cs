

namespace NetStudy.POO.Interface
{
    public class Run
    {
        /// <summary>
        /// Uma interface em C# é uma espécie de "contrato" que define um conjunto de métodos e propriedades que uma classe deve implementar. Uma classe pode implementar várias interfaces, o que permite que ela "herde" comportamentos de várias fontes diferentes
        /// </summary>
        /// 
        public Cachorro cachorro;
        public Gato gato;

        public Run()
        {
            cachorro = new Cachorro();
            cachorro.Nome = "Rex";

            gato = new Gato();
            gato.Nome = "Frajola";

        }

        public void Exibir()
        {
            cachorro.EmitirSom();
            gato.EmitirSom();
        }
    }
}
