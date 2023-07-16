namespace Teste02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeProvas = 1;
            float totalDeNota = 0;
            bool continuar = true;
            Console.WriteLine("Bem Vindo ao Teste 02, para iniciarmos qual é o seu nome?");
            string nomePessoal = Console.ReadLine();

            while (continuar == true)
            {
                Console.WriteLine(nomePessoal + " por favor, nos informe qual sua nota da prova?");
                float notaDeProva = float.Parse(Console.ReadLine());
                totalDeNota = totalDeNota + notaDeProva;
                float mediaTotal = totalDeNota / quantidadeDeProvas;
                Console.WriteLine("Nome: " + nomePessoal);
                Console.WriteLine("Quantidade de Provas: " + quantidadeDeProvas);
                Console.WriteLine("Total de notas: " + totalDeNota);
                Console.WriteLine("Sua média é: " + mediaTotal);
                quantidadeDeProvas = quantidadeDeProvas + 1;
                Console.WriteLine();
            }
        }
    }
}