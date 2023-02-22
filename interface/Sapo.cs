using static System.Console;

namespace iinterface 
{
    class Sapo : Ipresa, Ipredador 
    {
        public void fugir() 
        {
            WriteLine("O sapo está fugindo da águia.");
        }
        public void cacar() 
        {
            WriteLine("O sapo está caçando o garfanhoto.");
        }
    }
}