using LibraryCalc01;
using System;
using Xunit;

namespace LibraryCalc02Tests
{
    [Trait("Lucas", "Lucas")]
    public class AdditionTest
    {
        [Fact(DisplayName = "Sucess Operation")]
        public void SucessOperation( )
        {
            Addition addition = new Addition( );

            double a = 1;
            double b = 2;

            double result = addition.Calculate( a, b );

            Assert.True( ( a + b ) == result );
        }
    }
}
