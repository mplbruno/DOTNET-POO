using System;
using DOTNET_POO.src.Entities;

namespace DOTNET_POO
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight arus = new Knight("Arus", 23, "Knight");
           Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            

         
           Console.WriteLine(wizard.Attack(1)); 
           Console.WriteLine(wizard.Attack(7)); 
          
        }
    }
}
