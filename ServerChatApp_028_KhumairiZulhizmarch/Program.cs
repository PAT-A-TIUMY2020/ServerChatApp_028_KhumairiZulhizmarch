using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerChatApp_028_KhumairiZulhizmarch
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost hostObject = null;

            try
            {
                hostObject = new ServiceHost(typeof(ServiceCallback));
                hostObject.Open();

                Console.WriteLine("Serves On, Ready to use");
                Console.ReadLine();

                hostObject.Close();
            }
            catch (Exception ex)
            {
                hostObject = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
