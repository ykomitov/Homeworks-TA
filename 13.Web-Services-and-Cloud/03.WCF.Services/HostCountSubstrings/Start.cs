namespace HostCountSubstrings
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using CountSubstringsWithinString;

    public class Start
    {
        // Please run the .exe file, or Visual Studio as Administrator
        public static void Main()
        {
            Uri serviceAddress = new Uri("http://localhost:1234/substring");
            ServiceHost selfHost = new ServiceHost(typeof(CountSubstringsService), serviceAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            using (selfHost)
            {
                selfHost.Open();
                Console.WriteLine("The service is started at endpoint " + serviceAddress);

                var client = new CountSubstringsService();
                var subString = "ta";
                var originalString = "ssdta ksks ta ta tata";
                var count = client.CountSubstringRepetitionsWithinString(subString, originalString);
                Console.WriteLine("Substring \"{0}\" is contained within \"{1}\" {2} times.", subString, originalString, count);
                Console.ReadLine();
            }
        }
    }
}
