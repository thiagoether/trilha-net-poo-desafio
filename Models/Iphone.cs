using System.ComponentModel;
using System.Reflection.Metadata;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instando aplicativo {nomeApp} no Iphone.");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}