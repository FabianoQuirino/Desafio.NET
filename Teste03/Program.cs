namespace Teste03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Teste 03");
            bool continuar = true;

            while (continuar == true)
            {
                Console.WriteLine("Informe o Nome do Aluno:");
                string nomeDoAluno = Console.ReadLine();
                Console.WriteLine("Qual Foi a Nota do Primeiro Semestre Do Aluno " + nomeDoAluno + "?");
                float notaPrimeiroSemestre = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual Foi a Nota do Segundo Semestre Do Aluno " + nomeDoAluno + "?");
                float notaSegundoSemestre = float.Parse(Console.ReadLine());
                float media = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
                Console.WriteLine("Nome do Aluno: " + nomeDoAluno);
                Console.WriteLine("Média: " + media);

                if (media >= 6.5)
                {
                    Console.WriteLine("O Aluno foi: Aprovado");
                }
                else
                {
                    Console.WriteLine("O Aluno foi: Reprovado");
                }
                Console.WriteLine();
            }
        }
    }
}