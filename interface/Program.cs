namespace iinterface 
{
    class MainClass 
    {
        public static void Main(string[] args) 
        {
            Garfanhoto garfanhoto = new Garfanhoto();
            Sapo sapo = new Sapo();
            Aguia aguia = new Aguia();

            garfanhoto.fugir();
            sapo.cacar();
            sapo.fugir();
            aguia.cacar();
        }
    }
}