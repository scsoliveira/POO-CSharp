using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estats corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas pasando \n";
        }
    }
}