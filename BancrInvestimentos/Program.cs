using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancrInvestimentos
{
    class Program
    {        
        static void Main(string[] args)
        {
            CalculaInvestimento calcula = new CalculaInvestimento(); ;
            int duracao;
            int i = 0;
            double juros;
            double aporte;
            double ir;

            Console.WriteLine("Duaração Meses: ");
            duracao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aporte Mensal: ");
            aporte = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            do
            {
                i++;

                Console.WriteLine("Investimento " + i);
                Console.WriteLine("-----------------");
                Console.WriteLine("Taxa de Rendimento: ");
                juros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("IR:");
                ir = Convert.ToDouble(Console.ReadLine());

                calcula.returnValorInv(aporte, duracao, juros, ir);
                Console.Clear();
                
            } while (i < 2);

            calcula.returnMelhorInv();
            Console.ReadKey();
        }
    }
}
