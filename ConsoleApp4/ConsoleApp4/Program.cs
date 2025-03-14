using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //domasna 1
            //prva domasna
            Int32 number = 10;
            Int32 number1 = 15;
            long result = number + number1;
            Console.WriteLine(result);
            //vtora domasna
            int number3 = 10;
            int number4 = 15;
            int number5 = 20;
            int number6 = 30;
            int result2 = number3 + number4 + number5 + number6;
            int avarage = result2 / 4;
            Console.WriteLine(avarage);
            //treta domasna
            Console.WriteLine("type 2 characters");
            int number7;
            int number8;
            number7 = Convert.ToInt32(Console.ReadLine());
            number8 = Convert.ToInt32(Console.ReadLine());
            //ova go najdov na internet mislev prvo da go napraam so placeholder i da mu ja zeme vrednosta pa posle da mu ja staam na 0 i posle da gi smenam taka ama ova mi bese polesno
            (number7, number8) = (number8, number7);
            Console.WriteLine(number7);
            Console.WriteLine(number8);
            
            //kraj na domasna 1







            //pocetok na domasna 2
            /*`nt[] arr = new int[6];                          
            for( int i=0 ; i<=arr.Length ; i++ )
              {

                  Console.WriteLine("type a number");
                  int idk = Convert.ToInt32(Console.ReadLine());
                arr.push('idk');
              }
            */
            
            //dali moze da mi kazete nacin da go napravam so nacinot sto e pogore
          Console.WriteLine("Please enter the first number of the first array");

           int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number of the first array");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number of the first array");

            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number of the first array");

            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the fifth number of the first array");

            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the sixth number of the first array");

            int f = Convert.ToInt32(Console.ReadLine());

            int[] Array1 = { a, b, c, d, e, f };


            int result12=0;
              foreach (int i in Array1)
               {
              
                if (i % 2 == 0)
                {

                    result12 += i;
                    
                }
               
            }
            Console.WriteLine("this is the sum of the numbers which are dividable of 2 " + result12);

            //vtor del od domasna
            string[] array3 = new string[] { "skale", "ajvar", "mihail1", "mihail2", "mihail3" }; 
            string[] shorterWay = { "skale123", "ajvar123", "mihail123", "mihail2123", "mihail3123" };
            //mozev so linija 102 ista da bide na 101 ama iskreno neznam zosto bi koristel prviot metod isto taka ne mi rabotese so '' posle toa se setiv deka to bese za character navika od java script
            Console.WriteLine("Input 1 or 2");
            int NumberForGuess = Convert.ToInt32(Console.ReadLine());
            if (NumberForGuess < 3)
            {
                if (NumberForGuess == 1)
                {
                    foreach(string i in array3)
                    {
                        Console.Write(i+" ");
                    }
                }
                else
                {
                    foreach (string i in shorterWay)
                    {
                        Console.Write(i + " ");
                    }
                }
            }else
            {
                Console.WriteLine("this number is bigger then 2");
            }
            
            
           

        }
    }
}
