using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceClient = new ServiceReference1.AccountingServiceClient();
            serviceClient.ClientCredentials.UserName.UserName = "TestUser";
            serviceClient.ClientCredentials.UserName.Password = "12355";

            Console.WriteLine(serviceClient.GetData(251));
            Console.ReadLine();

            serviceClient.Close();
        }
    }
}
