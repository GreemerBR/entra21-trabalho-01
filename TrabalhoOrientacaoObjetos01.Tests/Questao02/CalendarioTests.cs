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
}