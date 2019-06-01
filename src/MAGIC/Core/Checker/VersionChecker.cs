using System;
using System.Diagnostics;
using System.IO.Compression;
using Ionic.Zlib;
using System.IO;
using System.Net;
using System.Threading;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ClashLand.core.Checker
{
    internal class VersionChecker
    {

        public static string GetVersionString()
        {
            try
            {
                string Version = new WebClient().DownloadString(new Uri("http://antzps.ddns.net/clashLand/version.json"));
                JObject obj = JObject.Parse(Version);
                return (string)obj["version"];
            }
            catch (Exception)
            {
                return "Error";
            }
        }
    }
}
