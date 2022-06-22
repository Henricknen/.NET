namespace Classes.Metodos
{
    public class OUt
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }

        public void Dividir()
        {
            Dividir(10, 3, out int resultado, resto);       
            System.Console.WriteLine("{0} {1}", resultado, resto);      // Escreve 3 1
        }
    }
}