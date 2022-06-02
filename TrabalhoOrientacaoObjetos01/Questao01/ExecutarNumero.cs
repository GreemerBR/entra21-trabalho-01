using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01
{
    public class ExecutarNumero
    {
        public void Executar()
        {
            Console.Clear();
            var numeroDecimal = new Numero();

            var numeroInformadoValido = false;
            var numeroInformado = 0.0;

            while (numeroInformadoValido == false)
            {
                try
                {
                    Console.Write("Por favor informe um número com até duas casas decimais: ");
                    numeroInformado = Convert.ToDouble(Console.ReadLine());

                    numeroInformadoValido = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O número informado não é válido. Por favor informe um número com até duas casas decimais.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            numeroDecimal.Valor = numeroInformado;

            var numeroPorExtenso = numeroDecimal.ObterDecimalPorExtenso();

            Console.Clear();
            Console.WriteLine(numeroPorExtenso);
        }
    }
}
