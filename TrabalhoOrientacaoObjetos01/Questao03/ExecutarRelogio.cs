using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao03;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExecutarRelogio
    {
       
        public void Executar()
        {
            var timeHora = new Relogio();
            
            Console.WriteLine("Digite a hora:");
            timeHora.HoraInformada = Console.ReadLine();
            timeHora.Obter_Hora_Por_Extenso();


        }

    }
}
