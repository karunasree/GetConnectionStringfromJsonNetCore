using System;
using System.IO;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Reflection;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    /**
     * Get Connection String .Net Core from Json File
     * Step 1: Add Nuget Packages - Microsoft.Extensions, Microsoft.Extensions.Configuration.Json
     * Step 2: Add Json Configuration file
     * Step 3: Set the output Directory of the Json to 'Copy Always', otherwise you will get 'FileNotFoundException' exception
     * Step 4: Add Connection String to Json File
     * Step 5: Get Configuration Key/Value Pair
     *
     */

    public class Program
    {
        static void Main(string[] args)
        {
            // ConfigurationBuilder is used to build key/value based configuration settings for use in an application or 
            // Alternate Way: Use IConfiguration Interface and inject in the Constructor
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("tsconfig1.json", false).Build();


            //Get Configuration Key/Value Pair
            string str = configuration.GetSection("ConnectionString").Value;

            //Write the String
            Console.WriteLine(str);
            Console.ReadLine();


        }
    }
}

 