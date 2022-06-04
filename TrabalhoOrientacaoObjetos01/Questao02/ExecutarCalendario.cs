using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02
{
    // Juliana Cristina Forbici
    public class ExecutarCalendario
    {
        public void Executar()
        {


            var data = new Calendario();

            try
            {
                Console.Write("Por favor informe uma data (yyyy/MM/dd): ");
                data.Data = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite uma data valida!!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Por favor informe uma data (yyyy/MM/dd): ");
                data.Data = Convert.ToDateTime(Console.ReadLine());

            }



            var opcaoDesejada = 0;

            while (opcaoDesejada != 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
------------------MENU------------------
1 - Obter dia por extenso
2 - Obter mes por extenso
3 - Obter ano por extenso
4 - Obter data completo por extenso
5 - SAIR
");

                try
                {
                    Console.Write("Digite a opção desejada: ");
                    opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                    if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4 && opcaoDesejada != 5))
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
                    var diaPorExtenso = data.ObterDiaPorExtenso();
                    Console.WriteLine($"Data informada: {data.Data}");
                    Console.WriteLine(diaPorExtenso);
                }

                if (opcaoDesejada == 2)
                {
                    Console.Clear();
                    var mesPorExtenso = data.ObterMesPorExtenso();
                    Console.WriteLine($"Data informada: {data.Data}");
                    Console.WriteLine(mesPorExtenso);
                }

                if (opcaoDesejada == 3)
                {
                    Console.Clear();
                    var anoPorExtenso = data.ObterAnoPorExtenso();
                    Console.WriteLine($"Data informada: {data.Data}");
                    Console.WriteLine(anoPorExtenso);
                }

                if (opcaoDesejada == 4)
                {
                    Console.Clear();
                    var dataCompletaPorExtenso = data.ObterDataCompletaPorExtenso();
                    Console.WriteLine($"Data informada: {data.Data}");
                    Console.WriteLine(dataCompletaPorExtenso);
                }
            }
        }
    }

}

