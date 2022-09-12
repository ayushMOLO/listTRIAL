using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listTRIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Enter number");
            num=int.Parse(Console.ReadLine());

            while (num != -1) 
            {
                queue.Enqueue(num);
                Console.WriteLine("Enter number");
                num = int.Parse(Console.ReadLine());

            }

            int size=queue.Count;
            int[] arr=new int[size];
            List<int> list=new List<int>(); 
            Dictionary<int,int> dict=new Dictionary<int,int>();

            for (int i=0; i<size; i++)
            {
                arr[i]=queue.Dequeue();
                list.Add(arr[i]);
                dict.Add(i, arr[i]);
            }

            Console.WriteLine("For array");
            for (int i=0; i<size; i++)
            {
                Console.Write("Index is " + i);
                Console.WriteLine(" "+arr[i]);
            }

         Console.WriteLine("For list");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index is " + i);
                Console.WriteLine(" "+list[i]);
            }

            Console.WriteLine("For dictionary");
           foreach(KeyValuePair<int,int> pair in dict)
            {
                Console.WriteLine(pair.Key + ": "+pair.Value);

            }


            Console.ReadLine();    

        }
    }
}
