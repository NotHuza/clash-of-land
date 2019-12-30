using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace ClashLand_Updater.Core.Update
{
    class Updater
    {
        public static void DownloadUpdate()
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile("http://dl5.bodogame.com/dlnew1/ClashLand/Update.zip", @"..\Debug\Update.zip");
                Say("CLS Update Downloaded Successfully!");
                Unzip();
            }
            catch (Exception)
            {
                Error("Problem with downloading the CLS update, check your Network!");
                StartCLS();
            }
        }

        public static void Unzip()
        {
            if (Directory.Exists(@"..\Debug\Update"))
            {
                Directory.Delete(@"..\Debug\Update", true);
                Directory.CreateDirectory(@"..\Debug\Update");
            }
            else
            {
                Directory.CreateDirectory(@"..\Debug\Update");
            }
            try
            {
                string TargetDirectory = @"..\Debug\Update/";
                using (ZipFile zip = ZipFile.Read(@"..\Debug\Update.zip"))
                    zip.ExtractAll(TargetDirectory, ExtractExistingFileAction.Throw);
                File.Delete(@"..\Debug\Update.zip");

                Say("CLS Update Unzipped!");

                Update();

                //Delete Work Path
                Directory.Delete(@"..\Debug\Update", true);

                Say("CLS Update Installed Successfully, Starting CLS...");
                StartCLS();
            }
            catch (Exception)
            {
                Error("Problem with Unizp and Delete");
            }
        }

        public static void Update()
        {
            var directory = new DirectoryInfo(@"..\Debug");
            var files = directory.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                string destination = file.FullName.Replace(directory.FullName + @"\", "..\\");

                Console.WriteLine("Installing file {0} ...", destination);
                Directory.CreateDirectory(new FileInfo(destination).DirectoryName);
                file.CopyTo(destination, true);
            }
        }

        public static void Say(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void Error(string err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR]  " + err);
            Console.ResetColor();
        }

        public static void StartCLS()
        {
            Process.Start(@"..\CLS_v2018.exe");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
