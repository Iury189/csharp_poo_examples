using static System.Console;

namespace classe {

    class MainClass {

        public static void Main(string[] args){

            JoJo j1 = new JoJo();
            Write("Digite o nome do usuário: ");
            j1.setNome(ReadLine());
            Write($"Digite o nome do stand de {j1.getNome()}: ");
            j1.setStand(ReadLine());
            Write("\n");
            j1.interacao();
            ReadKey();
        }
    }
}
