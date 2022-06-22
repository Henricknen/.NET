namespace Classes.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y)      // 'ref' indica que esta passando o parametro por referencia
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);     // 'i' e 'f' esta sendo passado por referencia e mão por valores i equivale a 2 e j a 1 
            System.Console.WriteLine($"{i} {j}"); // Escreve "2 1"
        }
    }
}