using LibraryCalc01;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryCalc02Tests
{
    public class MultiplicationTest
    {
        [Fact(DisplayName = "Sucess Operation")]
        public void SucessOperation( )
        {
            Multiplication multiplication = new Multiplication( );

            double a = 1;
            double b = 2;

            double result = multiplication.Calculate( a, b );

            Assert.True( ( a * b ) == result );
        }
    }
}
