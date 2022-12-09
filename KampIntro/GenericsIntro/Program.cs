using System;

namespace GenericsIntro // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Alptekin");
            //Console.WriteLine(names.Length);
            names.Add("Alptekin");
            //Console.WriteLine(names.Length);
            foreach (var namesItem in names.Items)
            {
                Console.WriteLine(namesItem);
            }
        }
    }
}