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

            Console.Write("Digite a nota da N1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota da N2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota da N3: ");
            int n3 = int.Parse(Console.ReadLine());

            CalculoMedia mediaAluno = new CalculoMedia();
            CalculoMedia exameAluno = new CalculoMedia();

            mediaAluno.Media(n1, n2, n3);
            if (mediaAluno.media >= 7)
            {
                Console.WriteLine("Média " + mediaAluno.media + " Aprovado!");
            }
            else
            {
                Console.WriteLine("Média " + mediaAluno.media + " de Exame!");

                Console.Write("Digite a nota do exame: ");
                int exame = int.Parse(Console.ReadLine());

                exameAluno.Exame(mediaAluno.media, exame);

                if (exameAluno.mf >= 5)
                {
                    Console.WriteLine("Média " + exameAluno.mf + " Aprovado!");
                }
                else
                {
                    Console.WriteLine("Média " + exameAluno.mf + " Reprovado!");
                }
            }
            Console.ReadKey();
        }
            
    }
}
