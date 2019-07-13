using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace ClearDomen_by_Ddps
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] allDomains, badDomains;
            try
            {
                allDomains = File.ReadAllLines("all.txt");
                badDomains = File.ReadAllLines("bad.txt");
            }
            catch
            {
                Console.WriteLine("Ошибка! Нету файла all.txt или bad.txt");
                return;
            }

            String[] goodDomains = new string[allDomains.Length];
            bool c = false;
            int count = 0;
            for(int i = 0; i < allDomains.Length; i++)
            {
                for(int j = 0; j < badDomains.Length; j++)
                {
                    if (allDomains[i] == badDomains[j])
                    {
                        c = true;
                        break;
                    }
                    
                }

                if (c)
                {
                    c = false;
                    continue;
                }
                goodDomains[count] = allDomains[i];
                count++;
            }

            File.WriteAllLines("good.txt", goodDomains);
            Console.WriteLine("Работа закончена!!!");
            Console.ReadKey();
        }

    }
}
