using static System.Console;

namespace classe {

    class MainClass {

        public static void Main(string[] args){

            JoJo j1 = new JoJo();
            Write("Digite o nome do usuário: ");
            j1.nome = ReadLine()
            Write($"Digite o nome do stand de {j1.nome}: ");
            j1.stand = ReadLine()
            Write("\n");
            j1.interacao();
            ReadKey();
            
        }
    }
}
