using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Data;

namespace DapperIntro
{
    class program
    {
        public static void  Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);
            var repo = new DapperDepartmentRepository(conn);

            Console.WriteLine("Type a new department name");

            var newDept = Console.ReadLine();
            repo.InsertDepartment(newDept);

            var departments = repo.GetAll();
            
            foreach(var dept in departments)
            {
                Console.WriteLine($"{dept.DepartmentID},{dept.Name}");
            }

        }
    }
}