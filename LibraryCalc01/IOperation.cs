using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc01
{
    /// <summary>
    /// Interface que define o contrato para cada operação
    /// </summary>
    public interface IOperation
    {
        double Calculate( double firstNumber, double secondNumber );
    }
}
