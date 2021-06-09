using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Controllers;



namespace WindowsServiceHosting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Check for the Debugger is attached or not if attached then run the application in IIS or IISExpress
            var isService = false;
            //when the service start we need to pass the --service parameter while running the .exe
            if (Debugger.IsAttached == false && args.Contains("--service"))
            {
                isService = true;
            }

            if (isService)
            {
                DateUpdateContoller dateUpdateContoller = new DateUpdateContoller();
                dateUpdateContoller.Update();
                
                //Get the Content Root Directory
                var pathToContentRoot = Directory.GetCurrentDirectory();

                //If the args has the console element then than make it in array.
                var webHostArgs = args.Where(arg => arg != "--console").ToArray();

                string ConfigurationFile = "appsettings.json"; //Configuration file.
                string portNo = "5001"; //Port

                var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                pathToContentRoot = Path.GetDirectoryName(pathToExe);

                //Get the json file and read the service port no if available in the json file.
                string AppJsonFilePath = Path.Combine(pathToContentRoot, ConfigurationFile);

                if (File.Exists(AppJsonFilePath))
                {
                    using (StreamReader sr = new StreamReader(AppJsonFilePath))
                    {
                        string jsonData = sr.ReadToEnd();
                        JObject jObject = JObject.Parse(jsonData);
                        if (jObject["ServicePort"] != null)
                            portNo = jObject["ServicePort"].ToString();

                    }
                }


                var host = WebHost.CreateDefaultBuilder(webHostArgs)
                .UseContentRoot(pathToContentRoot)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:" + portNo)
                .Build();
                host.RunAsService();
            }
            else
            {
                CreateHostBuilder(args).Build().Run();
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
