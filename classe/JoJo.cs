using static System.Console;

namespace classe {

    public class JoJo {

        private string nome, stand;
        private bool status_stand = false;
        
        public string getNome() { return nome; }
        public string getStand() { return stand; }
        public bool getStatusStand() { return status_stand; }
        public void setNome(string nome) { this.nome = nome; }
        public void setStand(string stand) { this.stand = stand; }
        public void setStatusStand(bool status_stand) { this.status_stand = status_stand; }

        public void ativarStand() {
            if (this.getStatusStand()) {
                WriteLine($"{this.getStand()} já está invocado.");
            }
            else {
                this.setStatusStand(true);
                WriteLine($"{this.getStand()} foi invocado.");
            }
        }

        public void desativarStand() {
            if (this.getStatusStand() == false) {
                WriteLine($"{this.getStand()} já está oculto.");
            }
            else {
                this.setStatusStand(false);
                WriteLine($"{this.getStand()} foi ocultado.");
            }
        }

        public void interacao() {
            string resultado;
            WriteLine($"Nome: {this.getNome()}");
            WriteLine($"Stand: {this.getStand()}");
            resultado = this.getStatusStand() ? "Ativo" : "Inativo";
            WriteLine($"Status do stand: {resultado}");
            if (this.getStatusStand()) {
                ativarStand();
            }
            else {
                desativarStand();
            }
        }
    }
}
