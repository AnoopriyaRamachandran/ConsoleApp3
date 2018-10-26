using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Runtime  Input         
            /*Console.WriteLine("Please enter the Input: For EX 1+2+3");
            string str = Console.ReadLine();
            String[] s = str.Split('+');
            int a =0;         
            for(int i=0;i<s.Length;i++)
            { 
            a += int.Parse(s[i]);        
            }            
            Console.WriteLine(a);           
            Console.ReadLine();*/
            //Static Input
            string str = "1+2+3";
            String[] s = str.Split('+');
            int a=0;
            for (int i = 0; i < s.Length; i++)
            {
                a += int.Parse(s[i]);
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
