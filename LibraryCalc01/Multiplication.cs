using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc01
{
    /// <summary>
    /// Classe concreta para multiplicação
    /// </summary>
    public class Multiplication : IOperation
    {
        /// <summary>
        /// Método que realiza a multiplicação
        /// </summary>
        /// <param name="firstNumber">Primeiro número para multiplicação</param>
        /// <param name="secondNumber">Segundo número para multiplicação</param>
        /// <returns>Resultado da multiplicação</returns>
        public double Calculate( double firstNumber, double secondNumber )
        {
            try
            {
                return firstNumber * secondNumber;
            }
            catch ( Exception ex )
            {
                throw new Exception( "Error calculate multiplication", ex );
            }
        }
    }
}
