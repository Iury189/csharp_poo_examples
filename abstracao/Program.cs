using static System.Console;

namespace abstracao 
{
    class MainClass 
    {
        public static void Main(string[] args) 
        {    
            Moto moto = new Moto();
            Write("Digite a marca da moto: ");
            moto.marca = ReadLine();
            Write("Digite o modelo da moto: ");
            moto.modelo = ReadLine();
            Write("Digite a cor da moto: ");
            moto.cor = ReadLine();
            Write("Digite o ano de fabricação da moto: ");
            moto.ano = int.Parse(ReadLine());
            Write("Digite o valor da moto: ");
            moto.valor = decimal.Parse(ReadLine());
            moto.interacao();   
        }
    }
}
