using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Softheme
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int countOne = 0;
            int [] arrOne=new int[100];//Массив,для записи количества единиц

            //string text = System.IO.File.ReadAllText(@"C:\Users\Zver\Desktop\C#\Softheme\input.txt");
            string text = System.IO.File.ReadAllText(@".\input.txt");
            char[] arr = text.ToCharArray();
            int j = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == '1')
                {
                    countOne += 1;
                }
                else {
                    arrOne[j] = countOne;
                    countOne = 0;
                    j++;
                
                }
            }
            if (countOne != 0) {
                arrOne[j] = countOne;
                j++;
            }
                
                //Max
            int max = 0;
                for (int i = 0; i < j; i++) {
                    if (arrOne[i] > max)
                     max = arrOne[i];
                }
                StreamWriter sw = new StreamWriter(@".\output.txt");
           sw.WriteLine(max);
           sw.Close();
            
            
            
        }
    }
}
