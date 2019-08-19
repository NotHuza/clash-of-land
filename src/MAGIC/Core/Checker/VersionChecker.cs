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
                string Version = "2.1.0.0";// im it crack for my
                return (Version);
            }
            catch (Exception)
            {
                return "Error";
            }
        }
    }
}
