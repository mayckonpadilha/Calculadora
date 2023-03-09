using System;

namespace CalculadoraConsoleApp
{
    //Requisito 01
    //Nossa calculadora deve ter a possibilidade de somar dois números

    //Requisito 02
    //Nossa calculadora deve ter a possibilidade fazer várias operações de soma

    //Requisito 03
    //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

    //Requisito 04
    //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática

    //Requisito 05
    //Nossa calculadora deve realizar as operações com "0"

    //Requisito 06
    //Nossa calculadora deve validar a opções do menu 

    //Requisito 07
    //Nossa calculadora deve realizar as operações com números com duas casas decimais

    class Program
    {
        static void Main(string[] args)

        {

            do
            {

                Console.Clear();

                Console.WriteLine("Calculadora");

                Console.WriteLine("Digite 1 para Adcionar");
                Console.WriteLine("Digite 2 para Subtair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                String operacao = Console.ReadLine();

                if(operacao == "s" || operacao == "S")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao  != "3" && operacao != "4" && operacao  != "s" && operacao != "S")
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine();
                Console.WriteLine("Digite o primeiro numero: ");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Digite o segundo numero: ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehSubtrair = operacao == "2";
                bool ehMultiplicacao = operacao == "3";
                bool ehDivisao = operacao == "4";

                    if (ehAdicao)
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                    else if (ehSubtrair)
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                    else if (ehMultiplicacao)
                {
                    resultado = primeiroNumero * segundoNumero;
                }


                    else if (ehDivisao)
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número não poder ser Zero, tente novamente.");
                        Console.ReadLine();
                        Console.WriteLine("Digite o Segundo número: ");
                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;

                }
                decimal resultadoFormatado = Math.Round(resultado,2);
                Console.WriteLine("O resultado da operação é: " + resultadoFormatado);
                Console.ReadLine();


        } while (true);

        }
    } 
}

