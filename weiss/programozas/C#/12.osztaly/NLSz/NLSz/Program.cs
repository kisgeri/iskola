using System;

namespace NLSz
{

    class Program
    {
        const int N = 5;
        static void Main(string[] args)
        {
            char[] szam = new char[N] { '5', '2', '6', '3', '1' };

            Console.WriteLine(szam);
            Console.WriteLine();

            Console.WriteLine(Keres(szam));

            Console.ReadKey();


        }

        static char[] Cserel(char[] szam, int i1, int i2)
        {
            char ch;
            ch =szam[i1];
            szam[i1] = szam[i2];
            szam[i2] = ch;

            return szam;

        }

        static char[] Keres(char[] szam)
        {
            int indA, indB, i, j, meddig;

            indA = -1;
            i = N - 1;

            while (i > 0 && indA == -1)
            {
                if (szam[i - 1] < szam[i])
                {
                    indA = i - 1;
                }
                i = i - 1;
            }
            if (indA == -1)
            {
                return szam;
            }
            indB = indA + 1;

            for (j = indA + 2; j <= N - 1; j++)
            {
                if ((szam[j] > szam[indA]) && (szam[j] < szam[indB]))
                {
                    indB = j;
                }

            }
            szam = Cserel(szam, indA, indB);

            for (meddig = N - 1; meddig  >= 1; meddig--)
            {
                for (j = indA + 1; j <= meddig - 1; j++)
                {
                    if (szam[j] > szam[j + 1])
                    {
                        Cserel(szam, j, j + 1);
                    }
                }
            }
            return szam;
        }
    }
}
