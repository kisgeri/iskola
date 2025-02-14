using System;

namespace tobbdimenziosTombok
{
    class Program
    {
        static void Main(string[] args)
        {
            kiiratas();

        }

        private static void kiiratas()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TÖBBDIMENZIÓS TÖMBÖK GYAKORLÓ FELADATOK C#-BAN\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1. VÉLETLEN MÁTRIX");
            Console.ForegroundColor = ConsoleColor.White;
            veletlenMatrix();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("2. TRANSZPONÁLT MÁTRIX");
            Console.ForegroundColor = ConsoleColor.White;
            transzponaltMatrix();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("3. MÁTRIX-ÖSSZEG");
            Console.ForegroundColor = ConsoleColor.White;
            MatrixOsszeg();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("4. KARAKTERMÁTRIX");
            Console.ForegroundColor = ConsoleColor.White;
            karakterMatrix();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("5. ELEMCSERE");
            Console.ForegroundColor = ConsoleColor.White;
            elemcsere();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("6. SORCSERE");
            Console.ForegroundColor = ConsoleColor.White;
            sorcsere(); 
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("7. VÉLETLENKEVERÉS");
            Console.ForegroundColor = ConsoleColor.White;
            velelenKeveres();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("8. SZINTVONALAS TERKEP");
            Console.ForegroundColor = ConsoleColor.White;
            szintvonalasTerkep();
            Console.WriteLine();
        }

        private static void veletlenMatrix()
        {
            Random rnd = new Random();

            int[,] matrix = new int[3, 4];

            for(int i = 0; i< matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        private static void transzponaltMatrix()
        {
            int[,] matrix = new int[3, 4] { {1,2,3,4 }, { 5, 6, 7, 8 }, { 9, 1, 2, 3 } };
            int[,] transzponalt = new int[4, 3]; 

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    transzponalt[j, i] = matrix[i, j];

                }

            }

            transzparentkiiras(matrix);
            transzparentkiiras(transzponalt);

        }

        private static void transzparentkiiras(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

        }

