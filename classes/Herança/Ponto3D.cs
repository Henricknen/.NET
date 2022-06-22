namespace Classes.Herança
{
    public class Ponto3D : Ponto        // ':' identifica que classe Ponto3D herda a classe Ponto, no C# so se pode herda de uma unica classe
    {
        public Ponto3D(int x, int y, int z) : base(x, y)        
        {                                  // base é a classe Ponto
            this.z = z;
            CalcularDistancia();
            cal
        }

        public static void Calcular()
        {
            // faz alguma coisa
        }

        public override void CalcularDistancia3()       // sobre escrever o metodo CalcularDistancia3
        {
            // faz alguma coisa
            base.CalcularDistancia3();      // chama o metodo da classe base
        }
    }
}