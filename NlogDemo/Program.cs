using System;

namespace NlogDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNum obj = new AddNum();
            obj.Sum(2, 3);
            Console.WriteLine("This is a Logger Demo and Log generated successfully ");
            Console.ReadKey();
        }
    }
}
