using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    public class CalculoMedia
    {
        public int media;
        public int exame;
        public int mf;

        public int Media(int n1, int n2, int n3)
        {
            media = (n1 + n2 + n3) / 3;
            return media;
        }

        public int Exame(int media, int exame)
        {
            mf = (media + exame) / 2;
            return mf;
        }
    }
}
