using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao03;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao03
{
    public class RelogioTests
    {
        [Theory]
        [InlineData(01, "Uma hora")]
        [InlineData(02, "Duas horas")]
        [InlineData(03, "Três horas")]
        [InlineData(04, "Quatro horas")]
        [InlineData(05, "Cinco horas")]
        [InlineData(06, "Seis horas")]
        [InlineData(07, "Sete horas")]
        [InlineData(08, "Oito horas")]
        [InlineData(09, "Nove horas")]
        [InlineData(10, "Dez horas")]
        [InlineData(11, "Onze horas")]
        [InlineData(12, "Doze horas")]
        [InlineData(13, "Treze horas")]
        [InlineData(14, "Quatorze horas")]
        [InlineData(15, "Quinze horas")]
        [InlineData(16, "Dezesseis horas")]
        [InlineData(17, "Dezessete horas")]
        [InlineData(18, "Dezoito horas")]
        [InlineData(19, "Dezenove horas")]
        [InlineData(20, "Vinte horas")]
        [InlineData(21, "Vinte e uma horas")]
        [InlineData(22, "Vinte e duas horas")]
        [InlineData(23, "Vinte e três horas")]
        public void Validar_HoraPorExtenso(int horaInformada, string horaExtenso)
        {
            //Arrange   
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddHours(horaInformada);


            //act
            var horaPorExtenso = relogio.Obter_Hora_Por_Extenso();

            // Assert
            horaPorExtenso.Should().Be(horaExtenso);
        }
    }
}
