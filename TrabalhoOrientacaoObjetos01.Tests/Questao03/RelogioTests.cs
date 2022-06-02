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
        [Theory] 
        [InlineData(00,"Zero minutos")]
        [InlineData(01,"Um minuto")]
        [InlineData(02,"Dois minutos")]
        [InlineData(03,"Três minutos")]
        [InlineData(04,"Quatro minutos")]
        [InlineData(05,"Cinco minutos")]
        [InlineData(06,"Seis minutos")]
        [InlineData(07,"Sete minutos")]
        [InlineData(08,"Oito minutos")]
        [InlineData(09,"Nove minutos")]
        [InlineData(10,"Dez minutos")]
        [InlineData(11,"Onze minutos")]
        [InlineData(12,"Doze minutos")]
        [InlineData(13,"Treze minutos")]
        [InlineData(14,"Quatorze minutos")]
        [InlineData(15,"Quinze minutos")]
        [InlineData(16,"Dezesseis minutos")]
        [InlineData(17,"Dezessete minutos")]
        [InlineData(18,"Dezoito minutos")]
        [InlineData(19,"Dezenove minutos")]
        [InlineData(20,"Vinte minutos")]
        [InlineData(21,"Vinte e um minutos")]
        [InlineData(22,"Vinte e dois minutos")]
        [InlineData(23,"Vinte e três minutos")]
        [InlineData(24,"Vinte e quatro minutos")]
        [InlineData(25,"Vinte e cinco minutos")]
        [InlineData(26,"Vinte e seis minutos")]
        [InlineData(27,"Vinte e sete minutos")]
        [InlineData(28,"Vinte e oito minutos")]
        [InlineData(29,"Vinte e nove minutos")]
        [InlineData(30,"Trinta minutos")]
        [InlineData(31,"Trinta e um minutos")]
        [InlineData(32,"Trinta e dois minutos")]
        [InlineData(33,"Trinta e três minutos")]
        [InlineData(34,"Trinta e quatro minutos")]
        [InlineData(35,"Trinta e cinco minutos")]
        [InlineData(36,"Trinta e seis minutos")]
        [InlineData(37,"Trinta e sete minutos")]
        [InlineData(38,"Trinta e oito minutos")]
        [InlineData(39,"Trinta e nove minutos")]
        [InlineData(40,"Quarenta minutos")]
        [InlineData(41,"Quarenta e um minutos")]
        [InlineData(42,"Quarenta e dois minutos")]
        [InlineData(43,"Quarenta e três minutos")]
        [InlineData(44,"Quarenta e quatro minutos")]
        [InlineData(45,"Quarenta e cinco minutos")]
        [InlineData(46,"Quarenta e seis minutos")]
        [InlineData(47,"Quarenta e sete minutos")]
        [InlineData(48,"Quarenta e oito minutos")]
        [InlineData(49,"Quarenta e nove minutos")]
        [InlineData(50,"Cinquenta minutos")]
        [InlineData(51,"Cinquenta e um minutos")]
        [InlineData(52,"Cinquenta e dois minutos")]
        [InlineData(53,"Cinquenta e três minutos")]
        [InlineData(54,"Cinquenta e quatro minutos")]
        [InlineData(55,"Cinquenta e cinco minutos")]
        [InlineData(56,"Cinquenta e seis minutos")]
        [InlineData(57,"Cinquenta e sete minutos")]
        [InlineData(58,"Cinquenta e oito minutos")]
        [InlineData(59,"Cinquenta e nove minutos")]
        
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
    }
}
