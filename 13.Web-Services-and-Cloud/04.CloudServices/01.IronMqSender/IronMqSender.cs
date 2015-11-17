namespace _01.IronMqSender
{
    using System;
    using System.IO;
    using System.Net;
    using Constants;
    using IronSharp.IronMQ;

    public class IronMqSender
    {
        public static void Main()
        {
            Console.WriteLine("Attempting to get your machine's IP address, please be patient...");
            string ip = GetIpAddress().Trim();
            var client = Client.New(IronMqConstants.ProjectId, IronMqConstants.Token);
            var queue = client.Queue(IronMqConstants.QueueName);
            Console.WriteLine("Enter messages to be sent to the server:");

            while (true)
            {
                string msg = Console.ReadLine();
                queue.Post("IP: " + ip + " : " + msg);
                Console.WriteLine("Message sent!");
            }
        }

        private static string GetIpAddress()
        {
            // check IP using DynDNS's service
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org");
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());

            // read complete response
            string userIp = stream.ReadToEnd();

            // replace everything and return only the IP
            return userIp
                .Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address: ", string.Empty)
                .Replace("</body></html>", string.Empty);
        }
    }
}
