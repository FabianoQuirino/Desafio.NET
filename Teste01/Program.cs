namespace Teste01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do primeiro semestre:");
            float notaPrimeiroSemestre = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo semestre:");
            float notaSegundoSemestre = float.Parse(Console.ReadLine());
            float media = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
            Console.WriteLine("Sua média é de " + media);
        }
    }
}