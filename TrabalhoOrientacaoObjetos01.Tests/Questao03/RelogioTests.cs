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
        public void Validar_HoraPorExtenso(int horaInformada, string horaPorExtenso)
        {
            //Arrange   
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddHours(horaInformada);


            //act
            var horaTexto = relogio.Obter_Hora_Por_Extenso();

            // Assert
            horaTexto.Should().Be(horaPorExtenso);
        }



        [Theory]
        [InlineData(00, "Zero minutos")]
        [InlineData(01, "Um minuto")]
        [InlineData(02, "Dois minutos")]
        [InlineData(03, "Três minutos")]
        [InlineData(04, "Quatro minutos")]
        [InlineData(05, "Cinco minutos")]
        [InlineData(06, "Seis minutos")]
        [InlineData(07, "Sete minutos")]
        [InlineData(08, "Oito minutos")]
        [InlineData(09, "Nove minutos")]
        [InlineData(10, "Dez minutos")]
        [InlineData(11, "Onze minutos")]
        [InlineData(12, "Doze minutos")]
        [InlineData(13, "Treze minutos")]
        [InlineData(14, "Quatorze minutos")]
        [InlineData(15, "Quinze minutos")]
        [InlineData(16, "Dezesseis minutos")]
        [InlineData(17, "Dezessete minutos")]
        [InlineData(18, "Dezoito minutos")]
        [InlineData(19, "Dezenove minutos")]
        [InlineData(20, "Vinte minutos")]
        [InlineData(21, "Vinte e um minutos")]
        [InlineData(22, "Vinte e dois minutos")]
        [InlineData(23, "Vinte e três minutos")]
        [InlineData(24, "Vinte e quatro minutos")]
        [InlineData(25, "Vinte e cinco minutos")]
        [InlineData(26, "Vinte e seis minutos")]
        [InlineData(27, "Vinte e sete minutos")]
        [InlineData(28, "Vinte e oito minutos")]
        [InlineData(29, "Vinte e nove minutos")]
        [InlineData(30, "Trinta minutos")]
        [InlineData(31, "Trinta e um minutos")]
        [InlineData(32, "Trinta e dois minutos")]
        [InlineData(33, "Trinta e três minutos")]
        [InlineData(34, "Trinta e quatro minutos")]
        [InlineData(35, "Trinta e cinco minutos")]
        [InlineData(36, "Trinta e seis minutos")]
        [InlineData(37, "Trinta e sete minutos")]
        [InlineData(38, "Trinta e oito minutos")]
        [InlineData(39, "Trinta e nove minutos")]
        [InlineData(40, "Quarenta minutos")]
        [InlineData(41, "Quarenta e um minutos")]
        [InlineData(42, "Quarenta e dois minutos")]
        [InlineData(43, "Quarenta e três minutos")]
        [InlineData(44, "Quarenta e quatro minutos")]
        [InlineData(45, "Quarenta e cinco minutos")]
        [InlineData(46, "Quarenta e seis minutos")]
        [InlineData(47, "Quarenta e sete minutos")]
        [InlineData(48, "Quarenta e oito minutos")]
        [InlineData(49, "Quarenta e nove minutos")]
        [InlineData(50, "Cinquenta minutos")]
        [InlineData(51, "Cinquenta e um minutos")]
        [InlineData(52, "Cinquenta e dois minutos")]
        [InlineData(53, "Cinquenta e três minutos")]
        [InlineData(54, "Cinquenta e quatro minutos")]
        [InlineData(55, "Cinquenta e cinco minutos")]
        [InlineData(56, "Cinquenta e seis minutos")]
        [InlineData(57, "Cinquenta e sete minutos")]
        [InlineData(58, "Cinquenta e oito minutos")]
        [InlineData(59, "Cinquenta e nove minutos")]

        public void Validar_MinutoPorExtenso(int minutoInfomardo, string minutoPorExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddMinutes(minutoInfomardo);

            //Act
            var minutoTexto = relogio.Obter_Minuto_Por_Extenso();

            //Assert
            minutoTexto.Should().Be(minutoPorExtenso);
        }

        [Theory]
        [InlineData(00, "Zero segundos")]
        [InlineData(01, "Um segundo")]
        [InlineData(02, "Dois segundos")]
        [InlineData(03, "Três segundos")]
        [InlineData(04, "Quatro segundos")]
        [InlineData(05, "Cinco segundos")]
        [InlineData(06, "Seis segundos")]
        [InlineData(07, "Sete segundos")]
        [InlineData(08, "Oito segundos")]
        [InlineData(09, "Nove segundos")]
        [InlineData(10, "Dez segundos")]
        [InlineData(11, "Onze segundos")]
        [InlineData(12, "Doze segundos")]
        [InlineData(13, "Treze segundos")]
        [InlineData(14, "Quatorze segundos")]
        [InlineData(15, "Quinze segundos")]
        [InlineData(16, "Dezesseis segundos")]
        [InlineData(17, "Dezessete segundos")]
        [InlineData(18, "Dezoito segundos")]
        [InlineData(19, "Dezenove segundos")]
        [InlineData(20, "Vinte segundos")]
        [InlineData(21, "Vinte e um segundos")]
        [InlineData(22, "Vinte e dois segundos")]
        [InlineData(23, "Vinte e três segundos")]
        [InlineData(24, "Vinte e quatro segundos")]
        [InlineData(25, "Vinte e cinco segundos")]
        [InlineData(26, "Vinte e seis segundos")]
        [InlineData(27, "Vinte e sete segundos")]
        [InlineData(28, "Vinte e oito segundos")]
        [InlineData(29, "Vinte e nove segundos")]
        [InlineData(30, "Trinta segundos")]
        [InlineData(31, "Trinta e um segundos")]
        [InlineData(32, "Trinta e dois segundos")]
        [InlineData(33, "Trinta e três segundos")]
        [InlineData(34, "Trinta e quatro segundos")]
        [InlineData(35, "Trinta e cinco segundos")]
        [InlineData(36, "Trinta e seis segundos")]
        [InlineData(37, "Trinta e sete segundos")]
        [InlineData(38, "Trinta e oito segundos")]
        [InlineData(39, "Trinta e nove segundos")]
        [InlineData(40, "Quarenta segundos")]
        [InlineData(41, "Quarenta e um segundos")]
        [InlineData(42, "Quarenta e dois segundos")]
        [InlineData(43, "Quarenta e três segundos")]
        [InlineData(44, "Quarenta e quatro segundos")]
        [InlineData(45, "Quarenta e cinco segundos")]
        [InlineData(46, "Quarenta e seis segundos")]
        [InlineData(47, "Quarenta e sete segundos")]
        [InlineData(48, "Quarenta e oito segundos")]
        [InlineData(49, "Quarenta e nove segundos")]
        [InlineData(50, "Cinquenta segundos")]
        [InlineData(51, "Cinquenta e um segundos")]
        [InlineData(52, "Cinquenta e dois segundos")]
        [InlineData(53, "Cinquenta e três segundos")]
        [InlineData(54, "Cinquenta e quatro segundos")]
        [InlineData(55, "Cinquenta e cinco segundos")]
        [InlineData(56, "Cinquenta e seis segundos")]
        [InlineData(57, "Cinquenta e sete segundos")]
        [InlineData(58, "Cinquenta e oito segundos")]
        [InlineData(59, "Cinquenta e nove segundos")]
        public void Validar_SegundoPorExtenso(int segundosInfomardo, string segundosPorExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddSeconds(segundosInfomardo);

            //act
            var segundosTexto = relogio.Obter_Segundo_Por_Extenso();

            //Assert
            segundosTexto.Should().Be(segundosPorExtenso);

        }

    }
}
