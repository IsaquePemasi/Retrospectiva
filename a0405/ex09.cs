//9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

//Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.

namespace testando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 3 valores, de glicemia em jejum: ");
            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());
            double valorT = valor1 + valor2 + valor3;
            double media = valor1 + valor2 + valor3;
            if (valorT < 65)
            {
                Console.WriteLine("corre risco de hipoglicemia");
            }
            else if (valorT > 250)
            {
                Console.WriteLine("corre risco de hiperglicemia");
            }

            if (media < 80)
            {
                Console.WriteLine("é preciso diminuir 2 unidades de insulina");
            }
            if (media > 150)
            {
                Console.WriteLine("será necessário adicionar 2 unidades de insulina");
            }
        }
    }
}