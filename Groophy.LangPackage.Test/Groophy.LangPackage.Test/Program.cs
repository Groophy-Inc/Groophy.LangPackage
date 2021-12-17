using System;

namespace Groophy.LangPackage.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Lang l = new Lang();
            l.ReadLang("C:\\Users\\<username>\\Desktop\\test.lang");
            //BatchIDE=Groophy.Inc
            //bat=kvc/*owner of batch-man*/

            Console.WriteLine(l["BatchIDE"] + " - " + l["bat"]);
            //Groophy.Inc - kvc

            Console.ReadKey();
        }
    }
}
