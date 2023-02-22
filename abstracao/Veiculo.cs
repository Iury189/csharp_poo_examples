using static System.Console;

namespace abstracao
{
    abstract class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public decimal valor { get; set; }

        public abstract void interacao();
    }
}