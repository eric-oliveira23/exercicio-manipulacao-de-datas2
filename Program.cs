using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulandodatas3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, total2, total3, totalt;

            Console.WriteLine("Informe o mês");
            int mes = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o ano");
            int ano = int.Parse(Console.ReadLine());

            total = DateTime.DaysInMonth(ano, mes);

            Console.WriteLine("Os dias desse mês foram: " + total);


            Console.WriteLine("Informe o mês");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano");
            ano = int.Parse(Console.ReadLine());

            total2 = DateTime.DaysInMonth(ano, mes);

            Console.WriteLine("Os dias desse mês foram: " + total2);


            Console.WriteLine("Informe o mês");
             mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano");
             ano = int.Parse(Console.ReadLine());

             total3 = DateTime.DaysInMonth(ano, mes);

            Console.WriteLine("Os dias desse mês foram: " + total3);

            totalt = total + total2 + total3;

            Console.WriteLine("O total de dias é " + totalt);



            Console.ReadKey();






        }
    }
}
