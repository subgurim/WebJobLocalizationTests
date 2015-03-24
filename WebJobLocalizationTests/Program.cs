using System;
using System.Globalization;
using System.Threading;

namespace WebJobLocalizationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Console.WriteLine(Resource.HelloWorld);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            Console.WriteLine(Resource.HelloWorld);

            Console.ReadLine();
        }
    }
}