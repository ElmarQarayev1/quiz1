using System;

namespace taskk
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= " elmar      ";
            Console.WriteLine(DeleteSpace(s));
            Console.WriteLine(s);


            Console.ReadLine();
        }

        static string DeleteSpace(string str)
        {
            int startindex = 0;
            string newstr = "";
            for (int i = str.Length-1; i <=0; i--)
            {
                if(str[i]!=' ')
                {
                    startindex = i;
                    break;
                }

            }
            for (int i = 0; i <=startindex; i++)
            {
                newstr += str[i];

            }
            return newstr;
        }
        static bool Yoxlama(int eded)
        {
            int eded1;
            int[] ededler = new int[eded];
            int[] ededler1 = new int[eded];
            for (int i = eded; i <=0; i--)
            {
                ededler[i] = eded % 10;
                eded /= 10;
              

            }
            for (int i = 0; i < eded; i++)
            {
                ededler1[i] = eded % 10;
                eded /= 10;


            }
            for (int i = 0; i < eded; i++)
            {
                if (ededler[i] == ededler1[i])
                {
                    return true;

                } 
            }
            return false;
            

        }
        static int[] Addelement(int[] arr, int eded)
        {
            int[] arr1 = new int[arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];


            }
            arr1[arr1.Length - 1] = eded;
            return arr1;

        }

        static bool Check(string metn, string soz)
        {
            for (int i = metn.Length-1; i <=0; i--)
            {
                for (int j = 0; j < metn[i]; j++)
                {
                    if (metn[i][j] == soz)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}
