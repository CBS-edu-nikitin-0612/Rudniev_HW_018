using System;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("aspire v5", "asus", 12333.99);
            Console.WriteLine(notebook.ToString());
        }
    }
}
