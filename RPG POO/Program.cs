using System;
using RPG_POO.src.Entities;

namespace Jogo_de_RPG_POO_C
{
    class Program
    {
        public static void Main(string[] args)
        {
            //criação do objeto utilizando a classe Arus.cs
            Knight knight = new Knight("Arus",23,"Knight",100,100);
            Hero oponnet = new Knight("Blue Dragon",99,"Dragon",100,100);
            Wizard wizard = new Wizard("Jennica",42,"White Wizard",100,100);
            Ninja ninja = new Ninja("Salomão",40,"Ninja",100,100);
            BlackWizard blackWizard = new BlackWizard("Astolfo",30,"Black Wizard",100,100);
            Console.WriteLine(ninja);
            Console.WriteLine(knight);
            Console.WriteLine(oponnet);
            Console.WriteLine(blackWizard);
            int bonus =0;
            Console.WriteLine("Digite o valor do bonus");
            bonus=int.Parse(Console.ReadLine());

            Console.WriteLine(knight.Attack(bonus));
            Console.WriteLine(wizard.Attack(bonus));
            Console.WriteLine(ninja.Attack(bonus));
            Console.WriteLine(blackWizard.Attack(bonus));
            

           
            
        }
    }

}