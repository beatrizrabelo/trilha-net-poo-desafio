using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(int numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {}

        public override void InstalarApp(string nome)
        {
            Console.WriteLine("Instalando o aplicativo.. " + nome);
        }
    }
}