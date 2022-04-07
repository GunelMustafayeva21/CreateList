using System;
using ListTask;


namespace ListTask
{
    class Program
    {
        static void Main(string[] args)
        {
           CreatedList<int> newList=new CreatedList<int>();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Add(6);

            newList.AddItems(6, 7, 8, 9, 10);

            newList.PrintArray();

            newList.Reverse();

            newList.PrintArray();

            Console.WriteLine(newList.Exist(5));

            newList.IndexOf(8);

            newList.LastIndexOf(6);

            newList.Clear();

            newList.PrintArray();

            newList.Remove();

            newList.PrintArray();

        }
    }
}