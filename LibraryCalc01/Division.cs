using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc01
{
    /// <summary>
    /// Classe concreta para divisão
    /// </summary>
    public class Division : IOperation
    {
        /// <summary>
        /// Método que realiza a divisão
        /// </summary>
        /// <param name="firstNumber">Primeiro número para divisão</param>
        /// <param name="secondNumber">Segundo número para divisão</param>
        /// <returns>Resultado da divisão</returns>
        public double Calculate( double firstNumber, double secondNumber )
        {
            try
            {
                if ( firstNumber == 0 || secondNumber == 0 )
                {
                    throw new Exception( );
                }
                return (firstNumber / secondNumber);
            }
            catch ( Exception ex)
            {
                throw new Exception( "Error calculate division", ex );
            }
        }
    }
}
