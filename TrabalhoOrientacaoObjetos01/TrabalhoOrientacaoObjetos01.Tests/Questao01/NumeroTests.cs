using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao01;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao01
{
    public class NumeroTests
    {
        [Theory]
        [InlineData(0, "Zero.")]
        [InlineData(0.0, "Zero.")]
        [InlineData(0.00, "Zero.")]
        [InlineData(0.01, "Zero um.")]
        [InlineData(0.02, "Zero dois.")]
        [InlineData(0.03, "Zero três.")]
        [InlineData(0.04, "Zero quatro.")]
        [InlineData(0.05, "Zero cinco.")]
        [InlineData(0.06, "Zero seis.")]
        [InlineData(0.07, "Zero sete.")]
        [InlineData(0.08, "Zero oito.")]
        [InlineData(0.09, "Zero nove.")]
        [InlineData(0.1, "Dez.")]
        [InlineData(0.10, "Dez.")]
        [InlineData(0.11, "Onze.")]
        [InlineData(0.12, "Doze.")]
        [InlineData(0.13, "Treze.")]
        [InlineData(0.14, "Quatorze.")]
        [InlineData(0.15, "Quinze.")]
        [InlineData(0.16, "Dezesseis.")]
        [InlineData(0.17, "Dezessete.")]
        [InlineData(0.18, "Dezoito.")]
        [InlineData(0.19, "Dezenove.")]
        [InlineData(0.2, "Vinte.")]
        [InlineData(0.20, "Vinte.")]
        [InlineData(0.21, "Vinte e um.")]
        [InlineData(0.22, "Vinte e dois.")]
        [InlineData(0.23, "Vinte e três.")]
        [InlineData(0.24, "Vinte e quatro.")]
        [InlineData(0.25, "Vinte e cinco.")]
        [InlineData(0.26, "Vinte e seis.")]
        [InlineData(0.27, "Vinte e sete.")]
        [InlineData(0.28, "Vinte e oito.")]
        [InlineData(0.29, "Vinte e nove.")]
        [InlineData(0.3, "Trinta.")]
        [InlineData(0.30, "Trinta.")]
        [InlineData(0.31, "Trinta e um.")]
        [InlineData(0.32, "Trinta e dois.")]
        [InlineData(0.33, "Trinta e três.")]
        [InlineData(0.34, "Trinta e quatro.")]
        [InlineData(0.35, "Trinta e cinco.")]
        [InlineData(0.36, "Trinta e seis.")]
        [InlineData(0.37, "Trinta e sete.")]
        [InlineData(0.38, "Trinta e oito.")]
        [InlineData(0.39, "Trinta e nove.")]
        [InlineData(0.4, "Quarenta.")]
        [InlineData(0.40, "Quarenta.")]
        [InlineData(0.41, "Quarenta e um.")]
        [InlineData(0.42, "Quarenta e dois.")]
        [InlineData(0.43, "Quarenta e três.")]
        [InlineData(0.44, "Quarenta e quatro.")]
        [InlineData(0.45, "Quarenta e cinco.")]
        [InlineData(0.46, "Quarenta e seis.")]
        [InlineData(0.47, "Quarenta e sete.")]
        [InlineData(0.48, "Quarenta e oito.")]
        [InlineData(0.49, "Quarenta e nove.")]
        [InlineData(0.5, "Cinquenta.")]
        [InlineData(0.50, "Cinquenta.")]
        [InlineData(0.51, "Cinquenta e um.")]
        [InlineData(0.52, "Cinquenta e dois.")]
        [InlineData(0.53, "Cinquenta e três.")]
        [InlineData(0.54, "Cinquenta e quatro.")]
        [InlineData(0.55, "Cinquenta e cinco.")]
        [InlineData(0.56, "Cinquenta e seis.")]
        [InlineData(0.57, "Cinquenta e sete.")]
        [InlineData(0.58, "Cinquenta e oito.")]
        [InlineData(0.59, "Cinquenta e nove.")]
        [InlineData(0.6, "Sessenta.")]
        [InlineData(0.60, "Sessenta.")]
        [InlineData(0.61, "Sessenta e um.")]
        [InlineData(0.62, "Sessenta e dois.")]
        [InlineData(0.63, "Sessenta e três.")]
        [InlineData(0.64, "Sessenta e quatro.")]
        [InlineData(0.65, "Sessenta e cinco.")]
        [InlineData(0.66, "Sessenta e seis.")]
        [InlineData(0.67, "Sessenta e sete.")]
        [InlineData(0.68, "Sessenta e oito.")]
        [InlineData(0.69, "Sessenta e nove.")]
        [InlineData(0.7, "Setenta.")]
        [InlineData(0.70, "Setenta.")]
        [InlineData(0.71, "Setenta e um.")]
        [InlineData(0.72, "Setenta e dois.")]
        [InlineData(0.73, "Setenta e três.")]
        [InlineData(0.74, "Setenta e quatro.")]
        [InlineData(0.75, "Setenta e cinco.")]
        [InlineData(0.76, "Setenta e seis.")]
        [InlineData(0.77, "Setenta e sete.")]
        [InlineData(0.78, "Setenta e oito.")]
        [InlineData(0.79, "Setenta e nove.")]
        [InlineData(0.8, "Oitenta.")]
        [InlineData(0.80, "Oitenta.")]
        [InlineData(0.81, "Oitenta e um.")]
        [InlineData(0.82, "Oitenta e dois.")]
        [InlineData(0.83, "Oitenta e três.")]
        [InlineData(0.84, "Oitenta e quatro.")]
        [InlineData(0.85, "Oitenta e cinco.")]
        [InlineData(0.86, "Oitenta e seis.")]
        [InlineData(0.87, "Oitenta e sete.")]
        [InlineData(0.88, "Oitenta e oito.")]
        [InlineData(0.89, "Oitenta e nove.")]
        [InlineData(0.9, "Noventa.")]
        [InlineData(0.90, "Noventa.")]
        [InlineData(0.91, "Noventa e um.")]
        [InlineData(0.92, "Noventa e dois.")]
        [InlineData(0.93, "Noventa e três.")]
        [InlineData(0.94, "Noventa e quatro.")]
        [InlineData(0.95, "Noventa e cinco.")]
        [InlineData(0.96, "Noventa e seis.")]
        [InlineData(0.97, "Noventa e sete.")]
        [InlineData(0.98, "Noventa e oito.")]
        [InlineData(0.99, "Noventa e nove.")]
        public void Cenario01_Validar_ObterDecimalPorExtenso(double numeroInformado,string numeroDecimalPorExtenso)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = numeroInformado;

            // Act
            var numeroPorExtenso = numero.ObterDecimalPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(numeroDecimalPorExtenso);
        }

        [Theory]
        [InlineData(0, "Zero.")]
        [InlineData(0.5, "Zero.")]
        [InlineData(1, "Um.")]
        [InlineData(1.5, "Um.")]
        [InlineData(2, "Dois.")]
        [InlineData(2.5, "Dois.")]
        [InlineData(3, "Três.")]
        [InlineData(3.5, "Três.")]
        [InlineData(4, "Quatro.")]
        [InlineData(4.5, "Quatro.")]
        [InlineData(5, "Cinco.")]
        [InlineData(5.5, "Cinco.")]
        [InlineData(6, "Seis.")]
        [InlineData(6.5, "Seis.")]
        [InlineData(7, "Sete.")]
        [InlineData(7.5, "Sete.")]
        [InlineData(8, "Oito.")]
        [InlineData(8.5, "Oito.")]
        [InlineData(9, "Nove.")]
        [InlineData(9.5, "Nove.")]
        public void Cenario02_Validar_ObterUnidadePorExtenso(double numeroInformado, string unidadePorExtenso)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = numeroInformado;

            // Act
            var numeroPorExtenso = numero.ObterUnidadePorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(unidadePorExtenso);
        }
    }
}
