using System;
using System.Globalization;
using static System.Console;

namespace heranca
{
    class Carro : Veiculo
    {
        public void interacao()
        {
            var hora_atual = DateTime.Now;
            WriteLine("\n");
            WriteLine($"Marca: {marca}");
            WriteLine($"Modelo: {modelo}");
            WriteLine($"Cor: {cor}");
            WriteLine($"Ano de fabricação: {ano}");
            WriteLine($"Valor: {valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            WriteLine($"Data da compilação: {hora_atual.ToString("dd/MM/yyyy HH:mm:ss")}");
        }
    }
}