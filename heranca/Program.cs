using static System.Console;

namespace heranca {

    class MainClass {

        public static void Main(string[] args) {

            Carro carro = new Carro();
            Write("Digite a marca do carro: ");
            carro.marca = ReadLine();
            Write("Digite o modelo do carro: ");
            carro.modelo = ReadLine();
            Write("Digite a cor do carro: ");
            carro.cor = ReadLine();
            Write("Digite o ano de fabricação do carro: ");
            if (!int.TryParse(ReadLine(), out int digite_ano)) return;
            carro.ano = digite_ano;
            Write("Digite o valor do carro: ");
            if (!decimal.TryParse(ReadLine(), out decimal digite_valor)) return;
            carro.valor = digite_valor;
            carro.interacao();
            
        }
    }
}
