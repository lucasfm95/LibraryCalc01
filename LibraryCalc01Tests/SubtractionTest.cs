using LibraryCalc01;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryCalc02Tests
{
    public class SubtractionTest
    {
        [Fact(DisplayName = "Sucess Operation")]
        public void SucessOperation( )
        {
            Subtraction subtraction = new Subtraction( );

            double a = 1;
            double b = 2;

            double result = subtraction.Calculate( a, b );

            Assert.True( ( a - b ) == result );
        }
    }
}
