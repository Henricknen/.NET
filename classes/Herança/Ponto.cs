namespace Classes.Herança
{
    public class Ponto      // classe Ponto
    {
        public int x, y;        // variaveis x e y publicas
        private int distancia;  // variavel distancia privada, so é acessada internamente

        public Ponto(int x, int y)      // contrutor publico
        {
            this.x = x;     // 'this.' se refere a classe
            this.y = y;
        }

        protected void CalcularDistancia()      // metodo protected
        {
            // faz alguma coisa
        }
        private void CalcularDistancia2()       // metodo private
        {
            // faz alguma coisa
        }
        public virtual void CalcularDistancia3()
        {
            // faz alguma coisa
        }
    }
}