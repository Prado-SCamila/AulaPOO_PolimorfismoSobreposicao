namespace AulaPOO_PolimorfismoSobreposicao.classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr(){
            return "Correndo na velocidade 1x";
        }

        public virtual string Pular(){
            return "Salto normal";
        }
    }
}