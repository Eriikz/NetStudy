using NetStudy.POO.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static NetStudy.POO.Delegates.Calculadora;

namespace NetStudy.POO.Delegates
{
    public class Run
    {
        /// <summary>
        /// Delegates em C# são tipos que representam referências a métodos com uma assinatura específica. Eles são muito úteis quando queremos passar métodos como parâmetros para outras funções ou quando queremos criar eventos personalizados.
        /// </summary>
        /// 
        public Calculadora calculadora;

        public Run()
        {
            calculadora = new Calculadora();
        }

        /// <summary>
        /// Nesse exemplo, criamos um delegate chamado OperacaoMatematica que pode referenciar métodos que recebem dois parâmetros inteiros e não retornam nada. Em seguida, criamos uma classe Calculadora que implementa quatro métodos de operações matemáticas diferentes. No método Main, criamos uma instância da classe Calculadora e criamos uma referência ao delegate OperacaoMatematica que aponta para o método Somar da instância da calculadora.Em seguida, adicionamos mais três métodos ao delegate usando o operador +=. Finalmente, chamamos o delegate passando os parâmetros 10 e 5, o que faz com que os quatro métodos referenciados pelo delegate sejam executados, imprimindo o resultado na tela. Os delegates são muito úteis em cenários onde queremos passar métodos como parâmetros para outras funções, pois eles permitem que o método que recebe o delegate execute um conjunto de operações variáveis sem precisar saber exatamente quais métodos serão executados.
        /// </summary>
        public void Exibir()
        {
            OperacaoMatematica operacao = calculadora.Somar;
            operacao += calculadora.Subtrair;
            operacao += calculadora.Multiplicar;
            operacao += calculadora.Dividir;
            operacao(10, 5);
        }
    }
}
