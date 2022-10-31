using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class Program
    {
        int[] Richi = new int[30];
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
        

        static void Main(string[] args)
        {
        }
    }
}
