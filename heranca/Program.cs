using static System.Console;

namespace heranca {

    class MainClass {

        public static void Main(string[] args) {

            Carro carro = new Carro();
            Write("Digite a marca do carro: ");
            carro.setMarca(ReadLine());
            Write("Digite o modelo do carro: ");
            carro.setModelo(ReadLine());
            Write("Digite a cor do carro: ");
            carro.setCor(ReadLine());
            Write("Digite o ano de fabricação do carro: ");
            if (!int.TryParse(ReadLine(), out int digite_ano)) return;
            carro.setAno(digite_ano);
            Write("Digite o valor do carro: ");
            if (!decimal.TryParse(ReadLine(), out decimal digite_valor)) return;
            carro.setValor(digite_valor);
            carro.interacao();
        }
    }
}
