using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01
{
    public class Numero
    {
        public double Valor;

        public string ObterDecimalPorExtenso()
        {
            var numeroInformado = Convert.ToString(Valor);

            var indexVirgula = numeroInformado.IndexOf(",");

            var primeiraParteDecimal = numeroInformado.Substring((indexVirgula + 1), 1);
            var segundaParteDecimal = numeroInformado.Substring((indexVirgula + 2), 1);

            var decimalPorExtenso = "";

            var textoPrimeiraParte = "";

            if (primeiraParteDecimal == "1")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Dez.";
                }
                else if (segundaParteDecimal == "1")
                {
                    decimalPorExtenso = "Onze.";
                }
                else if (segundaParteDecimal == "2")
                {
                    decimalPorExtenso = "Doze.";
                }
                else if (segundaParteDecimal == "3")
                {
                    decimalPorExtenso = "Treze.";
                }
                else if (segundaParteDecimal == "4")
                {
                    decimalPorExtenso = "Quatorze.";
                }
                else if (segundaParteDecimal == "5")
                {
                    decimalPorExtenso = "Quinze.";
                }
                else if (segundaParteDecimal == "6")
                {
                    decimalPorExtenso = "Dezesseis.";
                }
                else if (segundaParteDecimal == "7")
                {
                    decimalPorExtenso = "Dezessete.";
                }
                else if (segundaParteDecimal == "8")
                {
                    decimalPorExtenso = "Dezoito.";
                }
                else
                {
                    decimalPorExtenso = "Dezenove.";
                }
            }
            else if (primeiraParteDecimal == "2")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Vinte.";
                }
                else
                {
                    textoPrimeiraParte = "Vinte e ";
                }
            }
            else if (primeiraParteDecimal == "3")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Trinta.";
                }
                else
                {
                    textoPrimeiraParte = "Trinta e ";
                }
            }
            else if (primeiraParteDecimal == "4")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Quarenta.";
                }
                else
                {
                    textoPrimeiraParte = "Quarenta e ";
                }
            }
            else if (primeiraParteDecimal == "5")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Cinquenta.";
                }
                else
                {
                    textoPrimeiraParte = "Cinquenta e ";
                }
            }
            else if (primeiraParteDecimal == "6")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Sessenta.";
                }
                else
                {
                    textoPrimeiraParte = "Sessenta e ";
                }
            }
            else if (primeiraParteDecimal == "7")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Setenta.";
                }
                else
                {
                    textoPrimeiraParte = "Setenta e ";
                }
            }
            else if (primeiraParteDecimal == "8")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Oitenta.";
                }
                else
                {
                    textoPrimeiraParte = "Oitenta e ";
                }
            }
            else if (primeiraParteDecimal == "9")
            {
                if (segundaParteDecimal == "0" || segundaParteDecimal == "")
                {
                    decimalPorExtenso = "Noventa.";
                }
                else
                {
                    textoPrimeiraParte = "Noventa e ";
                }
            }

            var textoSegundaParteD = "";

            if (segundaParteDecimal == "1")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Um.";
                }
                else
                {
                    textoSegundaParteD = "um.";
                }
            }
            else if (segundaParteDecimal == "2")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Dois.";
                }
                else
                {
                    textoSegundaParteD = "dois.";
                }
            }
            else if (segundaParteDecimal == "3")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Três.";
                }
                else
                {
                    textoSegundaParteD = "três.";
                }
            }
            else if (segundaParteDecimal == "4")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Quatro.";
                }
                else
                {
                    textoSegundaParteD = "quatro.";
                }
            }
            else if (segundaParteDecimal == "5")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Cinco.";
                }
                else
                {
                    textoSegundaParteD = "cinco.";
                }
            }
            else if (segundaParteDecimal == "6")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Seis.";
                }
                else
                {
                    textoSegundaParteD = "seis.";
                }
            }
            else if (segundaParteDecimal == "7")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Sete.";
                }
                else
                {
                    textoSegundaParteD = "sete.";
                }
            }
            else if (segundaParteDecimal == "8")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Oito.";
                }
                else
                {
                    textoSegundaParteD = "oito.";
                }
            }
            else if (segundaParteDecimal == "9")
            {
                if (primeiraParteDecimal == "0")
                {
                    decimalPorExtenso = "Nove.";
                }
                else
                {
                    textoSegundaParteD = "nove.";
                }
            }

            if (decimalPorExtenso == "")
            {
                decimalPorExtenso = textoPrimeiraParte + textoSegundaParteD;
            }

            return decimalPorExtenso;
        }

        /* Unidade
         * Dezena
         * Centena
         * UnidadeDeMilhar
         * NumeroCompleto
         */
    }
}
