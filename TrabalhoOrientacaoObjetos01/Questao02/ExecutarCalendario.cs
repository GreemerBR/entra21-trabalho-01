using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExecutarCalendario
    {
        public void Executar()
        {
             var opcaoDesejada = 0;

            while (opcaoDesejada != 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
------------------MENU------------------
1 - Obter hora por extenso
2 - Obter minuto por extenso
3 - Obter segundo por extenso
4 - Obter hora completo por extenso
5 - SAIR
");

                try
                {
                    Console.Write("Digite uma opção: ");
                    opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                    if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4 && opcaoDesejada != 5))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Por favor, informe um número presente no Menu.")
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Informe um número presente no Menu.");
                }

                if (opcaoDesejada == 1)
                {
                    Console.Clear();
                    var diaExtenso = Calendario.ObterDiaPorExtenso();
                    Console.WriteLine($"Dia por extenso: {diaExtenso}");
                    Console.WriteLine(diaExtenso);
                }

                if (opcaoDesejada == 2)
                {
                    Console.Clear();
                    var mesExtenso = Calendario.ObterMesPorExtenso();
                    Console.WriteLine($"Mês por extenso: {mesExtenso}");
                    Console.WriteLine(mesExtenso);
                }

                if (opcaoDesejada == 3)
                {
                    Console.Clear();
                    var anoExtenso = Calendario.ObterAnoPorExtenso();
                    Console.WriteLine($"Ano por extenso: {anoExtenso}");
                    Console.WriteLine(anoExtenso);
                }

                if (opcaoDesejada == 4)
                {
                    Console.Clear();
                    var dataCompletaPorExtenso = Calendario.ObterDataCompletaPorExtenso();
                    Console.WriteLine($"Data completa por extenso: {dataCompletaPorExtenso}");
                    Console.WriteLine(dataCompletaPorExtenso);
                }

                        Console.Write("Informe uma data (aaaa/mm/de)");
                         var data = Console.ReadLine();

           
        }

    }
}
