namespace abstracao {

    public abstract class Veiculo {

        private string modelo { get; set; }
        public string marca { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public decimal valor { get; set; }

        public abstract void interacao();

    }
}