        private static void MatrixOsszeg()
        {
            int[,] matrix = new int[4, 4];
            double osszeg = 0;
            double db = 0;
            double atlag = 0;
            int foatloOsszeg = 0;
            int sorSZam;
            double sorOsszeg = 0;
            double sorDb = 0;
            double sorAtlag = 0;
            int legkisebb;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}. sor, {1}. oszlop: ",i,j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                    osszeg = osszeg + matrix[i, j];
                    db++;
                    if(i==j)
                    {

                        foatloOsszeg = foatloOsszeg + matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            atlag = osszeg / db;

            Console.WriteLine("A mátrix elemeinek összege: {0}",osszeg);
            Console.WriteLine("A mátrix elemeinek átlaga: {0}", atlag);
            Console.WriteLine("főátló összege: {0}",foatloOsszeg);

            do
            {
                Console.Write("Kérem sor számott: ");
                sorSZam = int.Parse(Console.ReadLine());

            } while (sorSZam < 0 || sorSZam >= matrix.GetLength(0));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i==sorSZam)
                    {
                        sorOsszeg = sorOsszeg + matrix[i, j];
                        sorDb++;
                    }

                }
            }
            sorAtlag = sorOsszeg / sorDb;

            Console.WriteLine("A mátrix {0}. sorában lévő elemek Átlaga: {1}",sorSZam,sorAtlag);

            Console.WriteLine("Oszlopk Minimumértékei: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                legkisebb = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < legkisebb)
                    {
                        legkisebb += matrix[i,j];
                    }
                }
                Console.Write(legkisebb + ", ");
            }
            Console.WriteLine();
        }

        private static void karakterMatrix()
        {
            Random rnd = new Random();

            char[,] matrix = new char[15, 15];
            char karakter;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToChar(rnd.Next(65, 255));
                    
                }
                
            }
            kiiratasfug(matrix);
            
            Console.WriteLine("\nadj meg egy karaktert: ");
            karakter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i==j || i+j == 14)
                    {
                        matrix[i, j] = karakter;
                    }
                    
                }

            }
            kiiratasfug(matrix);
        }

        private static char[,] kiiratasfug(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }

            return matrix;
        }

        private static void elemcsere()
        {
            Console.Write("Sorok száma: ");
            int sorok = int.Parse(Console.ReadLine());

            Console.Write("Oszlopok száma: ");
            int oszlop = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[sorok, oszlop];
            int szam = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = szam;
                    szam++;
                }

            }
            
            kiiratasfug(matrix);
            Console.WriteLine();

            int a1;
            int b1;
            int a2;
            int b2;
            int c;

            do
            {
                Console.Write("a1= ");
                a1 = int.Parse(Console.ReadLine());

                Console.Write("b1= ");
                b1 = int.Parse(Console.ReadLine());

                Console.Write("a2= ");
                a2 = int.Parse(Console.ReadLine());

                Console.Write("b2= ");
                b2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

            } while ((a1 < 0 || a1 >= sorok)|| (b1 < 0 || b1 >= sorok) || (a2 < 0 || a2 >= oszlop) || (b2 < 0 || b2 >= oszlop));

            Console.WriteLine("Cserélni fogjuk matrix[{0},{1}]={2} elemet  erre: matrix[{3},{4}]={5}",a1,b1,matrix[a1,b1],a2,b2,matrix[a2,b2]);

            c = matrix[a1, b1];
            matrix[a1, b1] = matrix[a2, b2];
            matrix[a2, b2] = c;

            kiiratasfug(matrix);
            Console.WriteLine();
        }

        private static int[,] kiiratasfug(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            return matrix;
        }

        private static void sorcsere()
        {
            int[,] matrix = new int[11, 11];
            int szam = 50;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    matrix[i, j] = szam ;
                    
                }
                szam = szam - 2;

            }
            kiiratasfug(matrix);
            Console.WriteLine();

            int sorszam;
            int sorszam1;
            int seged;

            do
            {

                Console.Write("Kérlek ad meg melyiksor szeretnéd kicserélni: ");
                sorszam = int.Parse(Console.ReadLine());

            } while (sorszam < 0 || sorszam >= matrix.GetLength(0));

            do
            {

                Console.Write("Kérlek ad meg melyiksoral szeretnéd kicserélni: ");
                sorszam1 = int.Parse(Console.ReadLine());

            } while (sorszam1 < 0 || sorszam1 >= matrix.GetLength(0));
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    seged = matrix[sorszam, j];
                    matrix[sorszam, j] = matrix[sorszam1, j];
                    matrix[sorszam1, j] = seged;

                }
                
            }
            kiiratasfug(matrix);
        }
        private static void velelenKeveres()
        {
            Random rnd = new Random();
            int[,] matrix = new int[8, 8];
            int szam = 99;
            int keveres;
            int elem_1;
            int elem_2;
            int elem1_1;
            int elem1_2;
            int seged;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = szam;
                    szam--;
                }

            }

            kiiratasfug(matrix);

            Console.WriteLine("mennyi keverés legyen? ");
            keveres = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < keveres;i++)
            {
                elem_1 = rnd.Next(0, 8);
                elem_2= rnd.Next(0, 8);
                elem1_1= rnd.Next(0, 8);
                elem1_2= rnd.Next(0, 8);

                Console.WriteLine("{0}. keverés: {1},{2} --> {3},{4}",i,elem_1,elem_2,elem1_1,elem1_2);
                Console.WriteLine("Cserélni fogjuk matrix[{0},{1}]={2} elemet erre: matrix[{3},{4}]={5}", elem_1, elem_2,matrix[elem_1,elem_2] ,elem1_1, elem1_2, matrix[elem1_1, elem1_2]);
                Console.WriteLine();

                seged = matrix[elem_1, elem_2];
                matrix[elem_1, elem_2] = matrix[elem1_1, elem1_2];
                matrix[elem1_1, elem1_2] = seged;

            }
            kiiratasfug(matrix);

        }
        private static void szintvonalasTerkep()
        {
            Random rnd = new Random();
            int[,] matrix = new int[20, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-3000, 3000);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= -3000 && matrix[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (matrix[i, j] >= 0 && matrix[i, j] < 1000)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if(matrix[i, j] >= 1000 && matrix[i, j] < 2000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (matrix[i, j] >= 2000 && matrix[i, j] < 3000)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();

            }
        }
    }
}
