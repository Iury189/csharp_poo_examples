using System;
using System.Globalization;
using System.Threading;
using static System.Console;

namespace abstracao {

    public class Moto : Veiculo {

        public override void interacao() {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            var hora_atual = DateTime.Now;
            WriteLine("\n");
            WriteLine($"Modelo: {this.getModelo()}");
            WriteLine($"Marca: {this.getMarca()}");
            WriteLine($"Cor: {this.getCor()}");
            WriteLine($"Ano de fabricação: {this.getAno()}");
            WriteLine($"Valor: {this.getValor().ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            WriteLine($"Data da compilação: {hora_atual.ToString("dd/MM/yyyy HH:mm:ss")}");
        }

    }
}