using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc01
{
    /// <summary>
    /// Classe concreta para subtração
    /// </summary>
    public class Subtraction : IOperation
    {
        /// <summary>
        /// Método que realiza a adição
        /// </summary>
        /// <param name="firstNumber">Primeiro número para subtração</param>
        /// <param name="secondNumber">Segundo número para subtração</param>
        /// <returns>Resultado da subtração</returns>
        public double Calculate( double firstNumber, double secondNumber )
        {
            try
            {
                return firstNumber - secondNumber;
            }
            catch ( Exception ex )
            {
                throw new Exception( "Error calculate subtraction", ex );
            }
        }
    }
}
