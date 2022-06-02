using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao03
{
    public class RelogioTests
    {

        [Theory]
        [InlineData(01,"Uma hora")]
        [InlineData(02,"Duas horas")]
        [InlineData(0,3)]
        [InlineData(0,4)]
        [InlineData(0,4)]
        [InlineData(0,5)]
        [InlineData(0,6)]
        [InlineData(0,7)]
        [InlineData(0,8)]
        [InlineData(0,9)]
        [InlineData(1,0)]
        [InlineData(1,1)]
        [InlineData(1,2)]
        [InlineData(1,3)]
        [InlineData(1,4)]
        [InlineData(1,4)]
        [InlineData(1,5)]
        [InlineData(1,6)]
        [InlineData(1,7)]
        [InlineData(1,8)]
        [InlineData(1,9)]
        [InlineData(2,0)]
        [InlineData(2,1)]
        [InlineData(2,1)]
        [InlineData(2,2)]
        [InlineData(2,3)]
        

    }
}
