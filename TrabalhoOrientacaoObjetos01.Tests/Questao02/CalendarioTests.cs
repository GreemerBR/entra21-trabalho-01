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

        //[Theory]
        //[InlineData(1970, "Mil Novecentos e ")]
    }
}