using System;


namespace HashMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadManager threadManager = new ThreadManager();
            threadManager.Run();
            Console.ReadLine();
        }
    }
}
