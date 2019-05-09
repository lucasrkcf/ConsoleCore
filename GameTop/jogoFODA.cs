using GameTop.Interface;

namespace GameTop
{
    public class jogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public jogoFODA(iJogador jogador1,iJogador jogador2)
        {
            this._jogadorA = jogador1;
            this._jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n \n");
            //
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}