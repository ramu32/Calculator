using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WiniUm
{
    using AventStack.ExtentReports.Model;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Winium;
    using System.Security.Policy;
    using System.Windows.Automation;
    using Winium.Cruciatus.Core;
    using Winium.Cruciatus.Extensions;
   
    class Program
    {
       // protected ExtentReports _extent;
        //protected ExtentTest _test;

        static void Main(string[] args)
        {
            RootObject obj = new RootObject();
            //List<TestcasesResult> testcases_result = new TestcasesResult();
            obj.start_time = DateTime.Now.ToString();
            var dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:/windows/system32/calc.exe");

            
           // DesktopOptions optio

          


            // ExtentReports _extent = new ExtentReports();
             var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
              DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");
             //var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports\\Automation_Report.html");
            //  _extent.AddSystemInfo("Environment", "Journey of Quality");
            //_extent.AddSystemInfo("User Name", "Sanoj");
            // _extent.AttachReporter(htmlReporter);
           // var calc = new Winium.Cruciatus.Application("C:/windows/system32/calc.exe");

            //calc.Start();
            var driver = new RemoteWebDriver(new Uri("http://10.11.52.189:9999"), dc);
           // driver.
            // ExtentTest _test = _extent.CreateTest("Winium Test Cases"); 
            Console.WriteLine("Application is launched");
            var winFinder = By.Name("Calculator").AndType(ControlType.Window);
            var win = Winium.Cruciatus.CruciatusFactory.Root.FindElement(winFinder);
            win.FindElementByName("Nine").Click();
            Console.WriteLine("Clicked on Button in Application");
           // _test.Log(Status.Info, "Clicked on Button in Application");
            win.FindElementByName("Eight").Click();
            Console.WriteLine("Clicked on Link in Application");
            win.FindElementByName("Plus").Click();
            Console.WriteLine("Clicked on Link in Application");
            win.FindElementByName("Six").Click();
            win.FindElementByName("Seven").Click();
            win.FindElementByName("Equals").Click();
            Console.WriteLine("Clicked on Equals Button in Application");

            Dataset dtCls = new Dataset()
            {
                 result_type="Clicked On Button",
                  text= "Clicked on Equals Button in Application"
            };


            Dataset dtCls2 = new Dataset()
            {
                result_type = "Clicked On Button",
                text = "Clicked on Equals Button in Application"
            };

            List<Dataset> dsList = new List<Dataset>();
            dsList.Add(dtCls);
            dsList.Add(dtCls2);


            obj.testcases_result.Add(new TestcasesResult
            {
                browser_type = "",
                datasets = dsList,
                testcase_name = ""
            });

            var jSonString = JsonConvert.SerializeObject(obj);
           var fPath= dir + "\\test.json";
           // fPath = dir + "\\testts.txt";
            //dir
            StreamWriter sw = new StreamWriter(fPath);

            sw.Write(jSonString);
            sw.Close();
           // _extent.Flush();
            // calc.Close();
        }
    }
}
