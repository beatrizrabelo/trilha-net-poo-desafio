using DesafioSistemaCelular.Models;
namespace DesafioSistemaCelular
{
    public class Gerenciador
    {
        public static void Main(string[] args)
        {
            Nokia nokia = new Nokia(715588958, "Nokia Lumia 720", "012020/00/3020/22", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarApp("Instagram");

            Iphone iphone = new Iphone(742585220, "Iphone 8 plus", "201555/22/4588/00", 32);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarApp("E-Titulo");
        }
    }
}