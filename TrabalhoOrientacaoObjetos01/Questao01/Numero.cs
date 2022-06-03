using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01
{
    // Gregory Viegas Zimmer
    public class Numero
    {
        public double Valor;

        public string ObterDecimalPorExtenso()
        {
            var decimalPorExtenso = "";
            var textoPrimeiraParte = "";
            var textoSegundaParte = "";

            var numeroInformado = Valor.ToString();

            var possuiVirgula = numeroInformado.Contains(',');

            if (possuiVirgula == true)
            {
                var indexVirgula = numeroInformado.IndexOf(",");

                var primeiraParteDecimal = "";
                var segundaParteDecimal = "";

                if (numeroInformado.Length - indexVirgula == 2)
                {
                    primeiraParteDecimal = numeroInformado.Substring((indexVirgula + 1), 1);
                    segundaParteDecimal = "0";
                }
                else
                {
                    primeiraParteDecimal = numeroInformado.Substring((indexVirgula + 1), 1);
                    segundaParteDecimal = numeroInformado.Substring((indexVirgula + 2), 1);
                }

                if (primeiraParteDecimal == "0")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Zero";
                    }
                    else
                    {
                        textoPrimeiraParte = "";
                    }
                }
                else if (primeiraParteDecimal == "1")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Dez";
                    }
                    else if (segundaParteDecimal == "1")
                    {
                        decimalPorExtenso = "Onze";
                    }
                    else if (segundaParteDecimal == "2")
                    {
                        decimalPorExtenso = "Doze";
                    }
                    else if (segundaParteDecimal == "3")
                    {
                        decimalPorExtenso = "Treze";
                    }
                    else if (segundaParteDecimal == "4")
                    {
                        decimalPorExtenso = "Quatorze";
                    }
                    else if (segundaParteDecimal == "5")
                    {
                        decimalPorExtenso = "Quinze";
                    }
                    else if (segundaParteDecimal == "6")
                    {
                        decimalPorExtenso = "Dezesseis";
                    }
                    else if (segundaParteDecimal == "7")
                    {
                        decimalPorExtenso = "Dezessete";
                    }
                    else if (segundaParteDecimal == "8")
                    {
                        decimalPorExtenso = "Dezoito";
                    }
                    else
                    {
                        decimalPorExtenso = "Dezenove";
                    }
                }
                else if (primeiraParteDecimal == "2")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Vinte";
                    }
                    else
                    {
                        textoPrimeiraParte = "Vinte e ";
                    }
                }
                else if (primeiraParteDecimal == "3")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Trinta";
                    }
                    else
                    {
                        textoPrimeiraParte = "Trinta e ";
                    }
                }
                else if (primeiraParteDecimal == "4")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Quarenta";
                    }
                    else
                    {
                        textoPrimeiraParte = "Quarenta e ";
                    }
                }
                else if (primeiraParteDecimal == "5")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Cinquenta";
                    }
                    else
                    {
                        textoPrimeiraParte = "Cinquenta e ";
                    }
                }
                else if (primeiraParteDecimal == "6")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Sessenta";
                    }
                    else
                    {
                        textoPrimeiraParte = "Sessenta e ";
                    }
                }
                else if (primeiraParteDecimal == "7")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Setenta";
                    }
                    else
                    {
                        textoPrimeiraParte = "Setenta e ";
                    }
                }
                else if (primeiraParteDecimal == "8")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Oitenta";
                    }
                    else
                    {
                        textoPrimeiraParte = "Oitenta e ";
                    }
                }
                else if (primeiraParteDecimal == "9")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Noventa";
                    }
                    else
                    {
                        textoPrimeiraParte = "Noventa e ";
                    }
                }

                if (segundaParteDecimal == "1")
                {
                    textoSegundaParte = "um";
                }
                else if (segundaParteDecimal == "2")
                {
                    textoSegundaParte = "dois";
                }
                else if (segundaParteDecimal == "3")
                {
                    textoSegundaParte = "três";
                }
                else if (segundaParteDecimal == "4")
                {
                    textoSegundaParte = "quatro";
                }
                else if (segundaParteDecimal == "5")
                {
                    textoSegundaParte = "cinco";
                }
                else if (segundaParteDecimal == "6")
                {
                    textoSegundaParte = "seis";
                }
                else if (segundaParteDecimal == "7")
                {
                    textoSegundaParte = "sete";
                }
                else if (segundaParteDecimal == "8")
                {
                    textoSegundaParte = "oito";
                }
                else if (segundaParteDecimal == "9")
                {
                    textoSegundaParte = "nove";
                }

                if (decimalPorExtenso == "")
                {
                    if (textoPrimeiraParte != "")
                    {
                        decimalPorExtenso = textoPrimeiraParte + textoSegundaParte;
                    }
                    else
                    {
                        decimalPorExtenso = char.ToUpper(textoSegundaParte[0]) + textoSegundaParte.Substring(1);
                    }
                }
            }
            else
            {
                decimalPorExtenso = "Zero";
            }

            return decimalPorExtenso;
        }

        public string ObterUnidadePorExtenso()
        {
            var unidade = "";

            var numeroInformado = Valor.ToString();

            var possuiVirgula = numeroInformado.Contains(',');

            if (possuiVirgula == true)
            {
                var indexVirgula = numeroInformado.IndexOf(",");

                unidade = numeroInformado.Substring((indexVirgula - 1), 1);
            }
            else
            {
                unidade = numeroInformado.Substring((numeroInformado.Length - 1), 1);
            }

            var unidadePorExtenso = "";

            if (unidade == "0")
            {
                unidadePorExtenso = "Zero";
            }
            else if (unidade == "1")
            {
                unidadePorExtenso = "Um";
            }
            else if (unidade == "2")
            {
                unidadePorExtenso = "Dois";
            }
            else if (unidade == "3")
            {
                unidadePorExtenso = "Três";
            }
            else if (unidade == "4")
            {
                unidadePorExtenso = "Quatro";
            }
            else if (unidade == "5")
            {
                unidadePorExtenso = "Cinco";
            }
            else if (unidade == "6")
            {
                unidadePorExtenso = "Seis";
            }
            else if (unidade == "7")
            {
                unidadePorExtenso = "Sete";
            }
            else if (unidade == "8")
            {
                unidadePorExtenso = "Oito";
            }
            else
            {
                unidadePorExtenso = "Nove";
            }

            return unidadePorExtenso;
        }

        public string ObterDezenaPorExtenso()
        {
            var dezena = "";
            var dezenaPorExtenso = "";

            var numeroInformado = Valor.ToString();

            var possuiVirgula = numeroInformado.Contains(',');

            if (possuiVirgula == true)
            {
                var indexVirgula = numeroInformado.IndexOf(",");

                if (indexVirgula >= 2)
                {
                    dezena = numeroInformado.Substring((indexVirgula - 2), 1);
                }
                else
                {
                    dezenaPorExtenso = "Zero";
                }
            }
            else
            {
                if (numeroInformado.Length >= 2)
                {
                    dezena = numeroInformado.Substring((numeroInformado.Length - 2), 1);
                }
                else
                {
                    dezenaPorExtenso = "Zero";
                }
            }

            if (dezena == "0")
            {
                dezenaPorExtenso = "Zero";
            }
            else if (dezena == "1")
            {
                dezenaPorExtenso = "Dez";
            }
            else if (dezena == "2")
            {
                dezenaPorExtenso = "Vinte";
            }
            else if (dezena == "3")
            {
                dezenaPorExtenso = "Trinta";
            }
            else if (dezena == "4")
            {
                dezenaPorExtenso = "Quarenta";
            }
            else if (dezena == "5")
            {
                dezenaPorExtenso = "Cinquenta";
            }
            else if (dezena == "6")
            {
                dezenaPorExtenso = "Sessenta";
            }
            else if (dezena == "7")
            {
                dezenaPorExtenso = "Setenta";
            }
            else if (dezena == "8")
            {
                dezenaPorExtenso = "Oitenta";
            }
            else if (dezena == "9")
            {
                dezenaPorExtenso = "Noventa";
            }

            return dezenaPorExtenso;
        }

        public string ObterCentenaPorExtenso()
        {
            var centena = "";
            var centenaPorExtenso = "";

            var numeroInformado = Valor.ToString();

            var possuiVirgula = numeroInformado.Contains(',');

            if (possuiVirgula == true)
            {
                var indexVirgula = numeroInformado.IndexOf(",");

                if (indexVirgula >= 3)
                {
                    centena = numeroInformado.Substring((indexVirgula - 3), 1);
                }
                else
                {
                    centenaPorExtenso = "Zero";
                }
            }
            else
            {
                if (numeroInformado.Length >= 3)
                {
                    centena = numeroInformado.Substring((numeroInformado.Length - 3), 1);
                }
                else
                {
                    centenaPorExtenso = "Zero";
                }
            }


            if (centena == "0")
            {
                centenaPorExtenso = "Zero";
            }
            else if (centena == "1")
            {
                centenaPorExtenso = "Cem";
            }
            else if (centena == "2")
            {
                centenaPorExtenso = "Duzentos";
            }
            else if (centena == "3")
            {
                centenaPorExtenso = "Trezentos";
            }
            else if (centena == "4")
            {
                centenaPorExtenso = "Quatrocentos";
            }
            else if (centena == "5")
            {
                centenaPorExtenso = "Quinhentos";
            }
            else if (centena == "6")
            {
                centenaPorExtenso = "Seissentos";
            }
            else if (centena == "7")
            {
                centenaPorExtenso = "Setessentos";
            }
            else if (centena == "8")
            {
                centenaPorExtenso = "Oitocentos";
            }
            else if (centena == "9")
            {
                centenaPorExtenso = "Novecentos";
            }

            return centenaPorExtenso;
        }

        public string ObterUnidadeDeMilharPorExtenso()
        {
            var milhar = "";
            var milharPorExtenso = "";

            var numeroInformado = Valor.ToString();

            var possuiVirgula = numeroInformado.Contains(',');

            if (possuiVirgula == true)
            {
                var indexVirgula = numeroInformado.IndexOf(",");

                if (indexVirgula >= 4)
                {
                    milhar = numeroInformado.Substring((indexVirgula - 4), 1);
                }
                else
                {
                    milharPorExtenso = "Zero";
                }
            }
            else
            {
                if (numeroInformado.Length >= 4)
                {
                    milhar = numeroInformado.Substring((numeroInformado.Length - 4), 1);
                }
                else
                {
                    milharPorExtenso = "Zero";
                }
            }


            if (milhar == "0")
            {
                milharPorExtenso = "Zero";
            }
            else if (milhar == "1")
            {
                milharPorExtenso = "Mil";
            }
            else if (milhar == "2")
            {
                milharPorExtenso = "Dois mil";
            }
            else if (milhar == "3")
            {
                milharPorExtenso = "Três mil";
            }
            else if (milhar == "4")
            {
                milharPorExtenso = "Quatro mil";
            }
            else if (milhar == "5")
            {
                milharPorExtenso = "Cinco mil";
            }
            else if (milhar == "6")
            {
                milharPorExtenso = "Seis mil";
            }
            else if (milhar == "7")
            {
                milharPorExtenso = "Sete mil";
            }
            else if (milhar == "8")
            {
                milharPorExtenso = "Oito mil";
            }
            else if (milhar == "9")
            {
                milharPorExtenso = "Nove mil";
            }

            return milharPorExtenso;
        }

        public string ObterNumeroCompletoPorExtenso()
        {
            var milharPorExtenso = ObterUnidadeDeMilharPorExtenso();
            var centenaPorExtenso = ObterCentenaPorExtenso();
            var dezenaPorExtenso = ObterDezenaPorExtenso();
            var unidadePorExtenso = ObterUnidadePorExtenso();
            var decimalPorExtenso = ObterDecimalPorExtenso() + " centavo(s)";

            if (centenaPorExtenso == "Cem" && (dezenaPorExtenso != "Zero" || unidadePorExtenso != "Zero"))
            {
                centenaPorExtenso = "Cento";
            }

            if (milharPorExtenso == "Zero")
            {
                milharPorExtenso = "";
            }

            if (centenaPorExtenso == "Zero")
            {
                centenaPorExtenso = "";
            }

            if (dezenaPorExtenso == "Zero")
            {
                dezenaPorExtenso = "";
            }

            if (unidadePorExtenso == "Zero")
            {
                unidadePorExtenso = "";
            }

            if (decimalPorExtenso == "Zero centavo(s)")
            {
                decimalPorExtenso = "";
            }

            if (dezenaPorExtenso == "Dez")
            {
                if (unidadePorExtenso == "Zero")
                {
                    dezenaPorExtenso = "Dez";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Um")
                {
                    dezenaPorExtenso = "Onze";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Dois")
                {
                    dezenaPorExtenso = "Doze";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Três")
                {
                    dezenaPorExtenso = "Treze";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Quatro")
                {
                    dezenaPorExtenso = "Quatorze";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Cinco")
                {
                    dezenaPorExtenso = "Quinze";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Seis")
                {
                    dezenaPorExtenso = "Dezesseis";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Sete")
                {
                    dezenaPorExtenso = "Dezessete";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Oito")
                {
                    dezenaPorExtenso = "Dezoito";
                    unidadePorExtenso = "";
                }
                else if (unidadePorExtenso == "Nove")
                {
                    dezenaPorExtenso = "Dezenove";
                    unidadePorExtenso = "";
                }
            }

            if (milharPorExtenso != "")
            {
                milharPorExtenso = milharPorExtenso + " ";
            }

            if (centenaPorExtenso != "" && (dezenaPorExtenso != "" || unidadePorExtenso != ""))
            {
                centenaPorExtenso = centenaPorExtenso + " e ";
            }

            if (dezenaPorExtenso != "" && unidadePorExtenso != "")
            {
                dezenaPorExtenso = dezenaPorExtenso + " e ";
            }

            var numeroCompletoPorExtenso = "";

            if (milharPorExtenso == "" && centenaPorExtenso == "" && dezenaPorExtenso == "" && unidadePorExtenso == "" && decimalPorExtenso == "")
            {
                numeroCompletoPorExtenso = "Zero reais";
            }
            else if (milharPorExtenso == "" && centenaPorExtenso == "" && dezenaPorExtenso == "" && unidadePorExtenso == "" && decimalPorExtenso != "")
            {
                numeroCompletoPorExtenso = decimalPorExtenso;
            }
            else if (milharPorExtenso != "" && centenaPorExtenso != "" && dezenaPorExtenso != "" && unidadePorExtenso != "" && decimalPorExtenso == "")
            {
                numeroCompletoPorExtenso = milharPorExtenso + centenaPorExtenso + dezenaPorExtenso + unidadePorExtenso + " real(is)";
            }
            else
            {
                numeroCompletoPorExtenso = milharPorExtenso + centenaPorExtenso + dezenaPorExtenso + unidadePorExtenso + " real(is) e " + decimalPorExtenso;
            }

            return numeroCompletoPorExtenso;
        }
    }
}