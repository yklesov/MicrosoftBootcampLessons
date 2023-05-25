using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BasicType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region a
            /*string loremIpsum = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.Why do we use it? " +
                "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. " +
                "The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. " +
                "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. " +
                "Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            string text = "Similar text";

            string index = "L";

            int indexInt = 1;

            int returnResult = string.Compare(loremIpsum, text);
            Console.WriteLine("It's Compare" + " " + returnResult);

            string removeString = loremIpsum.Remove(indexInt);
            Console.WriteLine("It's Remove" + " " + removeString);

            int charIndex = loremIpsum.IndexOf(index);
            Console.WriteLine("It's IndexOf" + " " + charIndex);

            string console = text.Insert(8, index);
            Console.WriteLine("It's Insert" + " " + console);

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            string s10 = string.Join(" ", values);
            Console.WriteLine("It's Join" + " " + s10);

            string fullText = text.Replace("text", "TEXT");
            Console.WriteLine("It's Replace" + " " + fullText);

            Console.WriteLine("It's ToLower" + " " + text.ToLower());

            Console.WriteLine("It's ToUpper" + " " + text.ToUpper());

            string countryCapital = text.Trim(new char[] { 'S' });
            Console.WriteLine("It's Trim" + " " + countryCapital);

            string[] arr = new string[]
                 {
                        "Witcher",
                        "Monster",
                        "Mortem",
                        "Murder"
                 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EndsWith("r"))
                {
                    Console.WriteLine("It's EndsWith" + " " + arr[i]);
                }
            }

            StringBuilder sb = new StringBuilder(loremIpsum);
            Console.WriteLine("It's StringBuilder length" + " " + sb.Length);
            Console.WriteLine("It's StringBuilder capacity" + " " + sb.Capacity);

            loremIpsum = loremIpsum.Replace(",", string.Empty);
            Console.WriteLine(loremIpsum);
            */
            #endregion
            /*
            Սարքել 10 չափանի մասիվ
            Ամեն մեկը ունենա 3 չափ

            Ֆռալ ցիկլով ու տպել բոլորը
            Օգտագործել բոլոր 3 ցիկլները


            տպել 1-100 բոլոր կենտերը
            3 ձև( 1-ը while-ով, 1-ը do-while-ով, 1-ը for-ով)
             */

            /*for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */
            /*
            int i= 1;
            while (i < 100)
            {
                if (i % 2 != 0 )
                Console.WriteLine(i);
                i++;
            }
            */
            /* int i = 1;
             do
             {
                 if (i % 2 != 0)
                     Console.WriteLine(i);
                 i++;
             } while (i<100);
            */
            int[,,,,,,,,,] arr2 = new int[3, 3, 3, 3, 3, 3, 3, 3, 3, 3];
            Random rnd = new Random();
            /*for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(2); k++)
                    {
                        for (int c = 0; c < arr2.GetLength(3); c++)
                        {
                            for (int m = 0; m < arr2.GetLength(4); m++)
                            {
                                for (int n = 0; n < arr2.GetLength(5); n++)
                                {
                                    for (int b = 0; b < arr2.GetLength(6); b++)
                                    {
                                        for (int x = 0; x < arr2.GetLength(7); x++)
                                        {
                                            for (int z = 0; z < arr2.GetLength(8); z++)
                                            {
                                                for (int q = 0; q < arr2.GetLength(9); q++)
                                                {
                                                    int num = rnd.Next(0, 10);
                                                    arr2[i, j, k, c, m, n, b, x, z, q] = num;
                                                    Console.Write(arr2[i, j, k, c, m, n, b, x, z, q] + " ");
                                                }
                                                Console.WriteLine();
                                            }
                                            Console.WriteLine();
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */
            
            int a = 0 ;
            int b = 0 ;
            int c = 0 ;
            int d = 0 ;
            int e = 0 ;
            int f = 0 ;
            int g = 0 ;
            int h = 0 ;
            int i = 0 ;
            int j = 0 ;
            /* while (a < 3)
             {
                 while (b < 3)
                 {
                     while (c < 3)
                     {
                         while (d < 3)
                         {
                             while (e < 3)
                             {
                                 while (f < 3)
                                 {
                                     while (g < 3)
                                     {
                                         while (h < 3)
                                         {
                                             while (i < 3)
                                             {
                                                 while (j < 3)
                                                 {
                                                     int num = rnd.Next(0, 10);
                                                     arr2[a, b, c, d, e, f, g, h, i, j] = num;
                                                     Console.Write(arr2[a, b, c, d, e, f, g, h, i, j] + " ");
                                                     j++;
                                                 }
                                                 j = 0;
                                                 Console.WriteLine();
                                                 i++;
                                             }
                                             i = 0;
                                             Console.WriteLine();
                                             h++;
                                         }
                                         h = 0;
                                         Console.WriteLine();
                                         g++;
                                     }
                                     g = 0;
                                     Console.WriteLine();
                                     f++;
                                 }
                                 f = 0;
                                 Console.WriteLine();
                                 e++;
                             }
                             e = 0;
                             Console.WriteLine();
                             d++;
                         }
                         d = 0;
                         Console.WriteLine();
                         c++;
                     }
                     c = 0;
                     Console.WriteLine();
                     b++;
                 }
                 b = 0;
                 Console.WriteLine();
                 a++;
             }*/
            
           /* do
            {
                do
                {
                    do
                    {
                        do
                        {
                            do
                            {
                                do
                                {
                                    do
                                    {
                                        do
                                        {
                                            do
                                            {
                                                do
                                                {
                                                    int num = rnd.Next(0, 10);
                                                    arr2[a, b, c, d, e, f, g, h, i, j] = num;
                                                    Console.Write(arr2[a, b, c, d, e, f, g, h, i, j] + " ");
                                                    j++;
                                                } while (j < 3);
                                                Console.WriteLine();
                                                j = 0;
                                                i++;
                                            } while (i < 3);
                                            Console.WriteLine();
                                            i = 0;
                                            h++;
                                        } while (h < 3);
                                        Console.WriteLine();
                                        h = 0;
                                        g++;
                                    } while (g < 3);
                                    Console.WriteLine();
                                    g = 0;
                                    f++;
                                } while (f < 3);
                                Console.WriteLine();
                                f = 0;
                                e++;
                            } while ( e < 3);
                            Console.WriteLine();
                            e = 0;
                            d++;
                        } while (d < 3);
                        Console.WriteLine();
                        d = 0;
                        c++;
                    } while (c < 3);
                    Console.WriteLine();
                    c = 0;
                    b++;
                } while (b < 3);
                Console.WriteLine();
                b = 0;
                a++;
            } while (a < 3);*/
        }
    }
}