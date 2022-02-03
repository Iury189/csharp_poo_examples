using static System.Console;

namespace abstracao {

    class MainClass {

        public static void Main(string[] args) {
            Moto moto = new Moto();
            Write("Digite a marca da moto: ");
            moto.setMarca(ReadLine());
            Write("Digite o modelo da moto: ");
            moto.setModelo(ReadLine());
            Write("Digite a cor da moto: ");
            moto.setCor(ReadLine());
            Write("Digite o ano de fabricação da moto: ");
            if (!int.TryParse(ReadLine(), out int digite_ano)) return;
            moto.setAno(digite_ano);
            Write("Digite o valor da moto: ");
            if (!decimal.TryParse(ReadLine(), out decimal digite_valor)) return;
            moto.setValor(digite_valor);
            moto.interacao();
        }
    }
}
