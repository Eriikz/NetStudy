
namespace NetStudy
{
    public class Program
    {
        private static void Main()
        {

            Factory();




            #region POO

            static void Composicao()
            {
                var run = new POO.Composicao.Run(); 
                run.Exibir(); 
            }

            static void Interface()
            {
                var run = new POO.Interface.Run(); 
                run.Exibir();
            }

            static void Delegates()
            {
                var run = new POO.Delegates.Run(); 
                run.Exibir();
            }

            #endregion


            #region Design_Pattern

            static void Injecao()
            {
                var run = new Design_Pattern.IOC_DI.Run();
                run.Exibir();
            }

            static void Factory()
            {
                var run = new Design_Pattern.Factory.Run();
                run.Exibir();
            }

            #endregion
        }
    }
}