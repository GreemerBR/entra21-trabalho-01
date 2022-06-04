using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao03
{
    // Cristyan Alvir Alexandrino
    public class ExecutarRelogio
    {
        public void Executar()
        {
            Console.Clear();
            var hora = new Relogio();

            var horaInformadaValida = false;
            var horaInformada = DateTime.Now;

            while (horaInformadaValida == false)
            {
                try
                {
                    Console.Write("Por favor informe uma hora (hh:mm:ss): ");
                    horaInformada = Convert.ToDateTime(Console.ReadLine());

                    horaInformadaValida = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A hora informada não é valida.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            hora.Hora = horaInformada;

            var opcaoDesejada = 0;

            while (opcaoDesejada != 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
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
                    var horaPorExtenso = hora.ObterHoraPorExtenso();
                    Console.WriteLine($"Hora informada: {horaInformada.ToString("HH:mm:ss")}");
                    Console.WriteLine(horaPorExtenso);
                }

                if (opcaoDesejada == 2)
                {
                    Console.Clear();
                    var minutoPorExtenso = hora.ObterMinutoPorExtenso();
                    Console.WriteLine($"Hora informada: {horaInformada.ToString("HH:mm:ss")}");
                    Console.WriteLine(minutoPorExtenso);
                }

                if (opcaoDesejada == 3)
                {
                    Console.Clear();
                    var segundoPorExtenso = hora.ObterSegundoPorExtenso();
                    Console.WriteLine($"Hora informada: {horaInformada.ToString("HH:mm:ss")}");
                    Console.WriteLine(segundoPorExtenso);
                }

                if (opcaoDesejada == 4)
                {
                    Console.Clear();
                    var horaCompletaPorExtenso = hora.ObterHoraCompletaPorExtenso();
                    Console.WriteLine($"Hora informada: {horaInformada.ToString("HH:mm:ss")}");
                    Console.WriteLine(horaCompletaPorExtenso);
                }
            }
        }
    }
}
