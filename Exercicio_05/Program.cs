using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um programa para verificar se o aluno foi aprovado ou se ficou de exame (média >=7)
            //Caso fique de exame solicite a nota do exame e verifique se alcançou a média >=5 aprovado, do contrário reprovado.

            int n1, n2, n3, media, exame, mf;

            Console.Write("Digite a nota da N1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota da N2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota da N3: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Média "+media+" Aprovado!");
            }
            else
            {
                Console.WriteLine("Média " + media + " de Exame!");

                Console.Write("Digite a nota do exame: ");
                exame = Convert.ToInt32(Console.ReadLine());

                mf = (media + exame) / 2;
                if (mf >= 5)
                {
                    Console.WriteLine("Média " + mf + " Aprovado!");
                }
                else
                {
                    Console.WriteLine("Média " + mf + " Reprovado!");
                }
            }
            Console.ReadKey();
        }
    }
}
