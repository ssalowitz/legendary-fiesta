using System;
using System.Net;
using System.Threading;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
                        
            //Gets private ip and hostname

            string hostName = Dns.GetHostName();
            string privIp = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.ReadKey();

            //Gets public ip

            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

        //Gets hack

        //Displays private ip and hostname

        Display:
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("You're hostname is " + hostName);
            Console.WriteLine("You're private ip address is " + privIp);
            Console.WriteLine("You're public ip address is " + address);
            Thread.Sleep(99999);

                       
           
        }

}
