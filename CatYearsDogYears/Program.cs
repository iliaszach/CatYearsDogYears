using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatYearsDogYears
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = humanYearsCatYearsDogYears(10);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

        }
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears=0, dogYears = 0;
            if (humanYears == 1)
            {
                catYears = 15;
                dogYears = 15;
            }
            if (humanYears == 2)
            {
               catYears = 15+9;
               dogYears = 15+9;                
            }
            if (humanYears > 2)
            {
                catYears = 15 + 9;
                dogYears = 15 + 9;
                for (int i = 0; i < humanYears -2; i++)
                {
                    catYears += 4 ;
                    dogYears += 5; 
                }
            }       
            
            return new int[] { humanYears, catYears, dogYears };
        }

    }
}
