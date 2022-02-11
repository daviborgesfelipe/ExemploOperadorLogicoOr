using System;

namespace ExemploOperadorLogicoOr
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*##### VARIÁVEIS #####*/
            bool resultado;
            bool x;
            bool y;
            /*##### VARIÁVEIS #####*/


            x = 3 > 2;//valor da variavel x é true, pois tres é maior do que dois.
            y = 4 == 4;//valor da variavel y é true pois quatro é igual a quatro.
        
            resultado = x || y;
            //aqui o operador logico or(||) vai verificar se algum operando tem uma das variaveis com o valor true, se sim o resultado da operação logica sera true, somente se ambos operandos possuirem variaveis com o valor false, o resultado sera false. 
            
            Console.WriteLine(resultado);
            //aqui o console exibira o valor que foi atribuido na variavel "resultado", que conforme a operaçao acima, "x" é igual a true, e "y" é igual a true, em seguida o operado logico or (||) verifica se algum operando tem uma das variaveis com o valor true, no caso ambas variaveis possuem valor true, logo o console exibira o resultado da operação como "true".
            
            /*
            x = 6 > 9;//valor da variavel x é false, pois tres é menor do que nove.
            y = 4 == 12;//valor da variavel y é false pois quatro não é igual a dose.
        
            resultado = x || y;
            //aqui o operador logico or(||) vai verificar se algum operando tem uma das variaveis com o valor true, se sim o resultado da operação logica sera true, somente se ambos operandos possuirem variaveis com o valor false, o resultado sera false.
            
            Console.WriteLine(resultado);
            //aqui o console exibira o valor que foi atribuido na variavel "resultado", que conforme a operaçao logica acima, "x" é igual a false, e "y" é igual a false, em seguida o operado logico or (||) verifica se algum operando tem uma das variaveis com o valor true, no caso ambas variaveis possuem valor false, logo o cosole exibira o resultado da operação como "false".
            */
        }
    }
}
