using static System.Console;

namespace heranca 
{
    class MainClass 
    {
        public static void Main(string[] args) 
        {
            Carro carro = new Carro();
            Write("Digite a marca do carro: ");
            carro.marca = ReadLine();
            Write("Digite o modelo do carro: ");
            carro.modelo = ReadLine();
            Write("Digite a cor do carro: ");
            carro.cor = ReadLine();
            Write("Digite o ano de fabricação do carro: ");
            carro.ano = int.Parse(ReadLine());
            Write("Digite o valor do carro: ");
            carro.valor = decimal.Parse(ReadLine());
            carro.interacao();           
        }
    }
}
