using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas corrindo \n";
        }

        public string Passe()
        {
            return "Maradona estas pasando \n";
        }
    }
}