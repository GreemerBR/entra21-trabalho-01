using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02
{
    // Juliana Cristina Forbici
    public class Calendario
    {
        public DateTime Data;
        public string ObterMesPorExtenso()
        {
            var mes = Data.ToString("MM");
            var primeiraParteMes = mes.Substring(0, 1);
            var segundaParteMes = mes.Substring(1, 1);
            var mesExtenso = "";

            if (primeiraParteMes == "0")
            {
                if (segundaParteMes == "1")
                {
                    mesExtenso = "Janeiro";
                }
                else if (segundaParteMes == "2")
                {
                    mesExtenso = "Fevereiro";
                }
                else if (segundaParteMes == "3")
                {
                    mesExtenso = "Março";
                }
                else if (segundaParteMes == "4")
                {
                    mesExtenso = "Abril";
                }
                else if (segundaParteMes == "5")
                {
                    mesExtenso = "Maio";
                }
                else if (segundaParteMes == "6")
                {
                    mesExtenso = "Junho";
                }
                else if (segundaParteMes == "7")
                {
                    mesExtenso = "Julho";
                }
                else if (segundaParteMes == "8")
                {
                    mesExtenso = "Agosto";
                }
                else if (segundaParteMes == "9")
                {
                    mesExtenso = "Setembro";
                }
            }
            else if (primeiraParteMes == "1")
            {
                if (segundaParteMes == "0")
                {
                    mesExtenso = "Outubro";
                }
                else if (segundaParteMes == "1")
                {
                    mesExtenso = "Novembro";
                }
                else if (segundaParteMes == "2")
                {
                    mesExtenso = "Dezembro";
                }
            }

            return mesExtenso;
        }


        public string ObterDiaPorExtenso()
        {
            var dia = Data.ToString("dd");
            var primeiraParteDia = dia.Substring(0, 1);
            var segundaParteDia = dia.Substring(1, 1);
            var diaExtenso = "";

            if (primeiraParteDia == "0")
            {
                if (segundaParteDia == "1")
                {
                    diaExtenso = "Dia Primeiro";
                }
                else if (segundaParteDia == "2")
                {
                    diaExtenso = "Dia Dois";
                }
                else if (segundaParteDia == "3")
                {
                    diaExtenso = "Dia Três";
                }
                else if (segundaParteDia == "4")
                {
                    diaExtenso = "Dia Quatro";
                }
                else if (segundaParteDia == "5")
                {
                    diaExtenso = "Dia Cinco";
                }
                else if (segundaParteDia == "6")
                {
                    diaExtenso = "Dia Seis";
                }
                else if (segundaParteDia == "7")
                {
                    diaExtenso = "Dia Sete";
                }
                else if (segundaParteDia == "8")
                {
                    diaExtenso = "Dia Oito";
                }
                else if (segundaParteDia == "9")
                {
                    diaExtenso = "Dia Nove";
                }
            }
            else if (primeiraParteDia == "1")
            {
                if (segundaParteDia == "0")
                {
                    diaExtenso = "Dia Dez";
                }
                else if (segundaParteDia == "1")
                {
                    diaExtenso = "Dia Onze";
                }
                else if (segundaParteDia == "2")
                {
                    diaExtenso = "Dia Doze";
                }
                else if (segundaParteDia == "3")
                {
                    diaExtenso = "Dia Treze";
                }
                else if (segundaParteDia == "4")
                {
                    diaExtenso = "Dia Quatorze";
                }
                else if (segundaParteDia == "5")
                {
                    diaExtenso = "Dia Quinze";
                }
                else if (segundaParteDia == "6")
                {
                    diaExtenso = "Dia Dezesseis";
                }
                else if (segundaParteDia == "7")
                {
                    diaExtenso = "Dia Dezessete";
                }
                else if (segundaParteDia == "8")
                {
                    diaExtenso = "Dia Dezoito";
                }
                else
                {
                    diaExtenso = "Dia Dezenove";
                }
            }
            else if (primeiraParteDia == "2")
            {
                if (segundaParteDia == "0")
                {
                    diaExtenso = "Dia Vinte";
                }
                else if (segundaParteDia == "1")
                {
                    diaExtenso = "Dia Vinte e Um";
                }
                else if (segundaParteDia == "2")
                {
                    diaExtenso = "Dia Vinte e Dois";
                }
                else if (segundaParteDia == "3")
                {
                    diaExtenso = "Dia Vinte e Três";
                }
                else if (segundaParteDia == "4")
                {
                    diaExtenso = "Dia Vinte e Quatro";
                }
                else if (segundaParteDia == "5")
                {
                    diaExtenso = "Dia Vinte e Cinco";
                }
                else if (segundaParteDia == "6")
                {
                    diaExtenso = "Dia Vinte e Seis";
                }
                else if (segundaParteDia == "7")
                {
                    diaExtenso = "Dia Vinte e Sete";
                }
                else if (segundaParteDia == "8")
                {
                    diaExtenso = "Dia Vinte e Oito";
                }
                else
                {
                    diaExtenso = "Dia Vinte e Nove";
                }
            }
            else if (primeiraParteDia == "3")
            {
                if (segundaParteDia == "0")
                {
                    diaExtenso = "Dia Trinta";
                }
                else if (segundaParteDia == "1")
                {
                    diaExtenso = "Dia Trinta e Um";
                }
            }

            return diaExtenso;
        }

        public string ObterAnoPorExtenso()
        {
            var ano = Data.ToString("yyyy");

            var primeiraParteAno = ano.Substring(0, 1);
            var segundaParteAno = ano.Substring(1, 1);
            var terceiraParteAno = ano.Substring(2, 1);
            var quartaParteAno = ano.Substring(3, 1);

            var anoExtenso = "";
            var anoPrimeiraParteExtenso = "";
            var anoSegundaParteExtenso = "";
            var anoTerceiraParteExtenso = "";
            var anoQuartaParteExtenso = "";

            if (primeiraParteAno == "0")
            {
                anoPrimeiraParteExtenso = "";
            }
            else if (primeiraParteAno == "1")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Mil e ";
                }
            }
            else if (primeiraParteAno == "2")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Dois mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Dois mil e ";
                }
            }
            else if (primeiraParteAno == "3")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Três mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Três mil e ";
                }
            }
            else if (primeiraParteAno == "4")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Quatro mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Quatro mil e ";
                }
            }
            else if (primeiraParteAno == "5")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Cinco mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Cinco mil e ";
                }
            }
            else if (primeiraParteAno == "6")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Seis mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Seis mil e ";
                }
            }
            else if (primeiraParteAno == "7")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Sete mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Sete mil e ";
                }
            }
            else if (primeiraParteAno == "8")
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Oito mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Oito mil e ";
                }
            }
            else
            {
                if (segundaParteAno == "0" && terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoPrimeiraParteExtenso = "Nove mil";
                }
                else
                {
                    anoPrimeiraParteExtenso = "Nove mil e ";
                }
            }

            if (segundaParteAno == "0")
            {
                anoSegundaParteExtenso = "";
            }
            else if (segundaParteAno == "1")
            {
                if (terceiraParteAno == "0" && quartaParteAno == "0")
                {
                    anoSegundaParteExtenso = "Cem";
                }
                else
                {
                    anoSegundaParteExtenso = "Cento e ";
                }
            }
            else if (segundaParteAno == "2")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Duzentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Duzentos";
                }
            }
            else if (segundaParteAno == "3")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Trezentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Trezentos";
                }
            }
            else if (segundaParteAno == "4")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Quatrocentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Quatrocentos";
                }
            }
            else if (segundaParteAno == "5")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Quinhentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Quinhentos";
                }
            }
            else if (segundaParteAno == "6")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Seiscentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Seiscentos";
                }
            }
            else if (segundaParteAno == "7")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Setecentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Setecentos";
                }
            }
            else if (segundaParteAno == "8")
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Oitocentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Oitocentos";
                }
            }
            else
            {
                if (terceiraParteAno != "0" || quartaParteAno != "0")
                {
                    anoSegundaParteExtenso = "Novecentos e ";
                }
                else
                {
                    anoSegundaParteExtenso = "Novecentos";
                }
            }

            if (terceiraParteAno == "1")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Dez";
                }
                else if (quartaParteAno == "1")
                {
                    anoTerceiraParteExtenso = "Onze";
                }
                else if (quartaParteAno == "2")
                {
                    anoTerceiraParteExtenso = "Doze";
                }
                else if (quartaParteAno == "3")
                {
                    anoTerceiraParteExtenso = "Treze";
                }
                else if (quartaParteAno == "4")
                {
                    anoTerceiraParteExtenso = "Quatorze";
                }
                else if (quartaParteAno == "5")
                {
                    anoTerceiraParteExtenso = "Quinze";
                }
                else if (quartaParteAno == "6")
                {
                    anoTerceiraParteExtenso = "Dezesseis";
                }
                else if (quartaParteAno == "7")
                {
                    anoTerceiraParteExtenso = "Dezessete";
                }
                else if (quartaParteAno == "8")
                {
                    anoTerceiraParteExtenso = "Dezoito";
                }
                else
                {
                    anoTerceiraParteExtenso = "Dezenove";
                }
            }
            else if (terceiraParteAno == "2")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Vinte";
                }
                else
                {
                    anoTerceiraParteExtenso = "Vinte e ";
                }
            }
            else if (terceiraParteAno == "3")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Trinta";
                }
                else
                {
                    anoTerceiraParteExtenso = "Trinta e ";
                }
            }
            else if (terceiraParteAno == "4")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Quarenta";
                }
                else
                {
                    anoTerceiraParteExtenso = "Quarenta e ";
                }
            }
            else if (terceiraParteAno == "5")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Cinquenta";
                }
                else
                {
                    anoTerceiraParteExtenso = "Cinquenta e ";
                }
            }
            else if (terceiraParteAno == "6")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Sessenta";
                }
                else
                {
                    anoTerceiraParteExtenso = "Sessenta e ";
                }
            }
            else if (terceiraParteAno == "7")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Setenta";
                }
                else
                {
                    anoTerceiraParteExtenso = "Setenta e ";
                }
            }
            else if (terceiraParteAno == "8")
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Oitenta";
                }
                else
                {
                    anoTerceiraParteExtenso = "Oitenta e ";
                }
            }
            else
            {
                if (quartaParteAno == "0")
                {
                    anoTerceiraParteExtenso = "Noventa";
                }
                else
                {
                    anoTerceiraParteExtenso = "Noventa e ";
                }
            }

            if (terceiraParteAno != "1")
            {
                if (quartaParteAno == "1")
                {
                    anoQuartaParteExtenso = "Um";
                }
                else if (quartaParteAno == "2")
                {
                    anoQuartaParteExtenso = "Dois";
                }
                else if (quartaParteAno == "3")
                {
                    anoQuartaParteExtenso = "Três";
                }
                else if (quartaParteAno == "4")
                {
                    anoQuartaParteExtenso = "Quatro";
                }
                else if (quartaParteAno == "5")
                {
                    anoQuartaParteExtenso = "Cinco";
                }
                else if (quartaParteAno == "6")
                {
                    anoQuartaParteExtenso = "Seis";
                }
                else if (quartaParteAno == "7")
                {
                    anoQuartaParteExtenso = "Sete";
                }
                else if (quartaParteAno == "8")
                {
                    anoQuartaParteExtenso = "Oito";
                }
                else if (quartaParteAno == "9")
                {
                    anoQuartaParteExtenso = "Nove";
                }
            }

            anoExtenso = anoPrimeiraParteExtenso + anoSegundaParteExtenso + anoTerceiraParteExtenso + anoQuartaParteExtenso;

            return anoExtenso;
        }

        public string ObterDataCompletaPorExtenso()
        {
            var mesExtenso = ObterMesPorExtenso();
            var diaExtenso = ObterDiaPorExtenso();
            var anoExtenso = ObterAnoPorExtenso();

            var dataPorExtenso = diaExtenso + " de " + mesExtenso + " de " + anoExtenso + ".";

            return dataPorExtenso;
        }
    }
}