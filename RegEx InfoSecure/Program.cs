using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RegEx_InfoSecure
{
    class Program
    {
        static string GetPage(string link, string second)
        {
            using HttpClient client = new HttpClient();
            try
            {
                var response = client.GetAsync(link).Result;
                var htmlText = response.Content.ReadAsStringAsync().Result;
                return htmlText;
            }
            catch
            {
                Console.WriteLine(second);
                var response = client.GetAsync(second).Result;
                var htmlText = response.Content.ReadAsStringAsync().Result;
                return htmlText;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку: ");
            string frPart = Console.ReadLine();
            string secondPart = "https://" + frPart + "/";
            string linkOne = secondPart;
            while (true) {
                List<string> links = new List<string>();
                var rnd = new Random();
                string htmlText = GetPage(linkOne, secondPart);
                string strLink;


                MatchCollection linksCollection = Regex.Matches(htmlText, @"\/wiki\/(?<name>[\w\(\)]+)");
                MatchCollection linksCollections = Regex.Matches(htmlText, @"(http|https|ftp|)\:\/\/[\w]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?([a-zA-Z0-9\-\?\,\'\/\+&%\$#_]+)");
                foreach (Match link in linksCollections)
                {
                    strLink = link.ToString(); ;
                    try
                    {
                        if ((strLink.Contains(".com") || strLink.Contains(".ru") || strLink.Contains(".org")) && (!strLink.Contains("schema.org") && !strLink.Contains("font") && !strLink.Contains("css") && !strLink.Contains(".ico") && !strLink.Contains("watch") && !strLink.Contains("svg") && !strLink.Contains("png") && !strLink.Contains("jpg") && !strLink.Contains("js") && !strLink.Contains("w3")))
                        {
                            links.Add(strLink);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                string[] arrLinks = links.ToArray();
                try
                {
                    linkOne = arrLinks[rnd.Next(1, arrLinks.Length)];
                }
                catch
                {
                    foreach (var el in arrLinks)
                    {
                        Console.WriteLine($"Error is = {el}");
                    }
                    linkOne = secondPart;
                    Console.WriteLine($"Что-то пошло не так! Идем заново по ссылке {secondPart}!");
                }
                Console.WriteLine(linkOne);
            }
        }
    }
}
