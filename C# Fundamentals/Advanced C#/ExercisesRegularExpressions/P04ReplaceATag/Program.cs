using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04ReplaceATag
{
    public class Program
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();

            StringBuilder htmlDocumentSB = new StringBuilder();

            while (html != "end")
            {
                htmlDocumentSB.Append(html);
                html = Console.ReadLine();
            }

            string htmlDocument = htmlDocumentSB.ToString();

            string patternOpeningTag = @"<a(.*)>(.*)<\/a>";
            string replacement = @"[URL $1]$2[/URL]";

            Console.WriteLine(Regex.Replace(htmlDocument, patternOpeningTag, replacement));
        }
    }
}
