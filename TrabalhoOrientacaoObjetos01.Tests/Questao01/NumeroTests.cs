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
    // Gregory Viegas Zimmer
    public class NumeroTests
    {
        [Theory]
        [InlineData(0, "Zero")]
        [InlineData(0.0, "Zero")]
        [InlineData(0.00, "Zero")]
        [InlineData(0.01, "Um")]
        [InlineData(0.02, "Dois")]
        [InlineData(0.03, "Três")]
        [InlineData(0.04, "Quatro")]
        [InlineData(0.05, "Cinco")]
        [InlineData(0.06, "Seis")]
        [InlineData(0.07, "Sete")]
        [InlineData(0.08, "Oito")]
        [InlineData(0.09, "Nove")]
        [InlineData(0.1, "Dez")]
        [InlineData(0.10, "Dez")]
        [InlineData(0.11, "Onze")]
        [InlineData(0.12, "Doze")]
        [InlineData(0.13, "Treze")]
        [InlineData(0.14, "Quatorze")]
        [InlineData(0.15, "Quinze")]
        [InlineData(0.16, "Dezesseis")]
        [InlineData(0.17, "Dezessete")]
        [InlineData(0.18, "Dezoito")]
        [InlineData(0.19, "Dezenove")]
        [InlineData(0.2, "Vinte")]
        [InlineData(0.20, "Vinte")]
        [InlineData(0.21, "Vinte e um")]
        [InlineData(0.22, "Vinte e dois")]
        [InlineData(0.23, "Vinte e três")]
        [InlineData(0.24, "Vinte e quatro")]
        [InlineData(0.25, "Vinte e cinco")]
        [InlineData(0.26, "Vinte e seis")]
        [InlineData(0.27, "Vinte e sete")]
        [InlineData(0.28, "Vinte e oito")]
        [InlineData(0.29, "Vinte e nove")]
        [InlineData(0.3, "Trinta")]
        [InlineData(0.30, "Trinta")]
        [InlineData(0.31, "Trinta e um")]
        [InlineData(0.32, "Trinta e dois")]
        [InlineData(0.33, "Trinta e três")]
        [InlineData(0.34, "Trinta e quatro")]
        [InlineData(0.35, "Trinta e cinco")]
        [InlineData(0.36, "Trinta e seis")]
        [InlineData(0.37, "Trinta e sete")]
        [InlineData(0.38, "Trinta e oito")]
        [InlineData(0.39, "Trinta e nove")]
        [InlineData(0.4, "Quarenta")]
        [InlineData(0.40, "Quarenta")]
        [InlineData(0.41, "Quarenta e um")]
        [InlineData(0.42, "Quarenta e dois")]
        [InlineData(0.43, "Quarenta e três")]
        [InlineData(0.44, "Quarenta e quatro")]
        [InlineData(0.45, "Quarenta e cinco")]
        [InlineData(0.46, "Quarenta e seis")]
        [InlineData(0.47, "Quarenta e sete")]
        [InlineData(0.48, "Quarenta e oito")]
        [InlineData(0.49, "Quarenta e nove")]
        [InlineData(0.5, "Cinquenta")]
        [InlineData(0.50, "Cinquenta")]
        [InlineData(0.51, "Cinquenta e um")]
        [InlineData(0.52, "Cinquenta e dois")]
        [InlineData(0.53, "Cinquenta e três")]
        [InlineData(0.54, "Cinquenta e quatro")]
        [InlineData(0.55, "Cinquenta e cinco")]
        [InlineData(0.56, "Cinquenta e seis")]
        [InlineData(0.57, "Cinquenta e sete")]
        [InlineData(0.58, "Cinquenta e oito")]
        [InlineData(0.59, "Cinquenta e nove")]
        [InlineData(0.6, "Sessenta")]
        [InlineData(0.60, "Sessenta")]
        [InlineData(0.61, "Sessenta e um")]
        [InlineData(0.62, "Sessenta e dois")]
        [InlineData(0.63, "Sessenta e três")]
        [InlineData(0.64, "Sessenta e quatro")]
        [InlineData(0.65, "Sessenta e cinco")]
        [InlineData(0.66, "Sessenta e seis")]
        [InlineData(0.67, "Sessenta e sete")]
        [InlineData(0.68, "Sessenta e oito")]
        [InlineData(0.69, "Sessenta e nove")]
        [InlineData(0.7, "Setenta")]
        [InlineData(0.70, "Setenta")]
        [InlineData(0.71, "Setenta e um")]
        [InlineData(0.72, "Setenta e dois")]
        [InlineData(0.73, "Setenta e três")]
        [InlineData(0.74, "Setenta e quatro")]
        [InlineData(0.75, "Setenta e cinco")]
        [InlineData(0.76, "Setenta e seis")]
        [InlineData(0.77, "Setenta e sete")]
        [InlineData(0.78, "Setenta e oito")]
        [InlineData(0.79, "Setenta e nove")]
        [InlineData(0.8, "Oitenta")]
        [InlineData(0.80, "Oitenta")]
        [InlineData(0.81, "Oitenta e um")]
        [InlineData(0.82, "Oitenta e dois")]
        [InlineData(0.83, "Oitenta e três")]
        [InlineData(0.84, "Oitenta e quatro")]
        [InlineData(0.85, "Oitenta e cinco")]
        [InlineData(0.86, "Oitenta e seis")]
        [InlineData(0.87, "Oitenta e sete")]
        [InlineData(0.88, "Oitenta e oito")]
        [InlineData(0.89, "Oitenta e nove")]
        [InlineData(0.9, "Noventa")]
        [InlineData(0.90, "Noventa")]
        [InlineData(0.91, "Noventa e um")]
        [InlineData(0.92, "Noventa e dois")]
        [InlineData(0.93, "Noventa e três")]
        [InlineData(0.94, "Noventa e quatro")]
        [InlineData(0.95, "Noventa e cinco")]
        [InlineData(0.96, "Noventa e seis")]
        [InlineData(0.97, "Noventa e sete")]
        [InlineData(0.98, "Noventa e oito")]
        [InlineData(0.99, "Noventa e nove")]
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
        [InlineData(0, "Zero")]
        [InlineData(0.5, "Zero")]
        [InlineData(1, "Um")]
        [InlineData(1.5, "Um")]
        [InlineData(2, "Dois")]
        [InlineData(2.5, "Dois")]
        [InlineData(3, "Três")]
        [InlineData(3.5, "Três")]
        [InlineData(4, "Quatro")]
        [InlineData(4.5, "Quatro")]
        [InlineData(5, "Cinco")]
        [InlineData(5.5, "Cinco")]
        [InlineData(6, "Seis")]
        [InlineData(6.5, "Seis")]
        [InlineData(7, "Sete")]
        [InlineData(7.5, "Sete")]
        [InlineData(8, "Oito")]
        [InlineData(8.5, "Oito")]
        [InlineData(9, "Nove")]
        [InlineData(9.5, "Nove")]
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

        [Theory]
        [InlineData(0, "Zero")]
        [InlineData(0.5, "Zero")]
        [InlineData(1, "Zero")]
        [InlineData(1.5, "Zero")]
        [InlineData(2, "Zero")]
        [InlineData(2.5, "Zero")]
        [InlineData(3, "Zero")]
        [InlineData(3.5, "Zero")]
        [InlineData(4, "Zero")]
        [InlineData(4.5, "Zero")]
        [InlineData(5, "Zero")]
        [InlineData(5.5, "Zero")]
        [InlineData(6, "Zero")]
        [InlineData(6.5, "Zero")]
        [InlineData(7, "Zero")]
        [InlineData(7.5, "Zero")]
        [InlineData(8, "Zero")]
        [InlineData(8.5, "Zero")]
        [InlineData(9, "Zero")]
        [InlineData(9.5, "Zero")]
        [InlineData(10, "Dez")]
        [InlineData(10.5, "Dez")]
        [InlineData(11, "Dez")]
        [InlineData(11.5, "Dez")]
        [InlineData(12, "Dez")]
        [InlineData(12.5, "Dez")]
        [InlineData(13, "Dez")]
        [InlineData(13.5, "Dez")]
        [InlineData(14, "Dez")]
        [InlineData(14.5, "Dez")]
        [InlineData(15, "Dez")]
        [InlineData(15.5, "Dez")]
        [InlineData(16, "Dez")]
        [InlineData(16.5, "Dez")]
        [InlineData(17, "Dez")]
        [InlineData(17.5, "Dez")]
        [InlineData(18, "Dez")]
        [InlineData(18.5, "Dez")]
        [InlineData(19, "Dez")]
        [InlineData(19.5, "Dez")]
        [InlineData(20, "Vinte")]
        [InlineData(20.5, "Vinte")]
        [InlineData(21, "Vinte")]
        [InlineData(21.5, "Vinte")]
        [InlineData(22, "Vinte")]
        [InlineData(22.5, "Vinte")]
        [InlineData(23, "Vinte")]
        [InlineData(23.5, "Vinte")]
        [InlineData(24, "Vinte")]
        [InlineData(24.5, "Vinte")]
        [InlineData(25, "Vinte")]
        [InlineData(25.5, "Vinte")]
        [InlineData(26, "Vinte")]
        [InlineData(26.5, "Vinte")]
        [InlineData(27, "Vinte")]
        [InlineData(27.5, "Vinte")]
        [InlineData(28, "Vinte")]
        [InlineData(28.5, "Vinte")]
        [InlineData(29, "Vinte")]
        [InlineData(29.5, "Vinte")]
        [InlineData(30, "Trinta")]
        [InlineData(30.5, "Trinta")]
        [InlineData(31, "Trinta")]
        [InlineData(31.5, "Trinta")]
        [InlineData(32, "Trinta")]
        [InlineData(32.5, "Trinta")]
        [InlineData(33, "Trinta")]
        [InlineData(33.5, "Trinta")]
        [InlineData(34, "Trinta")]
        [InlineData(34.5, "Trinta")]
        [InlineData(35, "Trinta")]
        [InlineData(35.5, "Trinta")]
        [InlineData(36, "Trinta")]
        [InlineData(36.5, "Trinta")]
        [InlineData(37, "Trinta")]
        [InlineData(37.5, "Trinta")]
        [InlineData(38, "Trinta")]
        [InlineData(38.5, "Trinta")]
        [InlineData(39, "Trinta")]
        [InlineData(39.5, "Trinta")]
        [InlineData(40, "Quarenta")]
        [InlineData(40.5, "Quarenta")]
        [InlineData(41, "Quarenta")]
        [InlineData(41.5, "Quarenta")]
        [InlineData(42, "Quarenta")]
        [InlineData(42.5, "Quarenta")]
        [InlineData(43, "Quarenta")]
        [InlineData(43.5, "Quarenta")]
        [InlineData(44, "Quarenta")]
        [InlineData(44.5, "Quarenta")]
        [InlineData(45, "Quarenta")]
        [InlineData(45.5, "Quarenta")]
        [InlineData(46, "Quarenta")]
        [InlineData(46.5, "Quarenta")]
        [InlineData(47, "Quarenta")]
        [InlineData(47.5, "Quarenta")]
        [InlineData(48, "Quarenta")]
        [InlineData(48.5, "Quarenta")]
        [InlineData(49, "Quarenta")]
        [InlineData(49.5, "Quarenta")]
        [InlineData(50, "Cinquenta")]
        [InlineData(50.5, "Cinquenta")]
        [InlineData(51, "Cinquenta")]
        [InlineData(51.5, "Cinquenta")]
        [InlineData(52, "Cinquenta")]
        [InlineData(52.5, "Cinquenta")]
        [InlineData(53, "Cinquenta")]
        [InlineData(53.5, "Cinquenta")]
        [InlineData(54, "Cinquenta")]
        [InlineData(54.5, "Cinquenta")]
        [InlineData(55, "Cinquenta")]
        [InlineData(55.5, "Cinquenta")]
        [InlineData(56, "Cinquenta")]
        [InlineData(56.5, "Cinquenta")]
        [InlineData(57, "Cinquenta")]
        [InlineData(57.5, "Cinquenta")]
        [InlineData(58, "Cinquenta")]
        [InlineData(58.5, "Cinquenta")]
        [InlineData(59, "Cinquenta")]
        [InlineData(59.5, "Cinquenta")]
        [InlineData(60, "Sessenta")]
        [InlineData(60.5, "Sessenta")]
        [InlineData(61, "Sessenta")]
        [InlineData(61.5, "Sessenta")]
        [InlineData(62, "Sessenta")]
        [InlineData(62.5, "Sessenta")]
        [InlineData(63, "Sessenta")]
        [InlineData(63.5, "Sessenta")]
        [InlineData(64, "Sessenta")]
        [InlineData(64.5, "Sessenta")]
        [InlineData(65, "Sessenta")]
        [InlineData(65.5, "Sessenta")]
        [InlineData(66, "Sessenta")]
        [InlineData(66.5, "Sessenta")]
        [InlineData(67, "Sessenta")]
        [InlineData(67.5, "Sessenta")]
        [InlineData(68, "Sessenta")]
        [InlineData(68.5, "Sessenta")]
        [InlineData(69, "Sessenta")]
        [InlineData(69.5, "Sessenta")]
        [InlineData(70, "Setenta")]
        [InlineData(70.5, "Setenta")]
        [InlineData(71, "Setenta")]
        [InlineData(71.5, "Setenta")]
        [InlineData(72, "Setenta")]
        [InlineData(72.5, "Setenta")]
        [InlineData(73, "Setenta")]
        [InlineData(73.5, "Setenta")]
        [InlineData(74, "Setenta")]
        [InlineData(74.5, "Setenta")]
        [InlineData(75, "Setenta")]
        [InlineData(75.5, "Setenta")]
        [InlineData(76, "Setenta")]
        [InlineData(76.5, "Setenta")]
        [InlineData(77, "Setenta")]
        [InlineData(77.5, "Setenta")]
        [InlineData(78, "Setenta")]
        [InlineData(78.5, "Setenta")]
        [InlineData(79, "Setenta")]
        [InlineData(79.5, "Setenta")]
        [InlineData(80, "Oitenta")]
        [InlineData(80.5, "Oitenta")]
        [InlineData(81, "Oitenta")]
        [InlineData(81.5, "Oitenta")]
        [InlineData(82, "Oitenta")]
        [InlineData(82.5, "Oitenta")]
        [InlineData(83, "Oitenta")]
        [InlineData(83.5, "Oitenta")]
        [InlineData(84, "Oitenta")]
        [InlineData(84.5, "Oitenta")]
        [InlineData(85, "Oitenta")]
        [InlineData(85.5, "Oitenta")]
        [InlineData(86, "Oitenta")]
        [InlineData(86.5, "Oitenta")]
        [InlineData(87, "Oitenta")]
        [InlineData(87.5, "Oitenta")]
        [InlineData(88, "Oitenta")]
        [InlineData(88.5, "Oitenta")]
        [InlineData(89, "Oitenta")]
        [InlineData(89.5, "Oitenta")]
        [InlineData(90, "Noventa")]
        [InlineData(90.5, "Noventa")]
        [InlineData(91, "Noventa")]
        [InlineData(91.5, "Noventa")]
        [InlineData(92, "Noventa")]
        [InlineData(92.5, "Noventa")]
        [InlineData(93, "Noventa")]
        [InlineData(93.5, "Noventa")]
        [InlineData(94, "Noventa")]
        [InlineData(94.5, "Noventa")]
        [InlineData(95, "Noventa")]
        [InlineData(95.5, "Noventa")]
        [InlineData(96, "Noventa")]
        [InlineData(96.5, "Noventa")]
        [InlineData(97, "Noventa")]
        [InlineData(97.5, "Noventa")]
        [InlineData(98, "Noventa")]
        [InlineData(98.5, "Noventa")]
        [InlineData(99, "Noventa")]
        [InlineData(99.5, "Noventa")]
        public void Cenario03_Validar_ObterDezenaPorExtenso(double numeroInformado, string dezenaPorExtenso)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = numeroInformado;

            // Act
            var numeroPorExtenso = numero.ObterDezenaPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(dezenaPorExtenso);
        }

        [Theory]
        [InlineData(59, "Zero")]
        [InlineData(112, "Cem")]
        [InlineData(207, "Duzentos")]
        [InlineData(361, "Trezentos")]
        [InlineData(482, "Quatrocentos")]
        [InlineData(509, "Quinhentos")]
        [InlineData(622, "Seissentos")]
        [InlineData(794, "Setessentos")]
        [InlineData(811, "Oitocentos")]
        [InlineData(903, "Novecentos")]
        public void Cenario04_Validar_ObterCentenaPorExtenso(double numeroInformado, string centenaPorExtenso)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = numeroInformado;

            // Act
            var numeroPorExtenso = numero.ObterCentenaPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(centenaPorExtenso);
        }

        [Theory]
        [InlineData(759, "Zero")]
        [InlineData(1112, "Mil")]
        [InlineData(2207, "Dois mil")]
        [InlineData(3361, "Três mil")]
        [InlineData(4482, "Quatro mil")]
        [InlineData(5509, "Cinco mil")]
        [InlineData(6622, "Seis mil")]
        [InlineData(7794, "Sete mil")]
        [InlineData(8811, "Oito mil")]
        [InlineData(9903, "Nove mil")]
        public void Cenario05_Validar_ObterUnidadeDeMilharPorExtenso(double numeroInformado, string milharPorExtenso)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = numeroInformado;

            // Act
            var numeroPorExtenso = numero.ObterUnidadeDeMilharPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(milharPorExtenso);
        }

        [Theory]
        [InlineData(0.45, "Quarenta e cinco centavo(s)")]
        [InlineData(8.14, "Oito real(is) e Quatorze centavo(s)")]
        [InlineData(40, "Quarenta real(is)")]
        [InlineData(236.15, "Duzentos e Trinta e Seis real(is) e Quinze centavo(s)")]
        [InlineData(1687, "Mil Seissentos e Oitenta e Sete real(is)")]
        public void Cenario06_Validar_ObterNumeroCompletoPorExtenso(double numeroInformado, string numeroPorExtensoEsperado)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = numeroInformado;

            // Act
            var numeroPorExtenso = numero.ObterNumeroCompletoPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(numeroPorExtensoEsperado);
        }
    }
}