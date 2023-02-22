using static System.Console;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            JoJo j1 = new JoJo();
            while (true)
            {
                Write("Digite seu nome: ");
                j1.nome = ReadLine();
                if (string.IsNullOrEmpty(j1.nome))
                {
                    WriteLine("Campo nome não pode ficar vazio, refaça a operação.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Write($"Digite o nome do stand de {j1.nome}: ");
                j1.stand = ReadLine();
                if (string.IsNullOrEmpty(j1.stand))
                {
                    WriteLine($"O nome do stand de {j1.nome} não pode ficar vazio, refaça a operação.");
                }
                else
                {
                    break;
                }
            }
            j1.interacao();
        }
    }
}