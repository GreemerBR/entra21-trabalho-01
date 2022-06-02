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
            var decimalPorExtenso = "";
            var textoPrimeiraParte = "";
            var textoSegundaParte = "";

            var numeroInformado = Convert.ToString(Valor);

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
                        decimalPorExtenso = "Zero décimos.";
                    }
                    else
                    {
                        textoPrimeiraParte = "Zero ";
                    }
                }
                else if (primeiraParteDecimal == "1")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Dez décimos.";
                    }
                    else if (segundaParteDecimal == "1")
                    {
                        decimalPorExtenso = "Onze décimos.";
                    }
                    else if (segundaParteDecimal == "2")
                    {
                        decimalPorExtenso = "Doze décimos.";
                    }
                    else if (segundaParteDecimal == "3")
                    {
                        decimalPorExtenso = "Treze décimos.";
                    }
                    else if (segundaParteDecimal == "4")
                    {
                        decimalPorExtenso = "Quatorze décimos.";
                    }
                    else if (segundaParteDecimal == "5")
                    {
                        decimalPorExtenso = "Quinze décimos.";
                    }
                    else if (segundaParteDecimal == "6")
                    {
                        decimalPorExtenso = "Dezesseis décimos.";
                    }
                    else if (segundaParteDecimal == "7")
                    {
                        decimalPorExtenso = "Dezessete décimos.";
                    }
                    else if (segundaParteDecimal == "8")
                    {
                        decimalPorExtenso = "Dezoito décimos.";
                    }
                    else
                    {
                        decimalPorExtenso = "Dezenove décimos.";
                    }
                }
                else if (primeiraParteDecimal == "2")
                {
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Vinte décimos.";
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
                        decimalPorExtenso = "Trinta décimos.";
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
                        decimalPorExtenso = "Quarenta décimos.";
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
                        decimalPorExtenso = "Cinquenta décimos.";
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
                        decimalPorExtenso = "Sessenta décimos.";
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
                        decimalPorExtenso = "Setenta décimos.";
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
                        decimalPorExtenso = "Oitenta décimos.";
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
                        decimalPorExtenso = "Noventa décimos.";
                    }
                    else
                    {
                        textoPrimeiraParte = "Noventa e ";
                    }
                }

                if (segundaParteDecimal == "1")
                {
                    textoSegundaParte = "um décimos.";
                }
                else if (segundaParteDecimal == "2")
                {
                    textoSegundaParte = "dois décimos.";
                }
                else if (segundaParteDecimal == "3")
                {
                    textoSegundaParte = "três décimos.";
                }
                else if (segundaParteDecimal == "4")
                {
                    textoSegundaParte = "quatro décimos.";
                }
                else if (segundaParteDecimal == "5")
                {
                    textoSegundaParte = "cinco décimos.";
                }
                else if (segundaParteDecimal == "6")
                {
                    textoSegundaParte = "seis décimos.";
                }
                else if (segundaParteDecimal == "7")
                {
                    textoSegundaParte = "sete décimos.";
                }
                else if (segundaParteDecimal == "8")
                {
                    textoSegundaParte = "oito décimos.";
                }
                else if (segundaParteDecimal == "9")
                {
                    textoSegundaParte = "nove décimos.";
                }

                if (decimalPorExtenso == "")
                {
                    decimalPorExtenso = textoPrimeiraParte + textoSegundaParte;
                }
            }
            else
            {
                decimalPorExtenso = "Zero décimos.";
            }

            return decimalPorExtenso;
        }

        public string ObterUnidadePorExtenso()
        {
            var unidade = "";

            var numeroInformado = Convert.ToString(Valor);

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
                unidadePorExtenso = "Zero.";
            }
            else if (unidade == "1")
            {
                unidadePorExtenso = "Um.";
            }
            else if (unidade == "2")
            {
                unidadePorExtenso = "Dois.";
            }
            else if (unidade == "3")
            {
                unidadePorExtenso = "Três.";
            }
            else if (unidade == "4")
            {
                unidadePorExtenso = "Quatro.";
            }
            else if (unidade == "5")
            {
                unidadePorExtenso = "Cinco.";
            }
            else if (unidade == "6")
            {
                unidadePorExtenso = "Seis.";
            }
            else if (unidade == "7")
            {
                unidadePorExtenso = "Sete.";
            }
            else if (unidade == "8")
            {
                unidadePorExtenso = "Oito.";
            }
            else
            {
                unidadePorExtenso = "Nove.";
            }

            return unidadePorExtenso;
        }

        public string ObterDezenaPorExtenso()
        {
            var dezena = "";
            var dezenaPorExtenso = "";

            var numeroInformado = Convert.ToString(Valor);

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
                    dezenaPorExtenso = "Este número não possui dezena.";
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
                    dezenaPorExtenso = "Este número não possui dezena.";
                }                
            }
            

            if (dezena == "0")
            {
                dezenaPorExtenso = "Zero.";
            }
            else if (dezena == "1")
            {
                dezenaPorExtenso = "Dez.";
            }
            else if (dezena == "2")
            {
                dezenaPorExtenso = "Vinte.";
            }
            else if (dezena == "3")
            {
                dezenaPorExtenso = "Trinta.";
            }
            else if (dezena == "4")
            {
                dezenaPorExtenso = "Quarenta.";
            }
            else if (dezena == "5")
            {
                dezenaPorExtenso = "Cinquenta.";
            }
            else if (dezena == "6")
            {
                dezenaPorExtenso = "Sessenta.";
            }
            else if (dezena == "7")
            {
                dezenaPorExtenso = "Setenta.";
            }
            else if (dezena == "8")
            {
                dezenaPorExtenso = "Oitenta.";
            }
            else if (dezena == "9")
            {
                dezenaPorExtenso = "Noventa.";
            }

            return dezenaPorExtenso;
        }


        /* Centena
         * UnidadeDeMilhar
         * NumeroCompleto
         */
    }
}
