using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()       // declaracoes locais (dentro de um metodo)
        {                   
            int a;              
            int b = 2, c = 3;           // declaracao de variaveis em uma linha
            const int d = 4;        // declaracao de constante de valor inteiro, nao pode ser alterada
            a = 1;              // atribuicao de valor 1 a variavel 'a'
            Console.WriteLine(a + b + c + d);
        }

        static void IntrucaoIf(string[] args)       // instrucao condicional
        {
            if (args.Lenght == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Lenght == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Lenght} argumenrros");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Lenght;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;          // apos a impressão do 'Console' o 'break' encerra o 'swith'
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void IntrucaoWhile(string[] args)        // intrucao de repeticao (enquanto)
        {
            int i = 0;
            while (i < args.Lenght)
            {
                Console.WriteLine(args [i]);
                i++;
            }
        }

        static void IntrucaoDo(string[] args)       // intrucao de repeticao, faz a verificacao no final
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)     // intrucao de repeticao 
        {
            for (int i = 0; i < args.Lenght; i++)       // executa de acordo com estas regras
            {
                Console.WriteLine(args[i]);
            }
        }

        static void Instrucaoforeach(string[] args)     // intrucao de repeticao
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true)        // loop infinito
            {
                string s = Console.ReadLine();      // le a string 's' 

                if (string.IsNullOrEmpty(s));       // condição de para se 's' for falso ou fazio 
                    break;

                Console.WriteLine(s);
            }
        }
    }
}