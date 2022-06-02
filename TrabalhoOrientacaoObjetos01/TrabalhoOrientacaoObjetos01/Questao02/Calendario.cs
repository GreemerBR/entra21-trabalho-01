using System;
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
            var mes = Convert.ToString(Data.Month);
            var primeiraParteMes = mes.Substring(0, 1);
            var segundaParteMes = mes.Substring(1, 1);
            var mesExtenso = "";

            if(primeiraParteMes == "0")
            {
                if (segundaParteMes == "1")
                {
                    mesExtenso = "Janeiro";
                }
                else if(segundaParteMes == "2")
                {
                    mesExtenso = "Fevereiro";
                }
                else if(segundaParteMes == "3")
                {
                    mesExtenso = "Março";
                }
                else if(segundaParteMes == "4")
                {
                    mesExtenso = "Abril";
                }
                else if(segundaParteMes == "5")
                {
                    mesExtenso = "Maio";
                }
                else if(segundaParteMes == "6")
                {
                    mesExtenso = "Junho";
                }
                else if(segundaParteMes == "7")
                {
                    mesExtenso = "Julho";
                }
                else if(segundaParteMes == "8")
                {
                    mesExtenso = "Agosto";
                }
                else
                {
                    mesExtenso = "Setembro";
                }                
            }    

            if(primeiraParteMes == "1")
            {
                if(segundaParteMes == "0")
                {
                    mesExtenso = "Outubro";
                }
                else if(segundaParteMes == "1")
                {
                    mesExtenso = "Novembro";
                }
                else if(segundaParteMes == "2")
                {
                    mesExtenso = "Dezembro";
                }
            }
            return mesExtenso;
        }

        public void ObterDiaPorExtenso()
        {
            var dia = Convert.ToString(Data.Day);
            var primeiraParteDia = dia.Substring(0, 1);
            var segundaParteDia = dia.Substring(0, 2);
            var diaExtenso = "";
            if(primeiraParteDia == "0")
            {
                if(primeiraParteDia == "1")
                {
                    diaExtenso = "Dia Primeiro";
                }
                else if(primeiraParteDia == "2")
                {
                    diaExtenso = "Dia Dois";
                }
                else if(primeiraParteDia == "3")
                {
                    diaExtenso = "Dia Três";
                }
                else if(primeiraParteDia == "4")
                {
                    diaExtenso = "Dia Quatro";
                }
                else if(primeiraParteDia == "5")
                {
                    diaExtenso = "Dia Cinco";
                }
                else if(primeiraParteDia == "6")
                {
                    diaExtenso = "Dia Seis";
                }
                else if(primeiraParteDia == "7")
                {
                    diaExtenso = "Dia Sete";
                }
                else if(primeiraParteDia == "8")
                {
                    diaExtenso = "Dia Oito";
                }
                else
                {
                    diaExtenso = "Dia Nove";
                }
                
            }
            if(primeiraParteDia == "1")
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
                    diaExtenso = "Dia Catorze";
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
            if(primeiraParteDia == "2")
            {
                if(segundaParteDia == "0")
                {
                    diaExtenso = "Dia Vinte";
                }
                else if(segundaParteDia == "1")
                {
                    diaExtenso = "Dia Vinte e Um";
                }
               else  if(segundaParteDia == "2")
                {
                    diaExtenso = "Dia Vinte e Dois";
                }
               else if(segundaParteDia == "3")
                {
                    diaExtenso = "Dia Vinte e Três";
                }
                else if(segundaParteDia == "4")
                {
                    diaExtenso = "Dia Vinte e Quatro";
                }
                else if(segundaParteDia == "5")
                {
                    diaExtenso = "Dia Vinte e Cinco";
                }
                else if(segundaParteDia == "6")
                {
                    diaExtenso = "Dia Vinte e Seis";
                }
                else if(segundaParteDia == "7")
                {
                    diaExtenso = "Dia Vinte e Sete";
                }
                else if(segundaParteDia == "8")
                {
                    diaExtenso = "Dia Vinte e Oito";
                }
                else
                {
                    diaExtenso = "Dia Vinte e Nove";
                }
                if(primeiraParteDia == "3")
                {
                    if(segundaParteDia == "0")
                    {
                        diaExtenso = "Dia Trinta";
                    }
                    else if(segundaParteDia == "1")
                    {
                        diaExtenso = "Dia Trinta e Um";
                    }
                }
            }
        }
        public void ObterAnoPorExtenso()
        {
            var ano = Convert.ToString(Data.Year);
            var primeiraParteAno = ano.Substring(0, 1);
            var segundaParteAno = ano.Substring(1, 1);
            var terceiraParteAno = ano.Substring(2, 1);
            var quartaParteAno = ano.Substring(3, 1);
            var anoExtenso = "";

            if(primeiraParteAno == "1")
            {
                if(segundaParteAno == "9")
                {
                    if(terceiraParteAno == "7")
                    {
                        if(quartaParteAno == "0")
                        {
                            anoExtenso = "Mil Novecentos e Setenta";
                        }
                        else if(quartaParteAno == "1")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Um";
                        }
                        else if(quartaParteAno == "2")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Dois";
                        }
                        else if(quartaParteAno == "3")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Três";
                        }
                        else if(quartaParteAno == "4")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Quatro";
                        }
                        else if(quartaParteAno == "5")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Cinco";
                        }
                        else if(quartaParteAno == "6")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Seis";
                        }
                        else if(quartaParteAno == "7")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Sete";
                        }
                        else if(quartaParteAno == "8")
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Oito";
                        }
                        else
                        {
                            anoExtenso = "Mil Novecentos e Setenta e Nove";
                        }
                       
                    }
                    if(terceiraParteAno == "8")
                    {
                        if(quartaParteAno == "0")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta";
                        }
                        else if(quartaParteAno == "1")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Um";
                        }
                        else if(quartaParteAno == "2")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Dois";
                        }
                        else if (quartaParteAno == "3")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Três";
                        }
                        else if (quartaParteAno == "4")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Quatro";
                        }
                        else if(quartaParteAno== "5")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Cinco";
                        }
                        else if(quartaParteAno == "6")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Seis";
                        }
                        else if(quartaParteAno == "7")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Sete";
                        }
                        else if(quartaParteAno == "8")
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Oito";
                        }
                        else
                        {
                            anoExtenso = "Mil Novecentos e Oitenta e Nove";
                        }
                    }
                    if(terceiraParteAno == "9")
                    {
                        if(quartaParteAno == "0")
                        {
                            anoExtenso = "Mil Novecentos e Noventa";
                        }
                        else if(quartaParteAno == "1")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Um";
                        }
                        else if(quartaParteAno == "2")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Dois";
                        }
                        else if(quartaParteAno == "3")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Três";
                        }
                        else if(quartaParteAno == "4")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Quatro";
                        }
                        else if (quartaParteAno == "5")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Cinco";
                        }
                        else if(quartaParteAno == "6")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Seis";
                        }
                        else if(quartaParteAno == "7")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Sete";
                        }
                        else if (quartaParteAno == "8")
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Oito";
                        }
                        else
                        {
                            anoExtenso = "Mil Novecentos e Noventa e Nove";
                        }
                    }
                }
            }
           
        }
        public void ObterDataCompletaPorExtenso()
        {

        }
    }
}
