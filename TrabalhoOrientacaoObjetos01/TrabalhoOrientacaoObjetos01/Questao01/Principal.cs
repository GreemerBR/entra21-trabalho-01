using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01
{
    public class Principal
    {
        public void Executar()
        {
            var numeroDecimal = new Numero();

            Console.Clear();
            Console.Write("Por favor informe um número com até duas casas decimais");
            var numeroInformado = Convert.ToDouble(Console.ReadLine());

            numeroDecimal.Valor = numeroInformado;

            var numeroPorExtenso = numeroDecimal.ObterDecimalPorExtenso();

            Console.WriteLine(numeroPorExtenso);
        }
    }
}
