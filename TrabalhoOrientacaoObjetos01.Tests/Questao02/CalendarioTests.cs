using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao02
{
    // Juliana Cristina Forbici
    public class CalendarioTests
    {
        [Theory]
        [InlineData(01, "Janeiro")]
        [InlineData(02, "Fevereiro")]
        [InlineData(03, "Março")]
        [InlineData(04, "Abril")]
        [InlineData(05, "Maio")]
        [InlineData(06, "Junho")]
        [InlineData(07, "Julho")]
        [InlineData(08, "Agosto")]
        [InlineData(09, "Setembro")]
        [InlineData(10, "Outubro")]
        [InlineData(11, "Novembro")]
        [InlineData(12, "Dezembro")]
        public void Cenario01_Validar_ObterMesPorExtenso(int mesInfomardo, string mesPorExtenso)
        {
            // Arrange
            var caledario = new Calendario();
            caledario.Data = new DateTime(2022, mesInfomardo, 01);

            // Act
            var mesTexto = caledario.ObterMesPorExtenso();

            // Assert
            mesTexto.Should().Be(mesPorExtenso);
        }

        [Theory]
        [InlineData(01, "Dia Primeiro")]
        [InlineData(02, "Dia Dois")]
        [InlineData(03, "Dia Três")]
        [InlineData(04, "Dia Quatro")]
        [InlineData(05, "Dia Cinco")]
        [InlineData(06, "Dia Seis")]
        [InlineData(07, "Dia Sete")]
        [InlineData(08, "Dia Oito")]
        [InlineData(09, "Dia Nove")]
        [InlineData(10, "Dia Dez")]
        [InlineData(11, "Dia Onze")]
        [InlineData(12, "Dia Doze")]
        [InlineData(13, "Dia Treze")]
        [InlineData(14, "Dia Quatorze")]
        [InlineData(15, "Dia Quinze")]
        [InlineData(16, "Dia Dezesseis")]
        [InlineData(17, "Dia Dezessete")]
        [InlineData(18, "Dia Dezoito")]
        [InlineData(19, "Dia Dezenove")]
        [InlineData(20, "Dia Vinte")]
        [InlineData(21, "Dia Vinte e Um")]
        [InlineData(22, "Dia Vinte e Dois")]
        [InlineData(23, "Dia Vinte e Três")]
        [InlineData(24, "Dia Vinte e Quatro")]
        [InlineData(25, "Dia Vinte e Cinco")]
        [InlineData(26, "Dia Vinte e Seis")]
        [InlineData(27, "Dia Vinte e Sete")]
        [InlineData(28, "Dia Vinte e Oito")]
        [InlineData(29, "Dia Vinte e Nove")]
        [InlineData(30, "Dia Trinta")]
        [InlineData(31, "Dia Trinta e Um")]

        public void Cenario02_Validar_ObterDiaPorExtenso(int diaInfomardo, string diaPorExtenso)
        {
            // Arrange
            var caledario = new Calendario();
            caledario.Data = new DateTime(2022, 01, diaInfomardo);

            //Act
            var diaTexto = caledario.ObterDiaPorExtenso();

            //Assert
            diaTexto.Should().Be(diaPorExtenso);
        }

        [Theory]
        [InlineData(1970, "Mil Novecentos e Setenta")]
        [InlineData(1971, "Mil Novecentos e Setenta e Um")]
        [InlineData(1972, "Mil Novecentos e Setenta e Dois")]
        [InlineData(1973, "Mil Novecentos e Setenta e Três")]
        [InlineData(1974, "Mil Novecentos e Setenta e Quatro")]
        [InlineData(1975, "Mil Novecentos e Setenta e Cinco")]
        [InlineData(1976, "Mil Novecentos e Setenta e Seis")]
        [InlineData(1977, "Mil Novecentos e Setenta e Sete")]
        [InlineData(1978, "Mil Novecentos e Setenta e Oito")]
        [InlineData(1979, "Mil Novecentos e Setenta e Nove")]
        [InlineData(1980, "Mil Novecentos e Oitenta")]
        [InlineData(1981, "Mil Novecentos e Oitenta e Um")]
        [InlineData(1982, "Mil Novecentos e Oitenta e Dois")]
        [InlineData(1983, "Mil Novecentos e Oitenta e Três")]
        [InlineData(1984, "Mil Novecentos e Oitenta e Quatro")]
        [InlineData(1985, "Mil Novecentos e Oitenta e Cinco")]
        [InlineData(1986, "Mil Novecentos e Oitenta e Seis")]
        [InlineData(1987, "Mil Novecentos e Oitenta e Sete")]
        [InlineData(1988, "Mil Novecentos e Oitenta e Oito")]
        [InlineData(1989, "Mil Novecentos e Oitenta e Nove")]
        [InlineData(1990, "Mil Novecentos e Noventa")]
        [InlineData(1991, "Mil Novecentos e Noventa e Um")]
        [InlineData(1992, "Mil Novecentos e Noventa e Dois")]
        [InlineData(1993, "Mil Novecentos e Noventa e Três")]
        [InlineData(1994, "Mil Novecentos e Noventa e Quatro")]
        [InlineData(1995, "Mil Novecentos e Noventa e Cinco")]
        [InlineData(1996, "Mil Novecentos e Noventa e Seis")]
        [InlineData(1997, "Mil Novecentos e Noventa e Sete")]
        [InlineData(1998, "Mil Novecentos e Noventa e Oito")]
        [InlineData(1999, "Mil Novecentos e Noventa e Nove")]
        [InlineData(2000, "Dois mil")]
        [InlineData(2001, "Dois mil e Um")]
        [InlineData(2002, "Dois mil e Dois")]
        [InlineData(2003, "Dois mil e Três")]
        [InlineData(2004, "Dois mil e Quatro")]
        [InlineData(2005, "Dois mil e Cinco")]
        [InlineData(2006, "Dois mil e Seis")]
        [InlineData(2007, "Dois mil e Sete")]
        [InlineData(2008, "Dois mil e Oito")]
        [InlineData(2009, "Dois mil e Nove")]
        [InlineData(2010, "Dois mil e Dez")]
        [InlineData(2011, "Dois mil e Onze")]
        [InlineData(2012, "Dois mil e Doze")]
        [InlineData(2013, "Dois mil e Treze")]
        [InlineData(2014, "Dois mil e Quatorze")]
        [InlineData(2015, "Dois mil e Quinze")]
        [InlineData(2016, "Dois mil e Dezesseis")]
        [InlineData(2017, "Dois mil e Dezessete")]
        [InlineData(2018, "Dois mil e Dezoito")]
        [InlineData(2019, "Dois mil e Dezenove")]
        [InlineData(2020, "Dois mil e Vinte")]
        [InlineData(2021, "Dois mil e Vinte e Um")]
        [InlineData(2022, "Dois mil e Vinte e Dois")]
        [InlineData(2023, "Dois mil e Vinte e Três")]
        [InlineData(2024, "Dois mil e Vinte e Quatro")]
        [InlineData(2025, "Dois mil e Vinte e Cinco")]
        [InlineData(2026, "Dois mil e Vinte e Seis")]
        [InlineData(2027, "Dois mil e Vinte e Sete")]
        [InlineData(2028, "Dois mil e Vinte e Oito")]
        [InlineData(2029, "Dois mil e Vinte e Nove")]
        [InlineData(2030, "Dois mil e Trinta")]
        public void Cenario03_Validar_ObterAnoPorExtenso(int anoInfomardo, string anoPorExtenso)
        {
            // Arrange
            var caledario = new Calendario();
            caledario.Data = new DateTime(anoInfomardo, 01, 01);

            // Act
            var anoTexto = caledario.ObterAnoPorExtenso();

            // Assert
            anoTexto.Should().Be(anoPorExtenso);
        }
    }
}