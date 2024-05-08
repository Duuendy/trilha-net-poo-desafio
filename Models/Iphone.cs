namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void Apresentando(string numero, string modelo, string imei, int memoria)
        {
            Console.WriteLine($"Seu aparelho Iphone de {memoria}GB de memoria, modelo - {modelo}, IMEI de registro {imei} está iniciando....");
            Console.WriteLine($"Seu aparelho Iphone possui o numero de telefone: {numero}");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}