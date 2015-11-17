namespace PubNumDemo
{
    using System;
    using Constants;

    public class PubnubDemo
    {
        public static void Main()
        {
            PubnubAPI pubnub = new PubnubAPI(
                PubNubConstants.PublishKey,
                PubNubConstants.SubscribeKey,
                PubNubConstants.SecretKey,
                true);

            string channel = PubNubConstants.ChannelName;

            while (true)
            {
                Console.WriteLine("Enter a message to be sent to Pubnub: ");
                string msg = Console.ReadLine();
                pubnub.Publish(channel, msg);
                Console.WriteLine("Message {0} sent.", msg);
            }
        }
    }
}