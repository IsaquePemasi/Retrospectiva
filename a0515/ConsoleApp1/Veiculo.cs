﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Veiculo

    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public double _potencia;
        public virtual void Ligar()
        {
            Console.WriteLine("oi, eu sou veiculo ligado!");
        }
        public void Dirigir()
        {
            Console.WriteLine("Dirigindo o " + this.Marca + this.Modelo);
        }
    }
}

//Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar duas classes derivadas, Carro e Moto, que herdam de 
//Veiculo. A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade 
//adicional Cilindrada. Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>". Em seguida, criar um 
//método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na
//classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas".
