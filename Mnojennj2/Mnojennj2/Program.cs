using System;
namespace Loop
{
    class Program
    {
        static void Main()
        {
            int i = 0;

            while (i < 10)
            {
                i++;
                Console.Write(i);
                {
                    Console.WriteLine();

                    int j = 0;
                    while (j < 10)
                    {
                        j++;
                        Console.Write(j);

                    }
                }


                Console.WriteLine();


                Console.ReadKey();
            }
        }
    }
}
        
    



//public class Solution
//{
  ///  public static void main(String[] args) throws Exception
    //{
      //  //напишите тут ваш код
        //int i = 1, n = 1;
        //while(i<=10)
        //{
          //  System.out.print(i+" ");
            //while(n<=9)
            //{
              //  n++;
                //System.out.print(i* n+" ");
//}
//i++;
  //          n=1;
    //        System.out.println("");
      //  }
   // }
//}