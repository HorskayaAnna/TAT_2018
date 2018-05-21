using System;

namespace Task3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                FileFinder fileFinder = new FileFinder(args[0], args[1]);
                string[] files = fileFinder.GetFilesByExtension();
                for (int i = 0; i < files.Length; ++i)
                {
                    Console.WriteLine(files[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}