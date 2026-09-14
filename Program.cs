namespace EsRipasso
{
    internal class Program
       
    {
        static void Main(string[] args)
        {  

            Console.Write("Inserisci un numero: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("positivo");

            }else if(num < 0)
            {
                Console.WriteLine("negativo");

            }else if (num == 0)
            {
                Console.WriteLine("0");
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("pari");
            }
            else
            {
                Console.WriteLine("dispari");
            }


            Console.Write("Inserisci un numro tra 1 e 10: ");
            num=int.Parse(Console.ReadLine());

            int tab = 0;

            for(int i = 0; i < 10; i++)
            {
                tab = tab + num;
                Console.WriteLine(tab);
            }
                    
        }
    }
}
