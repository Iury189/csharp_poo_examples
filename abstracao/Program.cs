using static System.Console;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto();
            while (true)
            {
                Write("Digite a marca da moto: ");
                moto.marca = ReadLine();
                if (string.IsNullOrEmpty(moto.marca))
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
                Write("Digite o modelo da moto: ");
                moto.modelo = ReadLine();
                if (string.IsNullOrEmpty(moto.modelo))
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
                Write("Digite a cor da moto: ");
                moto.cor = ReadLine();
                if (string.IsNullOrEmpty(moto.cor))
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
                    Write("Digite o ano de fabricação da moto: ");
                    moto.ano = int.Parse(ReadLine());
                    if (moto.ano <= 0)
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
                    Write("Digite o valor da moto: ");
                    moto.valor = decimal.Parse(ReadLine());
                    if (moto.valor <= 0)
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
            moto.interacao();
        }
    }
}