using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RegEx
{
    class Program
    {
        static string DownloadPage(string wikiLink)
        {
            using HttpClient client = new HttpClient();
            

            var response = client.GetAsync(wikiLink).Result;
            string htmlText = response.Content.ReadAsStringAsync().Result;

            return htmlText;
        }
        static string FindLinks(string htmlText)
        {
            var rnd = new Random();
            MatchCollection linksCollection = Regex.Matches(
                htmlText, @"\/wiki\/(?<name>[\w\(\)]+)");
            MatchCollection linksTest = Regex.Matches(htmlText, @"\/wiki\/.*\/");
            string[] linksS = new string[linksCollection.Count];
            int i = 0;
            foreach (Match link in linksCollection)
            {
                linksS[i] = link.ToString();
                i++;
            }

            int randLink = rnd.Next(1, linksS.Length);

            
            string fullLink = "https://en.wikipedia.org" + linksS[randLink];
            string checkLink = "";

            while (fullLink == "https://en.wikipedia.org/wiki/Terms_of_Use" || checkLink == fullLink || fullLink == "https://en.wikipedia.org/wiki/Privacy_policy" || fullLink == "https://en.wikipedia.org/wiki/Cookie_statement" || fullLink == "https://en.wikipedia.org/wiki/Terms_of_service" || fullLink == "https://en.wikipedia.org/wiki/Wikipedia" || fullLink == "https://en.wikipedia.org/wiki/Portal" || fullLink == "https://en.wikipedia.org/wiki/Special" || fullLink == "https://en.wikipedia.org/wiki/File" || fullLink == "https://en.wikipedia.org/wiki/Help" || fullLink == "https://en.wikipedia.org/wiki/Main_Page" || fullLink == "https://en.wikipedia.org/wiki/Category") {
                checkLink = fullLink;
                fullLink = "https://en.wikipedia.org" + linksS[rnd.Next(1, linksS.Length)];
            }

            return fullLink;
        }
        static void Main()
        {
            var wikiLink = "https://en.wikipedia.org/wiki/Main_Page";
            string htmlText = DownloadPage(wikiLink);
            while (true)
            {
                htmlText = DownloadPage(wikiLink);
                wikiLink = FindLinks(htmlText);
                Console.WriteLine(wikiLink);
            }
        }

    }
}
