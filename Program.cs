using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {

        static double num1, num2;

        static void Main(string[] args)
        {

            Console.WriteLine("Sistema de cáculadora simples");
            Console.WriteLine("=============================");

            Console.WriteLine("");
            Console.Write("Insira o primeiro número: ");
            num1 = double.Parse (Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            num2 = double.Parse (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Opções:\n1- Soma\n2- Subtração\n3- Divisão\n4- Multiplicação");
            Console.Write("O que deseja fazer?: ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {

                double   res = num1 + num2;
                Console.WriteLine($"Claro! Aqui está a soma entre os números {num1} + {num2}: {res}");
                Console.WriteLine("\nSoma concluída, voltando a tela inicial...");
                Console.WriteLine("============================================");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }

            if (escolha == "2")
            {

                double res = num1 - num2;
                Console.WriteLine($"Claro! Aqui está a subtração entre os números {num1} - {num2}: {res}");
                Console.WriteLine("\nSubtração concluída, voltando a tela inicial...");
                Console.WriteLine("=================================================");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }

            if (escolha == "3")
            {

                double res = num1 / num2;
                Console.WriteLine($"Claro! Aqui está a divisão entre os números {num1} / {num2}: {res}");
                Console.WriteLine("\nDivisão concluída, voltando a tela inicial...");
                Console.WriteLine("===============================================");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }

            if (escolha == "4")
            {

                double res = num1 * num2;
                Console.WriteLine($"Claro! Aqui está a multiplicação entre os números {num1} * {num2}: {res}");
                Console.WriteLine("\nMultiplicação concluída, voltando a tela inicial...");
                Console.WriteLine("=====================================================");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }

            else
            {

                Console.WriteLine("OPÇÃO INVÁLIDA! ESCOLHA UMA OPÇÃO DE CÁLCULO VÁLIDA!!!");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }
        }
    }
}
