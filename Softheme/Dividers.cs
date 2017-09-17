using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softheme
{
    class Dividers
    {  
        public void findDividers(){
        try{
            Console.Write("Enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The dividers of your number are:");
            for (int i = 1; i <= number; i++) {
                 if (number % i == 0)
                 {
                     Console.Write(i+"\n");
                 }
           
            }
        }
         catch (Exception)
            {
            Console.WriteLine("Error");
            }
        Console.ReadKey();
    }
    }
}
