using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaCelular.Models
{
    public abstract class Smartphone
    {
        public int Numero { get;}
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(int numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando para o número +55 {Numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação..");
        }

        public abstract void InstalarApp(string nome);

    }
}