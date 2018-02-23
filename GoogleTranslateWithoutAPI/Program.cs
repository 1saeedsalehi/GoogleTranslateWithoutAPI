using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateWithoutAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLangugaes = Translator.Languages.ToList();
            Console.WriteLine("List of All Languages");
            foreach (var lang in allLangugaes)
            {

                Console.WriteLine(lang);

            }

            var key = "";
            while (key != "Q")
            {

                Translator t = new Translator();
                
                try
                {
                    Console.WriteLine("Source Text");
                    var srcText = Console.ReadLine();
                    Console.WriteLine("Choose Source Language");
                    var srcLang = Console.ReadLine();
                    Console.WriteLine("Choose Destinatiion Language");
                    var destLang = Console.ReadLine();
                    var transaltionResult = t.Translate(srcText, srcLang, destLang);
                    Console.WriteLine(transaltionResult);

                    if (t.Error != null)
                    {
                        Console.WriteLine(t.Error.Message);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("an exception occured :(" + Environment.NewLine + ex.Message);
                }
                finally
                {
                    Console.WriteLine(string.Format("Translated in {0} mSec", (int)t.TranslationTime.TotalMilliseconds));

                }

                Console.WriteLine("Press Q to quit.");
                key = Console.ReadLine();
            }


            Console.Read();
        }
    }
}
