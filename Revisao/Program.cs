using System;

namespace Revisao
{

    class Program
    {

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];        // instanciando array com tamanho 5
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();     // vai ler e retornar o que o usuario digitou

            while (opcaoUsuario.ToUpper() != "X")       // 'ToUpper' transforma caracters minusculos em maiusculos
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno();      // intanciando um objeto do tipo Aluno, 'var' é um referecia de tipo
                        aluno.Nome = Console.ReadLine();        // ja seta o nome que o usuario informa no 'Console'

                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))        // convertendo 'ReadLine' string para decimal e fazendo a declaracao da variavel 'nota'
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;        // 'aluno' instanciado inserido no array em posicao
                        indiceAluno++;      // no proximo 'aluno' inserido ele vai para a proxima posicao

                        break;

                    case "2":
                        foreach(var a in alunos)        // para cada 'a'(aluno) em 'alunos(array) imprime uma linha passando o nome e a nota do aluno
                        {
                            if (!string.IsNullOrEmpty(a.Nome))     // se o nome não for nulo ou vazio o nome e a nota do aluno cadastrado sera impressa
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;      // 'decimal' esta explicitando que nota é decimal
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;     // faz a soma da nota do aluno atual com a nota do aluno anterior assim sucessivamente
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;     // 'Conceito' é o enum

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }

                        if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }

                        if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }


                        Console.WriteLine($"Media geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();     // metodo extraido

            }
        }

        private static string ObterOpcaoUsuario()       // metodo "menu"
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral ");
            Console.WriteLine("X - Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}