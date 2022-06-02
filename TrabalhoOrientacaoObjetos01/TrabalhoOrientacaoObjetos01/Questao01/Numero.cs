﻿using System;
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
                        decimalPorExtenso = "Zero.";
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
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
                    if (segundaParteDecimal == "0")
                    {
                        decimalPorExtenso = "Noventa.";
                    }
                    else
                    {
                        textoPrimeiraParte = "Noventa e ";
                    }
                }

                if (segundaParteDecimal == "1")
                {
                    textoSegundaParte = "um.";
                }
                else if (segundaParteDecimal == "2")
                {
                    textoSegundaParte = "dois.";
                }
                else if (segundaParteDecimal == "3")
                {
                    textoSegundaParte = "três.";
                }
                else if (segundaParteDecimal == "4")
                {
                    textoSegundaParte = "quatro.";
                }
                else if (segundaParteDecimal == "5")
                {
                    textoSegundaParte = "cinco.";
                }
                else if (segundaParteDecimal == "6")
                {
                    textoSegundaParte = "seis.";
                }
                else if (segundaParteDecimal == "7")
                {
                    textoSegundaParte = "sete.";
                }
                else if (segundaParteDecimal == "8")
                {
                    textoSegundaParte = "oito.";
                }
                else if (segundaParteDecimal == "9")
                {
                    textoSegundaParte = "nove.";
                }

                if (decimalPorExtenso == "")
                {
                    decimalPorExtenso = textoPrimeiraParte + textoSegundaParte;
                }
            }
            else
            {
                decimalPorExtenso = "Zero.";
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