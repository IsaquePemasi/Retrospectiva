using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Carro
    {
        public string marca;
        public string modelo;
        public int anoFabricacao;

        public void exibeDados()
        {
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Ano de fabricação: " + this.anoFabricacao);
            Console.WriteLine("\n");
        }
    }
}
