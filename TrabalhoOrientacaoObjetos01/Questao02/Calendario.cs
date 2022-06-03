﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02
{
    public class Calendario
    {
        public DateTime Data;
        public string ObterMesPorExtenso()
        {
            var mes = Convert.ToString(Data.ToString("MM"));
            var primeiraParteMes =Convert.ToInt32( mes.Substring(0, 1));
            var segundaParteMes = Convert.ToInt32(mes.Substring(1, 1));
            var mesExtenso = "";

                if (primeiraParteMes == 0 && segundaParteMes == 1)
                {
                    mesExtenso = "Janeiro";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 2)
                {
                    mesExtenso = "Fevereiro";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 3)
                {
                    mesExtenso = "Março";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 4)
                {
                    mesExtenso = "Abril";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 5)
                {
                    mesExtenso = "Maio";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 6)
                {
                    mesExtenso = "Junho";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 7)
                {
                    mesExtenso = "Julho";
                }
                else if (primeiraParteMes == 0 && segundaParteMes == 8)
                {
                    mesExtenso = "Agosto";
                }
                else if(segundaParteMes == 0 && segundaParteMes == 9)
                {
                    mesExtenso = "Setembro";
                }

            if (primeiraParteMes == 1 && segundaParteMes == 0)
            {
                    mesExtenso = "Outubro";
                }
                else if (primeiraParteMes == 1 && segundaParteMes == 1)
                {
                    mesExtenso = "Novembro";
                }
                else if (primeiraParteMes == 1 && segundaParteMes == 2)
                {
                    mesExtenso = "Dezembro";
                }
            }
            return mesExtenso;
        }

        public string ObterDiaPorExtenso()
        {
            var dia = Convert.ToString(Data.Day);
            var primeiraParteDia = dia.Substring(0, 1);
            var segundaParteDia = dia.Substring(0, 2);
            var diaExtenso = "";
            if (primeiraParteDia == "0")
            {
                if (primeiraParteDia == 0 && segundaParteDia == 1)
                {
                    diaExtenso = "Dia Primeiro";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 2)
                {
                    diaExtenso = "Dia Dois";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 3)
                {
                    diaExtenso = "Dia Três";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 4)
                {
                    diaExtenso = "Dia Quatro";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 5)
                {
                    diaExtenso = "Dia Cinco";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 6)
                {
                    diaExtenso = "Dia Seis";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 7)
                {
                    diaExtenso = "Dia Sete";
                }
                else if (primeiraParteDia == 0 && segundaParteDia == 8)
                {
                    diaExtenso = "Dia Oito";
                }
                else if(primeiraParteDia == 0 && segundaParteDia == 9)
                {
                    diaExtenso = "Dia Nove";
                }


            }

                if ( && segundaParteDia == 0)
                {
                    diaExtenso = "Dia Dez";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 1)
                {
                    diaExtenso = "Dia Onze";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 2)
                {
                    diaExtenso = "Dia Doze";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 3)
                {
                    diaExtenso = "Dia Treze";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 4)
                {
                    diaExtenso = "Dia Catorze";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 5)
                {
                    diaExtenso = "Dia Quinze";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 6)
                {
                    diaExtenso = "Dia Dezesseis";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 7)
                {
                    diaExtenso = "Dia Dezessete";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 8)
                {
                    diaExtenso = "Dia Dezoito";
                }
                else if (primeiraParteDia == 1 && segundaParteDia == 9)
                {
                    diaExtenso = "Dia Dezenove";
                }
            }
            if (primeiraParteDia == 2 && segundaParteDia == 0)
                  {
                    diaExtenso = "Dia Vinte";
                   }
                else if (primeiraParteDia == 2 segundaParteDia == 1)
                {
                    diaExtenso = "Dia Vinte e Um";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 2)
                {
                    diaExtenso = "Dia Vinte e Dois";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 3)
                {
                    diaExtenso = "Dia Vinte e Três";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 4)
                {
                    diaExtenso = "Dia Vinte e Quatro";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 5)
                {
                    diaExtenso = "Dia Vinte e Cinco";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 6)
                {
                    diaExtenso = "Dia Vinte e Seis";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 7)
                {
                    diaExtenso = "Dia Vinte e Sete";
                }
                else if (primeiraParteDia == 2 && segundaParteDia == 8)
                {
                    diaExtenso = "Dia Vinte e Oito";
                }
                else if(primeiraParteDia == 2 && segundaParteDia == 9)
                {
                    diaExtenso = "Dia Vinte e Nove";
                }
                if (primeiraParteDia == 3 && segundaParteDia == 0)
                {
                        diaExtenso = "Dia Trinta";
                }
                else if (primeiraParteDia == 3 segundaParteDia == 1)
                    {
                        diaExtenso = "Dia Trinta e Um";
                    }
            }
            return diaExtenso;
        }
        public string ObterAnoPorExtenso()
        {
            var ano = Convert.ToString(Data.Year);
            var primeiraParteAno = ano.Substring(0, 1);
            var segundaParteAno = ano.Substring(1, 1);
            var terceiraParteAno = ano.Substring(2, 1);
            var quartaParteAno = ano.Substring(3, 1);
            var anoExtenso = "";
            var anoPrimeiraParteExtenso = "";
            var anoSegundaParteExtenso = "";
            var anoTerceiraParteExtenso = "";
            var anoQuartaParteExtenso = "";

            if (primeiraParteAno == "1")
            {
                anoPrimeiraParteExtenso = "Mil";
            }
            else if (primeiraParteAno == "2")
            {
                anoPrimeiraParteExtenso = "Dois Mil";
            }

            if (segundaParteAno == "9")
            {
                anoSegundaParteExtenso = "Novecentos";
            }
            else if (segundaParteAno == "8")
            {
                anoSegundaParteExtenso = "Oitocentos";
            }
            else if (segundaParteAno == "7")
            {
                anoSegundaParteExtenso = "Setecentos";
            }
            else if (segundaParteAno == "6")
            {
                anoSegundaParteExtenso = "Seiscentos";
            }
            else if (segundaParteAno == "5")
            {
                anoSegundaParteExtenso = "Quinhentos";
            }
            else if (segundaParteAno == "4")
            {
                anoSegundaParteExtenso = "Quatrocentos";
            }
            else if (segundaParteAno == "3")
            {
                anoSegundaParteExtenso = "Trezentos";
            }
            else if (segundaParteAno == "2")
            {
                anoSegundaParteExtenso = "Duzentos";
            }
            else if (segundaParteAno == "1")
            {
                anoSegundaParteExtenso = "Cem";
            }

            if (terceiraParteAno == "9")
            {
                anoPrimeiraParteExtenso = "Noventa";
            }
            else if (terceiraParteAno == "8")
            {
                anoPrimeiraParteExtenso = "Oitenta";
            }
            else if (terceiraParteAno == "7")
            {
                anoPrimeiraParteExtenso = "Setenta";
            }
            else if (terceiraParteAno == "6")
            {
                anoPrimeiraParteExtenso = "Sessenta";
            }
            else if (terceiraParteAno == "5")
            {
                anoPrimeiraParteExtenso = "Cinquenta";
            }
            else if (terceiraParteAno == "4")
            {
                anoPrimeiraParteExtenso = "Quarenta";
            }
            else if (terceiraParteAno == "3")
            {
                anoPrimeiraParteExtenso = "Trinta";
            }
            else if (terceiraParteAno == "2")
            {
                anoPrimeiraParteExtenso = "Vinte";
            }
            else if (terceiraParteAno == "1")
            {
                anoPrimeiraParteExtenso = "Dez";
            }

            if (quartaParteAno == "0")
            {
                anoQuartaParteExtenso = "";
            }
            else if (quartaParteAno == "1")
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

            anoExtenso = primeiraParteAno + " " + segundaParteAno + " " + terceiraParteAno + " " + quartaParteAno;

            return anoExtenso;
        }

        public string ObterDataCompletaPorExtenso()
        {
            var mes = Convert.ToString(Data.Month);
            var dia = Convert.ToString(Data.Day);
            var ano = Convert.ToString(Data.Year);
            var mesExtenso = ObterMesPorExtenso();
            var diaExtenso = ObterDiaPorExtenso();
            var anoExtenso = ObterAnoPorExtenso();

            var dataPorExtenso = diaExtenso + " de " + mesExtenso + " de " + anoExtenso + ".";
            return dataPorExtenso;

        }
    }
}
