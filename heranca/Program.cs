using static System.Console;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro  = new Carro();
            while (true)
            {
                Write("Digite a marca do carro: ");
                carro.marca = ReadLine();
                if (string.IsNullOrEmpty(carro.marca))
                {
                    WriteLine("Campo marca não pode ficar vazio, refaça a operação.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Write("Digite o modelo do carro: ");
                carro.modelo = ReadLine();
                if (string.IsNullOrEmpty(carro.modelo))
                {
                    WriteLine("Campo modelo não pode ficar vazio, refaça a operação.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Write("Digite a cor do carro: ");
                carro.cor = ReadLine();
                if (string.IsNullOrEmpty(carro.cor))
                {
                    WriteLine("Campo cor não pode ficar vazio, refaça a operação.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                try
                {
                    Write("Digite o ano de fabricação do carro: ");
                    carro.ano = int.Parse(ReadLine());
                    if (carro.ano <= 0)
                    {
                        WriteLine("Campo ano não pode ser menor ou igual a zero, refaça a operação.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    WriteLine("Campo deve conter apenas números inteiros, refaça a operação.");
                }

            }
            while (true)
            {
                try
                {
                    Write("Digite o valor do carro: ");
                    carro.valor = decimal.Parse(ReadLine());
                    if (carro.valor <= 0)
                    {
                        WriteLine("Campo valor não pode ser menor ou igual a zero, refaça a operação.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    WriteLine("Campo deve conter apenas números decimais, refaça a operação.");
                }
            }
            carro.interacao();
        }
    }
}