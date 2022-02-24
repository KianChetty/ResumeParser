using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeParser.Data
{
    public class ResultsService : IResults
    {

    


        public string GetResults()
        {
           
                // 1) Create Process Info
                var psi = new ProcessStartInfo();
                psi.FileName = @"C:\Program Files\Python39\python.exe";
                // 2) Provide script and arguments
                var script = @"C:\Users\Kian\PycharmProjects\ResumeParser\main.py";
                psi.Arguments = $"\"{script}\" ";
                // 3) Process configuration
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                // 4) Execute process and get output
                var errors = "";
                var output = "";
                Console.WriteLine("starting script"); 
                var process = Process.Start(psi);
                errors = process.StandardError.ReadToEnd();
                output = process.StandardOutput.ReadToEnd();
                // 5) Display output
                Console.WriteLine("ERRORS:");
                Console.WriteLine(errors);
                Console.WriteLine();
                Console.WriteLine("Results:");
                Console.WriteLine(output);
            

            return output; 
            
        }
    }
}
