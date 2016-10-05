using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EulerOne();
        }        

        public static void EulerOne()
        {
            int x= int.Parse(Console.ReadLine());
            int[] dividerArray = {3,5};
            int dividerLength = dividerArray.Length;
            int sum = 0;
            List<int> dividerColletion = new List<int>();
            for(int i =0 ; i < dividerLength;i++)
            {
                var divider = dividerArray[i];
                for(int k=divider ; k < x ; k  += divider)
                {
                    if(NotIncluded(dividerColletion,k))
                    {
                        dividerColletion.Add(k);
                        sum += k;
                    }                    
                }
            }
            Console.WriteLine(sum);
        }

        public static bool NotIncluded(List<int> collections, int number)
        {

            bool notIncluded = true;
            int collectionLength = collections.Count;
            for(int i=0; i < collectionLength; i++)
            {
                    if(collections[i] == number)
                    {
                        notIncluded = false;    
                    }
            }
            return notIncluded;
        }
    }    
}
