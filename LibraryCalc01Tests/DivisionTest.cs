using LibraryCalc01;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryCalc02Tests
{
    public class DivisionTest
    {
        [Theory(DisplayName = "Sucess Operation")]
        [InlineData( 1, 2 )]
        public void SucessOperation( double a, double b )
        {
            Division division = new Division( );

            double result = division.Calculate( a, b );

            Assert.True( ( a / b ) == result );
        }

        [Theory( DisplayName = "Try Operation" )]
        [InlineData( 5.0, 0.0 )]
        public void TryOperation( double a, double b )
        {
            Division division = new Division( );

            var ex = Record.Exception( ( ) => division.Calculate( a, b ) );

            Assert.IsType( typeof( Exception ), ex );

            Assert.True( ex.Message.Contains( "Error calculate division" ) );
        }
    }
}
