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
            while (true)
            {
                try 
                {
                    if (j1.status_stand == false)
                    {
                        WriteLine($"O stand {j1.stand} está desativado.");
                        Write("Deseja ativar? (0 - Não | 1 - Sim): ");
                        int resposta_status = int.Parse(ReadLine());
                        if (resposta_status == 1)
                        {
                            status_stand = true;
                            WriteLine($"O Stand {j1.stand} foi ativado.");
                            break;
                        } 
                        else if (resposta_status == 0)
                        {
                            WriteLine($"O Stand {j1.stand} continuará inativo.");
                            break;
                        } 
                        else 
                        {
                            WriteLine("Opção inválida, digite uma das respectivas opções válidas.");
                        }
                    } 
                    else 
                    {
                        WriteLine($"O stand {j1.stand} está ativado.");
                        Write("Deseja desativar? (0 - Não | 1 - Sim): ");
                        int resposta_status = int.Parse(ReadLine());
                        if (resposta_status == 1)
                        {
                            status_stand = false;
                            WriteLine($"O Stand {j1.stand} foi desativado.");
                            break;
                        } 
                        else if (resposta_status == 0)
                        {
                            WriteLine($"O Stand {j1.stand} continuará ativo.");
                            break;
                        } 
                        else 
                        {
                            WriteLine("Opção inválida, digite uma das respectivas opções.");
                        }
                    }
                } 
                catch (Exception e) 
                {
                    WriteLine("Campo deve conter apenas números inteiros, refaça a operação.");
                }
            }
            j1.interacao();
        }
    }
}