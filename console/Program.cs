namespace Console
{
    using System;
    using System.IO;

    using ClassLib;

    public static class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var importedClassLib = new Class1();
                importedClassLib.MakeExcel();
                Console.WriteLine("Successfully called EPPlus");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Dependency on EPPlus not pulled through from classlib during build");
                throw;
            }
        }
    }
}
