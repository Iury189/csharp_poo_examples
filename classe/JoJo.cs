using static System.Console;

namespace classe 
{
    public class JoJo 
    {
        public string nome { get; set; }
        public string stand { get; set; }
        public bool status_stand = false;
        
        public void ativarStand() 
        {
            if (status_stand) 
            {
                WriteLine($"{stand} já está invocado.");
            }
            else 
            {
                status_stand = true;
                WriteLine($"{stand} foi invocado.");
            }
        }

        public void desativarStand() 
        {
            if (status_stand == false) 
            {
                WriteLine($"{stand} já está oculto.");
            }
            else 
            {
                status_stand = false;
                WriteLine($"{stand} foi ocultado.");
            }
        }

        public void interacao() 
        {    
            string resultado, resultado_status;
            WriteLine($"Nome: {nome}");
            WriteLine($"Stand: {stand}");
            resultado = status_stand ? "Ativo." : "Inativo.";
            WriteLine($"Status do stand: {resultado}");
            if (status_stand) 
            {
                ativarStand();
            }
            else 
            {
                desativarStand();
            }
        }
    }
}
