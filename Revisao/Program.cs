using System;

namespace Revisao
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral ");
            Console.WriteLine("X - Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();     // vai lere retornar o que o usuario digitou

            while (opcaoUsuario.ToUpper() != "X")       // 'ToUpper' transforma caracters minusculos em maiusculos
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar novo aluno
                        break;

                    case "2":
                        //TODO: listar alunos
                        break;

                    case "3":
                        //TODO: calcular media geral
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                 Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular media geral ");
                Console.WriteLine("X - Sair ");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();     

            }
        }
    }
}