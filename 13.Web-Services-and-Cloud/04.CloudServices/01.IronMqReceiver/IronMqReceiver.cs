namespace _01.IronMqReceiver
{
    using System;
    using System.Threading;
    using Constants;
    using IronSharp.IronMQ;

    public class IronMqReceiver
    {
        public static void Main()
        {
            IronMqRestClient client = Client.New(IronMqConstants.ProjectId, IronMqConstants.Token);
            QueueClient queue = client.Queue(IronMqConstants.QueueName);

            Console.WriteLine("Listening for new messages from IronMQ server:");
            while (true)
            {
                var msg = queue.Next();

                if (msg.Result != null)
                {
                    Console.WriteLine(msg.Result.Body);
                    Console.WriteLine();
                    queue.Delete();
                }

                Thread.Sleep(100);
            }
        }
    }
}