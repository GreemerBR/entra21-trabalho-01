using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01;
//using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02;
//using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao03;

var opcaoDesejada = 0;

while (opcaoDesejada != 4)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
------MENU------
1 - Questão 01
2 - Questão 02
3 - Questão 03
4 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4))
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

        var quartao01 = new Principal();
        quartao01.Executar();
    }
    //else if (opcaoDesejada == 2)
    //{
    //    var questao02 = new Questao02();
    //    questao02.Executar();
    //}
    //else if (opcaoDesejada == 3)
    //{
    //    var questao03 = new Questao03();
    //    questao03.Executar();
    //}    
}
