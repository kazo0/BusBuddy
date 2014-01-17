using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Net;
using HtmlAgilityPack;

namespace WindowsApplication3
{
    class WorkerClass
    {
        public static void getSourceCode(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Headers.Add(System.Net.HttpRequestHeader.CacheControl, "no-cache");
           /* IWebProxy proxy = req.Proxy;
            if (proxy != null)
            {
                // Use the default credentials of the logged on user.
                proxy.Credentials = CredentialCache.DefaultCredentials;
            }*/
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
            req.Accept = "*/*";

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string sourceCode = sr.ReadToEnd();
            sr.Close();
            resp.Close();
            StreamWriter sw = new StreamWriter("website.html", false, Encoding.UTF8);
            sw.Write(sourceCode);
            sw.Close();
        }
        public static string getStopCodes(string url)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            getSourceCode(url);
            htmlDoc.Load("website.html");
            HtmlNode div = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='stops-list']");
            HtmlNodeCollection stopNames = htmlDoc.DocumentNode.SelectNodes("//span[@class='stops-list-item-desc']");
            HtmlNodeCollection stopIDs = htmlDoc.DocumentNode.SelectNodes("//span[@class='stops-list-item-id']");

            //return sourceCode;
            string go = "";

            for (int i = 0; i < stopNames.Count; i++)
            {
                go += stopNames[i].FirstChild.InnerText.Trim() + " " + stopIDs[i].InnerText.Trim();
                if (stopNames.Count != (i + 1))
                {
                    go += "\n";
                }
            }
                /*HtmlNodeCollection children = div.ChildNodes;
                foreach (HtmlNode child in children)
                {
                    if (child.Name == "a")
                    {
                        foreach (HtmlNode li in child.ChildNodes)
                        {
                            string tmp = li.InnerText.Trim();
                            if (!(tmp == ""))
                            {
                                go += tmp;
                            }
                        }
                    }
                }*/
                return go;
        }
        public static string getTimes(string url, string number)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            getSourceCode(url);
            htmlDoc.Load("website.html");
            // HtmlNodeCollection routes = htmlDoc.DocumentNode.SelectNodes("//div[@class='route']");
            HtmlNodeCollection times = htmlDoc.DocumentNode.SelectNodes("//div[@class='arrivals-list-item-text']");
            string timesStr = "";
            for (int i = 0; i < times.Count; i++)
            {
                timesStr += times[i].InnerText.Trim().Replace(" ", string.Empty);
                if (times.Count != (i+1))
                {
                    timesStr += " ";
                }
            }
            return timesStr;
        }

        public static string[] englishifyTimes(string[] times)
        {
            string tt = "AM";
            string[] newTimes = new string[5];
            int count = 0;
            foreach (string i in times)
            {
                if (i != "")
                {
                    string[] tempArr = i.Split('h');
                    int hour = Convert.ToInt32(tempArr[0]);
                    int newHour = 0;
                    if (hour >= 12)
                    {
                        tt = "PM";
                    }
                    if (hour != 12 && hour != 24)
                    {
                        newHour = hour % 12;
                    }
                    else
                    {
                        newHour = 12;
                    }

                    tempArr[0] = newHour.ToString();
                    newTimes[count] = tempArr[0] + ":" + tempArr[1] + tt;
                    count++;
                }
            }
            return newTimes;
        }
        public static bool checkFave(string fave)
        {
            StreamReader sr = new StreamReader("faves.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string line2 = line.Split('|')[0];
                if (line2 == fave)
                {
                    sr.Close();
                    return true;
                }
            }
            sr.Close();
            return false;

        }
        public static void delFave(string fave)
        {
            StreamReader sr = new StreamReader("faves.txt");
            string tempFile = Path.GetTempFileName();
            StreamWriter sw = new StreamWriter(tempFile);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string line2 = line.Split('|')[0];
                if (line2 != fave)
                {
                    sw.WriteLine(line);
                }
            }
            sw.Close();
            sr.Close();
            File.Delete("faves.txt");
            File.Move(tempFile, "faves.txt");
            

        }
        public static string[] getAlts(string code, string num)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.Load("website.html");
            HtmlNodeCollection p = htmlDoc.DocumentNode.SelectNodes("//p[@class='route-schedules']");
            string[] alts = new String[p.Count - 1];
            int i = 0;
            bool foundAlts = false;
            foreach (HtmlNode child in p)
            {
                string currentNum = child.PreviousSibling.PreviousSibling.InnerText.Split('|')[0];
                if (!(currentNum == "[ Ligne " + num + " ] "))
                {
                    foundAlts = true;
                    alts[i] = currentNum.Split(' ')[2];
                    i++;
                }
            }
            if (foundAlts)
            {
                return alts;
            }
            return null;
        }
    }
}
