# LibraryCalc01
Bilioteca de operações matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/ff0da62j1kj6y2u3/branch/master?svg=true)](https://ci.appveyor.com/project/lucasfm95/librarycalc01/branch/master)

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc00.svg)

## How to install
Install-Package LibraryCalc01 -Version 1.0.2


```cs
using System;

namespace Calculate
{
    class Program
    {
        static void Main( string[] args )
        {
            var result = new LibraryCalc01.Addition( ).Calculate( 1, 2, 3, 4, 5, 5, 6, 8, 9, 10, 11 );

            Console.WriteLine( result );
        }
    }
}
```
