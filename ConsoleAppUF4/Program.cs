using library;

namespace UF4
{
    public class Exercici1
    {
        public static void Main(String[] args) 
        {
            employee empleao = new employee (new DateOnly(2000, 10, 18));
            Console.WriteLine(empleao.countage());
            string aAlgo = "hola otra vez";
            Console.WriteLine(aAlgo);
        }
    }
}
