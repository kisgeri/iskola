using System;

namespace ld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LDTav("alma", "falja"));
            
        }

        private static int LDTav(string s1, string s2)
        {
            int h1 ,h2;
            int c;
            int[,] m = new int[26, 26];

            h1 = s1.Length;
            h2 = s2.Length;

            if(h1 == 0)
            {
                return h2;
            }
            if(h2==0)
            {
                return h1;
            }
            
                for(int i = 0; i < h1; i++)
                {
                    m[i, 0] = i;
                }

                for (int j = 0; j < h2; j++)
                {
                    m[0, j] = j;
                }

                for (int i = 1; i < h1; i++)
                {
                    for (int j = 1; j < h2; j++)
                    {
                        c = 1;
                        if(s2[j-1] == s1[i-1])
                        {
                            c = 0;
                        }
                        m[i, j] = Min(Min(m[i-1,j]+1,m[i,j-1]+1),m[i-1,j-1]+c);
                        m[h1, h2] = m[i,j];
                    }
                }
            return m[h1,h2];
        }

        private static int Min(int a , int b)
        {
            if(a<b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
