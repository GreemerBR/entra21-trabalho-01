using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01
{
    // Gregory Viegas Zimmer
    public class ExecutarNumero
    {
        public void Executar()
        {
            Console.Clear();
            var numero = new Numero();

            var numeroInformadoValido = false;
            var numeroInformado = 0.0;

            while (numeroInformadoValido == false)
            {
                try
                {
                    Console.Write("Por favor informe um valor positivo entre 0 e 9999,99 reais (com até duas casas decimais): ");
                    numeroInformado = Convert.ToDouble(Console.ReadLine());

                    if (numeroInformado >= 0)
                    {
                        numeroInformadoValido = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O número informado não é válido.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O número informado não é válido.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            numero.Valor = numeroInformado;

            var opcaoDesejada = 0;

            while (opcaoDesejada != 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
------------------MENU------------------
1 - Obter decimal por extenso
2 - Obter unidade por extenso
3 - Obter dezena por extenso
4 - Obter centena por extenso
5 - Obter unidade de milhar por extenso
6 - Obter número completo por extenso
7 - SAIR
");

                try
                {
                    Console.Write("Digite a opção desejada: ");
                    opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                    if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4 && opcaoDesejada != 5 && opcaoDesejada != 6 && opcaoDesejada != 7))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (opcaoDesejada == 1)
                {
                    Console.Clear();
                    var decimalPorExtenso = numero.ObterDecimalPorExtenso();
                    if (decimalPorExtenso != "Zero")
                    {
                        decimalPorExtenso = decimalPorExtenso + " centavos";
                    }
                    Console.WriteLine($"Número informado: {numeroInformado.ToString("F")}");
                    Console.WriteLine(decimalPorExtenso);
                }

                if (opcaoDesejada == 2)
                {
                    Console.Clear();
                    var unidadePorExtenso = numero.ObterUnidadePorExtenso();
                    if (unidadePorExtenso != "Zero")
                    {
                       unidadePorExtenso = unidadePorExtenso + " real(is)";
                    }
                    Console.WriteLine($"Número informado: {numeroInformado.ToString("F")}");
                    Console.WriteLine(unidadePorExtenso);
                }

                if (opcaoDesejada == 3)
                {
                    Console.Clear();
                    var dezenaPorExtenso = numero.ObterDezenaPorExtenso();
                    if (dezenaPorExtenso != "Zero")
                    {
                        dezenaPorExtenso = dezenaPorExtenso + " reais";
                    }
                    Console.WriteLine($"Número informado: {numeroInformado.ToString("F")}");
                    Console.WriteLine(dezenaPorExtenso);
                }

                if (opcaoDesejada == 4)
                {
                    Console.Clear();
                    var centenaPorExtenso = numero.ObterCentenaPorExtenso();
                    if (centenaPorExtenso != "Zero")
                    {
                        centenaPorExtenso = centenaPorExtenso + " reais";
                    }
                    Console.WriteLine($"Número informado: {numeroInformado.ToString("F")}");
                    Console.WriteLine(centenaPorExtenso);
                }

                if (opcaoDesejada == 5)
                {
                    Console.Clear();
                    var milharPorExtenso = numero.ObterUnidadeDeMilharPorExtenso();
                    if (milharPorExtenso != "Zero")
                    {
                        milharPorExtenso = milharPorExtenso + " reais";
                    }
                    Console.WriteLine($"Número informado: {numeroInformado.ToString("F")}");
                    Console.WriteLine(milharPorExtenso);
                }

                if (opcaoDesejada == 6)
                {
                    Console.Clear();
                    var numeroCompletoPorExtenso = numero.ObterNumeroCompletoPorExtenso();
                    Console.WriteLine($"Número informado: {numeroInformado.ToString("F")}");
                    Console.WriteLine(numeroCompletoPorExtenso);
                }
            }
        }
    }
}