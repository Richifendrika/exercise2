using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class Program
    {
        int[] richi = new int[30];
        int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan jumlah data yang akan diurutkan : ");
                string s = Console.ReadLine();

                n = Int32.Parse(s);
                if (n > 0 && n <= 30)
                    break;
                else
                    Console.WriteLine("\nJumlah maksimal data yang harus dimasukkan adalah 30. \n");
            }
            Console.WriteLine("\n----------");
            Console.WriteLine("Masukkan data \n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();

                richi[i] = Int32.Parse(s1);
            }
        }

        public void display ()
        {
            Console.WriteLine("\n----------");
            Console.WriteLine("Mengurutkan data \n");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(richi[i]);
            }
        }

        public void sort()
        {
           for (int i = 1; i < n - 1; i++)
           {
                int Temp = richi[i];
                int AR = i - 1;

                while (AR >= 0 && richi[AR] > Temp)
                {
                    richi[AR + 1] = richi[AR];
                    AR
                }
           

        static void Main(string[] args)
        {
        }
    }
}
