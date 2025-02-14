using System;

namespace eljarasokfugvenyek
{
    class Program
    {
        static int[] tomb = new int[5];
        static void Main(string[] args)
        {
            kiírások();
            Adatbekeres();
            tombkiírás();
        }

        static void kiírások()
        {
            Console.WriteLine("1. ISMÉTLÉS NÉLKÜLI MEGOSZTOTT TÖMB");
        }

        static void tombkiírás()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+", ");
            }
        }
        static void Adatbekeres()
        {
            int beszam;
            bool dupla;

            int index = 0;
            int index2;

            while(index<tomb.Length)
            {
                dupla = false;
                index2 = 0;

                Console.Write("Add meg a tömb {0}. elemét: ", index);
                beszam = int.Parse(Console.ReadLine());

                

                while (index2 < index && dupla==false)
                {
                    

                    if(beszam == tomb[index2])
                    {
                        dupla = true;
                    }
                    

                    index2++;


                }

                if (dupla == false)
                {
                    tomb[index] = beszam;
                    index++;
                    
                }
                else
                {
                    Console.WriteLine("nem lehet kétt ugyan olyan szám!");
                }
            }
            
                
              
        }
    }
}
