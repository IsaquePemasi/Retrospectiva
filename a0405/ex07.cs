//7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
//O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
//exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

namespace testando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma palvra ");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra " + palavra + " contem na frase");
            }
            else
            {
                Console.WriteLine("A palavra " + palavra + " contem na frase");
            }
        }
    }
}

