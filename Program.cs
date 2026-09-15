namespace EsRipasso
{
    internal class Program
       
    {

        //es 1
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

            Console.WriteLine("-----------------------------------------");

            //es 2

            Console.Write("Inserisci un numro tra 1 e 10: ");
            num=int.Parse(Console.ReadLine());

            int tab = 0;

            for(int i = 0; i < 10; i++)
            {
                tab = tab + num;
                Console.WriteLine(tab);
            }

            Console.WriteLine("-----------------------------------------");

            //es 3

            int n, m, x = 2, numM, cont = 0;

            Console.Write("Inserisci n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Inserisci m: ");    
            m = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (n < m)
            {
                numM = n;
            }
            else
            {
                numM = m;
            }

            while(x <= numM)
            {
                if(n % x == 0 && m % x == 0)
                {
                    cont = cont + 1;
                }

                x++;
            }

            Console.Write(cont);

            Console.WriteLine("-----------------------------------------");

            //es 4

            int voti;

            double votoSin, somma = 0;

            Console.Write("Qunati voti vuoi inserire: ");
            voti = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci voto: ");

            for(int i = 0;i < voti; i++)
            {
                votoSin = 0;

                votoSin = int.Parse(Console.ReadLine());

                somma = somma + votoSin;
            }

            double media = somma / voti;

            Console.WriteLine();

            Console.WriteLine(media);

            Console.WriteLine("-----------------------------------------");

            //es 5 

            int b = 5, h = 4;

            for(int i = 0; i < h; i++)
            {
                for(int z = 0; z < b; z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
