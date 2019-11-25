using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancrInvestimentos
{
    public class CalculaInvestimento
    {
        private double aux = 0;
        List<Rendimento> rendimentos = new List<Rendimento>();
        private double irFinal;
        private double ir = 0;
        private double vlrTotal;
        private double valorInvestido;
        private int meses;
        private int index;

        public void returnValorInv(double aporte, int duracao, double juros, double ir)
        {
            vlrTotal = 0;
            irFinal = 0;
            meses = duracao;
            valorInvestido = aporte * duracao;
            aux = aporte;
            for (int i = 0; i < duracao; i++)
            {
                aux = vlrTotal * ((juros / 100) + 1);
                vlrTotal = aux + aporte;
            }

            irFinal = vlrTotal * (ir / 100);
            vlrTotal = vlrTotal - irFinal;

            InsereRendimento();

            
        }

        private void InsereRendimento()
        {
            Rendimento r = new Rendimento
            {
                valor = valorInvestido,
                valorTotal = vlrTotal,
                duaracaoMeses = meses
            };

            rendimentos.Add(r);
        }

        public void returnMelhorInv()
        {
            double melhorInv = 0;
            double result = 0;
            int  m = 0;
            
            foreach (var item in rendimentos)
            {                

                result = item.valorTotal - valorInvestido;
                if (result > melhorInv)
                {
                    melhorInv = result;
                    index = m;
                }
                index++;
            }

            for (int i = 0; i < rendimentos.Count; i++)
            {
                if(i == index)
                    Console.WriteLine($"O melhor Investimento é {index + 1} com rentabilidade de {result.ToString("C")} ao final!");
            }
        }

    }
}
