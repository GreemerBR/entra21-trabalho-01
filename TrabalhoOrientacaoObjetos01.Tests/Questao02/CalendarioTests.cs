using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao02;
using Xunit;


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
    public void Cenario01_Validar_MesPorExtenso(int mesInfomardo, string mesPorExtenso)
    {
        //Arrange
        var caledario = new Calendario();
        caledario.Data = DateTime.Today.AddMonths(mesInfomardo);


        //Act
        var mesTexto = caledario.ObterMesPorExtenso();

        //Assert
        mesTexto.Should().Be(mesPorExtenso);
    }
    [Theory]
    [InlineData(01, "Primeiro")]
    [InlineData(02, "Dois")]
    [InlineData(03, "Três")]
    [InlineData(04, "Quatro")]
    [InlineData(05, "Cinco")]
    [InlineData(06, "Seis")]
    [InlineData(07, "Sete")]
    [InlineData(08, "Oito")]
    [InlineData(09, "Nove")]
    [InlineData(10, "Dez")]
    [InlineData(11, "Onze")]
    [InlineData(12, "Doze")]
    [InlineData(13, "Treze")]
    [InlineData(14, "Catorze")]
    [InlineData(15, "Quinze")]
    [InlineData(16, "Dezesseis")]
    [InlineData(17, "Dezessete")]
    [InlineData(18, "Dezoito")]
    [InlineData(19, "Dezenove")]
    [InlineData(20, "Vinte")]
    [InlineData(21, "Vinte e Um")]
    [InlineData(22, "Vinte e Dois")]
    [InlineData(23, "Vinte e Três")]
    [InlineData(24, "Vinte e Quatro")]
    [InlineData(25,"Vinte e Cinco")]
    [InlineData(26,"Vinte e Seis")]
    [InlineData(27,"Vinte e Sete")]
    [InlineData(28,"Vinte e Oito")]
    [InlineData(29,"Vinte e Nove")]
    [InlineData(30,"Trinta")]
    [InlineData(31,"Trinta e Um")]

     public void Cenario02_Validar_DiaPorExtenso(int diaInfomardo, string diaPorExtenso)
    {
        //Arrange
        var caledario = new Calendario();
        caledario.Data = DateTime.Today.AddDays(diaInfomardo);


        //Act
        var diaTexto = caledario.ObterDiaPorExtenso();

        //Assert
        diaTexto.Should().Be(diaPorExtenso);
    }
}